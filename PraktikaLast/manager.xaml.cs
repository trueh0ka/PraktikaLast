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
    public partial class user : Window
    {
        KategoriiTableAdapter adapter = new KategoriiTableAdapter();
        public user()
        {
            InitializeComponent();
            RoliGrid.ItemsSource = adapter.GetData();
        }

        private void Button_dobavit_Click(object sender, RoutedEventArgs e)
        {
            if (RolBox.Text != "" && RolBox2.Text != "")
            {
                string a1 = RolBox.Text;
                string a2 = RolBox2.Text;
                if (System.Text.RegularExpressions.Regex.IsMatch(a1, "^[а-яА-Я]+$") && (System.Text.RegularExpressions.Regex.IsMatch(a2, "^[а-яА-Я]+$")))
                {
                    adapter.InsertQuery(RolBox.Text, RolBox2.Text);
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
            if (RoliGrid.SelectedItem != null && RolBox.Text != "" && RolBox2.Text != "")
            {
                string a1 = RolBox.Text;
                string a2 = RolBox2.Text;
                if (System.Text.RegularExpressions.Regex.IsMatch(a1, "^[а-яА-Я]+$") && (System.Text.RegularExpressions.Regex.IsMatch(a2, "^[а-яА-Я]+$")))
                {
                    object id2 = (RoliGrid.SelectedItem as DataRowView).Row[0];
                    adapter.UpdateQuery(RolBox.Text, RolBox2.Text, Convert.ToInt32(id2));
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
                object selectedRow2 = (RoliGrid.SelectedItem as DataRowView).Row[2];
                RolBox2.Text = Convert.ToString(selectedRow2);
            }
        }

        private void Button_sotrudniki_Click(object sender, RoutedEventArgs e)
        {
            manager2 window = new manager2();
            window.Show();
            this.Hide();
        }   

        private void Button_importirovat_Click(object sender, RoutedEventArgs e)
        {
            List<Class2> forImport = converter1.DeserializeObject<List<Class2>>();
            foreach (var item in forImport)
            {
                adapter.InsertQuery(item.Name, item.Opisanie);
            }
            RoliGrid.ItemsSource = null;
            RoliGrid.ItemsSource = adapter.GetData();
        }
    }
}