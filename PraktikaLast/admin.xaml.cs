using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PraktikaLast.Last6DataSetTableAdapters;

namespace PraktikaLast
{
    public partial class admin : Window
    {
        DolzhnostTableAdapter adapter = new DolzhnostTableAdapter();
        public admin()
        {
            InitializeComponent();
            RoliGrid.ItemsSource = adapter.GetData();
        }
        private void Button_dobavit_Click(object sender, RoutedEventArgs e)
        {
            if (RolBox.Text != "")
            {
                string a1 = RolBox.Text;
                if (System.Text.RegularExpressions.Regex.IsMatch(a1, "^[a-zA-Z]+$"))
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

        private void Button_udalenie_Click(object sender, RoutedEventArgs e)
        {
            if (RoliGrid.SelectedItem != null)
            {
                object id = (RoliGrid.SelectedItem as DataRowView).Row[0];
                adapter.DeleteQuery(Convert.ToInt32(id));
                RoliGrid.ItemsSource = adapter.GetData();
            }
            else
            {
                MessageBox.Show("Вы выбрали пустое поле!");
            }
        }

        private void button_izmena_Click(object sender, RoutedEventArgs e)
        {
            if (RoliGrid.SelectedItem != null && RolBox.Text != "")
            {
                string a1 = RolBox.Text;
                if (System.Text.RegularExpressions.Regex.IsMatch(a1, "^[a-zA-Z]+$"))
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

        private void Button_sotrudniki_Click(object sender, RoutedEventArgs e)
        {
            admin_sotrundiki window1 = new admin_sotrundiki();
            window1.Show();
            this.Hide();
        }

        private void RoliGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RoliGrid.SelectedItem != null)
            {
                object selectedRow = (RoliGrid.SelectedItem as DataRowView).Row[1];
                RolBox.Text = Convert.ToString(selectedRow);
            }
        }

        private void Button_sotrudniki_Copy_Click(object sender, RoutedEventArgs e)
        {
            admin_dannie window2 = new admin_dannie();
            window2.Show();
            this.Hide();
        }
    }
}
