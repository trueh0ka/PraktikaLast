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
    public partial class admin_sotrundiki : Window
    {
        SotrudnikTableAdapter adapter = new SotrudnikTableAdapter();
        DannieTableAdapter adapter2 = new DannieTableAdapter();
        public admin_sotrundiki()
        {
            InitializeComponent();
            RoliGrid.ItemsSource = adapter.GetData();
            combo.ItemsSource = adapter2.GetData();
            combo.DisplayMemberPath = "dannie_id";
        }

        private void RoliGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RoliGrid.SelectedItem != null)
            {
                object selectedRow = (RoliGrid.SelectedItem as DataRowView).Row[1];
                object selectedRow2 = (RoliGrid.SelectedItem as DataRowView).Row[2];
                object selectedRow3 = (RoliGrid.SelectedItem as DataRowView).Row[3];
                loginbox.Text = Convert.ToString(selectedRow);
                loginbox_Copy.Text = Convert.ToString(selectedRow2);
                combo.Text = Convert.ToString(selectedRow3);
            }
        }

        private void Button_dobavit_Click(object sender, RoutedEventArgs e)
        {
            if (loginbox.Text != "" && loginbox_Copy.Text != "" && combo.Text != "")
            {
                string a1 = loginbox.Text;
                string a2 = loginbox_Copy.Text;
                if (System.Text.RegularExpressions.Regex.IsMatch(a1, "^[0-9+]+$") && (System.Text.RegularExpressions.Regex.IsMatch(a2, "^[a-zA-Z.@0-9]+$")))
                {
                    adapter.InsertQuery(loginbox.Text, loginbox_Copy.Text, Convert.ToInt32((combo.SelectedItem as DataRowView).Row[0]));
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
            if (RoliGrid.SelectedItem != null && loginbox.Text != "" && loginbox_Copy.Text != "" && combo.Text != "")
            {
                string a1 = loginbox.Text;
                string a2 = loginbox_Copy.Text;
                if (System.Text.RegularExpressions.Regex.IsMatch(a1, "^[0-9+]+$") && (System.Text.RegularExpressions.Regex.IsMatch(a2, "^[a-zA-Z.@0-9]+$")))
                {
                    object id2 = (RoliGrid.SelectedItem as DataRowView).Row[0];
                    adapter.UpdateQuery(loginbox.Text, loginbox_Copy.Text, Convert.ToInt32((combo.SelectedItem as DataRowView).Row[0]), Convert.ToInt32(id2));
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

        private void button_roli_Click(object sender, RoutedEventArgs e)
        {
            admin window = new admin();
            window.Show();
            this.Hide();
        }

        private void Button_sotrudniki_Copy_Click(object sender, RoutedEventArgs e)
        {
            admin_dannie window1 = new admin_dannie();
            window1.Show();
            this.Hide();
        }
    }
}