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
    public partial class postavshik2 : Window
    {
        PostavkiTableAdapter adapter = new PostavkiTableAdapter();
        PostavshikiTableAdapter adapter2 = new PostavshikiTableAdapter();
        TovarTableAdapter adapter3 = new TovarTableAdapter();
        public postavshik2()
        {
            InitializeComponent();
            RoliGrid.ItemsSource = adapter.GetData();
            combo.ItemsSource = adapter3.GetData();
            combo.DisplayMemberPath = "id_tovar";
            combo2.ItemsSource = adapter2.GetData();
            combo2.DisplayMemberPath = "postavshiki_id";
        }

        private void button_roli_Click(object sender, RoutedEventArgs e)
        {
            postavshik window = new postavshik();
            window.Show();
            this.Hide();
        }

        private void Button_dobavit_Click(object sender, RoutedEventArgs e)
        {
            if (dataBox.Text != "")
            {
                string a1 = dataBox.Text;
                if (System.Text.RegularExpressions.Regex.IsMatch(a1, "^[0-9.]+$"))
                {
                    adapter.InsertQuery(dataBox.Text, Convert.ToInt32(combo2.Text), Convert.ToInt32(combo.Text));
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
            if (RoliGrid.SelectedItem != null && dataBox.Text != "")
            {
                string a1 = dataBox.Text;
                if (System.Text.RegularExpressions.Regex.IsMatch(a1, "^[0-9.]+$"))
                {
                    object id2 = (RoliGrid.SelectedItem as DataRowView).Row[0];
                    adapter.UpdateQuery(dataBox.Text, Convert.ToInt32(combo2.Text), Convert.ToInt32(combo.Text), Convert.ToInt32(id2));
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
                dataBox.Text = Convert.ToString(selectedRow);
                object selectedRow2 = (RoliGrid.SelectedItem as DataRowView).Row[2];
                combo2.Text = Convert.ToString(selectedRow2);
                object selectedRow3 = (RoliGrid.SelectedItem as DataRowView).Row[3];
                combo.Text = Convert.ToString(selectedRow3);
            }
        }
    }
}
