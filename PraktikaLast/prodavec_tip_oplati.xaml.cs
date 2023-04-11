using PraktikaLast.Last6DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PraktikaLast
{
    public partial class prodavec_tip_oplati : Window
    {
        Tip_oplatiTableAdapter adapter = new Tip_oplatiTableAdapter();
        public prodavec_tip_oplati()
        {
            InitializeComponent();
            RoliGrid.ItemsSource = adapter.GetData();
        }

        private void button_roli_Click(object sender, RoutedEventArgs e)
        {
            prodavec_pocupatel window1 = new prodavec_pocupatel();
            window1.Show();
            this.Hide();
        }

        private void Button_sotrudniki_Copy1_Click(object sender, RoutedEventArgs e)
        {
            istoria_pokupok window3 = new istoria_pokupok();
            window3.Show();
            this.Hide();
        }

        private void Button_dobavit_Click(object sender, RoutedEventArgs e)
        {
            if (RolBox.Text != "")
            {
                string a1 = RolBox.Text;
                if (System.Text.RegularExpressions.Regex.IsMatch(a1, "^[а-яА-Я]+$"))
                {
                    adapter.InsertQuery(RolBox.Text);
                    RoliGrid.ItemsSource = adapter.GetData();
                }
                else
                {
                    MessageBox.Show("Лишние символы!");
                }
            }
            else
            {
                MessageBox.Show("Какое-то поле пустое!");
            }
        }

        private void button_izmena_Click(object sender, RoutedEventArgs e)
        {
            if (RoliGrid.SelectedItem != null && RolBox.Text != "")
            {
                string a1 = RolBox.Text;
                if (System.Text.RegularExpressions.Regex.IsMatch(a1, "^[а-яА-Я]+$"))
                {
                    object id2 = (RoliGrid.SelectedItem as DataRowView).Row[0];
                    adapter.UpdateQuery(RolBox.Text, Convert.ToInt32(id2));
                    RoliGrid.ItemsSource = adapter.GetData();
                }
                else
                {
                    MessageBox.Show("Лишние символы!");
                }
            }
            else
            {
                MessageBox.Show("Какое-то поле пустое!");
            }
        }

        private void Button_udalenie_Click(object sender, RoutedEventArgs e)
        {
            if (RoliGrid.SelectedItem != null)
            {
                object id = (RoliGrid.SelectedItem as DataRowView).Row[0];
                adapter.DeleteQuery(Convert.ToInt32(id));
                RoliGrid.ItemsSource = adapter.GetData();
            }
        }

        private void RoliGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RoliGrid.SelectedItem != null)
            {
                object selectedRow = (RoliGrid.SelectedItem as DataRowView).Row[1];
                RolBox.Text = Convert.ToString(selectedRow);
            }
        }
    }
}
