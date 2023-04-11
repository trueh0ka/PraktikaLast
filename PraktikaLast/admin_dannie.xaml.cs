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
    public partial class admin_dannie : Window
    {
        DannieTableAdapter adapter = new DannieTableAdapter();
        DolzhnostTableAdapter adapter2 = new DolzhnostTableAdapter();
        public admin_dannie()
        {
            InitializeComponent();
            RoliGrid.ItemsSource = adapter.GetData();
            combo.ItemsSource = adapter2.GetData();
            combo.DisplayMemberPath = "dolzhnost_id";
        }

        private void button_roli_Click(object sender, RoutedEventArgs e)
        {
            admin window = new admin();
            window.Show();
            this.Hide();
        }

        private void Button_sotrudniki_Click(object sender, RoutedEventArgs e)
        {
            admin_sotrundiki window2 = new admin_sotrundiki();
            window2.Show();
            this.Hide();
        }

        private void Button_dobavit_Click(object sender, RoutedEventArgs e)
        {
            if (RolBox.Text != "" && combo.Text != "")
            {
                string a1 = RolBox.Text;
                string a2 = password.Password;
                if (System.Text.RegularExpressions.Regex.IsMatch(a1, "^[a-zA-Z0-9]+$") && (System.Text.RegularExpressions.Regex.IsMatch(a2, "^[a-zA-Z0-9]+$")))
                {
                    adapter.InsertQuery(RolBox.Text, password.Password, Convert.ToInt32((combo.SelectedItem as DataRowView).Row[0]));
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
            if (RoliGrid.SelectedItem != null && RolBox.Text != "" && combo.Text != "")
            {
                string a1 = RolBox.Text;
                string a2 = password.Password;
                if (System.Text.RegularExpressions.Regex.IsMatch(a1, "^[a-zA-Z0-9]+$") && (System.Text.RegularExpressions.Regex.IsMatch(a2, "^[a-zA-Z0-9]+$")))
                {
                    object id2 = (RoliGrid.SelectedItem as DataRowView).Row[0];
                    adapter.UpdateQuery(RolBox.Text, password.Password, Convert.ToInt32((combo.SelectedItem as DataRowView).Row[0]), Convert.ToInt32(id2));
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

        private void RoliGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RoliGrid.SelectedItem != null)
            {
                object selectedRow = (RoliGrid.SelectedItem as DataRowView).Row[1];
                object selectedRow2 = (RoliGrid.SelectedItem as DataRowView).Row[2];
                object selectedRow3 = (RoliGrid.SelectedItem as DataRowView).Row[3];
                RolBox.Text = Convert.ToString(selectedRow);
                password.Password = Convert.ToString(selectedRow2);
                combo.Text = Convert.ToString(selectedRow3);
            }
        }
    }
}