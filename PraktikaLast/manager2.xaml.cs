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
    public partial class manager2 : Window
    {
        TovarTableAdapter adapter = new TovarTableAdapter();
        KategoriiTableAdapter adapter2 = new KategoriiTableAdapter();
        public manager2()
        {
            InitializeComponent();
            RoliGrid.ItemsSource = adapter.GetData();
            combo.ItemsSource = adapter2.GetData();
            combo.DisplayMemberPath = "kategorii_id";
        }

        private void Button_dobavit_Click(object sender, RoutedEventArgs e)
        {
            if (nazvaniebox.Text != "" && stoimostbox.Text != "" && kolichestvobox.Text != "" && combo.Text != "")
            {
                string a1 = nazvaniebox.Text;
                string a2 = stoimostbox.Text;
                string a3 = kolichestvobox.Text;
                if (System.Text.RegularExpressions.Regex.IsMatch(a1, "^[а-яА-Я]+$") && (System.Text.RegularExpressions.Regex.IsMatch(a2, "^[0-9,]+$")) && (System.Text.RegularExpressions.Regex.IsMatch(a3, "^[0-9]+$")))
                {
                    adapter.InsertQuery(nazvaniebox.Text, Convert.ToDouble(stoimostbox.Text), Convert.ToInt32(kolichestvobox.Text), Convert.ToInt32((combo.SelectedItem as DataRowView).Row[0]));
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
            if (RoliGrid.SelectedItem != null && nazvaniebox.Text != "" && stoimostbox.Text != "" && kolichestvobox.Text != "" && combo.Text != "")
            {
                string a1 = nazvaniebox.Text;
                string a2 = stoimostbox.Text;
                string a3 = kolichestvobox.Text;
                if (System.Text.RegularExpressions.Regex.IsMatch(a1, "^[а-яА-Я]+$") && (System.Text.RegularExpressions.Regex.IsMatch(a2, "^[0-9,]+$")) && (System.Text.RegularExpressions.Regex.IsMatch(a3, "^[0-9]+$")))
                {
                    object id2 = (RoliGrid.SelectedItem as DataRowView).Row[0];
                    adapter.UpdateQuery(nazvaniebox.Text, Convert.ToDouble(stoimostbox.Text), Convert.ToInt32(kolichestvobox.Text), Convert.ToInt32((combo.SelectedItem as DataRowView).Row[0]), Convert.ToInt32(id2));
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

        private void button_roli_Click(object sender, RoutedEventArgs e)
        {
            user window = new user();
            window.Show();
            this.Hide();
        }

        private void RoliGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RoliGrid.SelectedItem != null)
            {
                object selectedRow = (RoliGrid.SelectedItem as DataRowView).Row[1];
                object selectedRow2 = (RoliGrid.SelectedItem as DataRowView).Row[2];
                object selectedRow3 = (RoliGrid.SelectedItem as DataRowView).Row[3];
                object selectedRow4 = (RoliGrid.SelectedItem as DataRowView).Row[4];
                nazvaniebox.Text = Convert.ToString(selectedRow);
                stoimostbox.Text = Convert.ToString(selectedRow2);
                kolichestvobox.Text = Convert.ToString(selectedRow3);
                combo.Text = Convert.ToString(selectedRow4);
            }
        }
    }
}