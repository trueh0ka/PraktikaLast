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
using PraktikaLast.Last6DataSetTableAdapters;

namespace PraktikaLast
{
    public partial class prodavec_pocupatel : Window
    {
        PokypatelTableAdapter adapter = new PokypatelTableAdapter();
        public prodavec_pocupatel()
        {
            InitializeComponent();
            RoliGrid.ItemsSource = adapter.GetData();
        }

        private void Button_sotrudniki_Copy1_Click(object sender, RoutedEventArgs e)
        {
            istoria_pokupok window3 = new istoria_pokupok();
            window3.Show();
            this.Hide();
        }

        private void Button_dobavit_Click(object sender, RoutedEventArgs e)
        {
            if (RolBox.Text != "" && RolBox_Copy.Text != "" && RolBox_Copy1.Text != "")
            {
                string a1 = RolBox.Text;
                string a2 = RolBox_Copy.Text;
                string a3 = RolBox_Copy1.Text;
                if (System.Text.RegularExpressions.Regex.IsMatch(a1, "^[а-яА-Я]+$") && (System.Text.RegularExpressions.Regex.IsMatch(a2, "^[0-9+]+$")) && (System.Text.RegularExpressions.Regex.IsMatch(a3, "^[a-zA-Z@.]+$")))
                {
                    adapter.InsertQuery(RolBox.Text, RolBox_Copy.Text, RolBox_Copy1.Text);
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
            if (RoliGrid.SelectedItem != null && RolBox.Text != "" && RolBox_Copy.Text != "" && RolBox_Copy1.Text != "")
            {
                string a1 = RolBox.Text;
                string a2 = RolBox_Copy.Text;
                string a3 = RolBox_Copy1.Text;
                if (System.Text.RegularExpressions.Regex.IsMatch(a1, "^[а-яА-Я]+$") && (System.Text.RegularExpressions.Regex.IsMatch(a2, "^[0-9+]+$")) && (System.Text.RegularExpressions.Regex.IsMatch(a3, "^[a-zA-Z@.]+$")))
                {
                    object id2 = (RoliGrid.SelectedItem as DataRowView).Row[0];
                    adapter.UpdateQuery(RolBox.Text, RolBox_Copy.Text, RolBox_Copy1.Text, Convert.ToInt32(id2));
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
                object selectedRow2 = (RoliGrid.SelectedItem as DataRowView).Row[2];
                object selectedRow3 = (RoliGrid.SelectedItem as DataRowView).Row[3];
                RolBox.Text = Convert.ToString(selectedRow);
                RolBox_Copy.Text = Convert.ToString(selectedRow2);
                RolBox_Copy1.Text = Convert.ToString(selectedRow3);
            }
        }

        private void Button_sotrudniki_Click(object sender, RoutedEventArgs e)
        {
            prodavec_tip_oplati window1 = new prodavec_tip_oplati();
            window1.Show();
            this.Hide();
        }
    }
}
