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
    public partial class postavshik : Window
    {
        PostavshikiTableAdapter adapter = new PostavshikiTableAdapter();
        public postavshik()
        {
            InitializeComponent();
            RoliGrid.ItemsSource = adapter.GetData();
        }

        private void Button_importirovat_Click(object sender, RoutedEventArgs e)
        {
            List<Class1> forImport = converter1.DeserializeObject<List<Class1>>();
            foreach (var item in forImport)
            {
                adapter.InsertQuery(item.Name, item.Phone, item.mail);
            }
            RoliGrid.ItemsSource = null;
            RoliGrid.ItemsSource = adapter.GetData();
        }

        private void Button_dobavit_Click(object sender, RoutedEventArgs e)
        {
            if (nazvaniebox.Text != "" && phonebox.Text != "" && mailbox.Text != "")
            {
                string a1 = nazvaniebox.Text;
                string a2 = phonebox.Text;
                string a3 = mailbox.Text;
                if (System.Text.RegularExpressions.Regex.IsMatch(a1, "^[a-zA-Zа-яА-Я]+$") && (System.Text.RegularExpressions.Regex.IsMatch(a2, "^[0-9+]+$")) && (System.Text.RegularExpressions.Regex.IsMatch(a3, "^[a-zA-Z.@0-9]+$")))
                {
                    adapter.InsertQuery(nazvaniebox.Text, phonebox.Text, mailbox.Text);
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
            if (RoliGrid.SelectedItem != null && nazvaniebox.Text != "" && phonebox.Text != "" && mailbox.Text != "")
            {
                string a1 = nazvaniebox.Text;
                string a2 = phonebox.Text;
                string a3 = mailbox.Text;
                if (System.Text.RegularExpressions.Regex.IsMatch(a1, "^[a-zA-Zа-яА-Я]+$") && (System.Text.RegularExpressions.Regex.IsMatch(a2, "^[0-9+]+$")) && (System.Text.RegularExpressions.Regex.IsMatch(a3, "^[a-zA-Z.@0-9]+$")))
                {
                    object id2 = (RoliGrid.SelectedItem as DataRowView).Row[0];
                    adapter.UpdateQuery(nazvaniebox.Text, phonebox.Text, mailbox.Text, Convert.ToInt32(id2));
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
                nazvaniebox.Text = Convert.ToString(selectedRow);
                object selectedRow2 = (RoliGrid.SelectedItem as DataRowView).Row[2];
                phonebox.Text = Convert.ToString(selectedRow2);
                object selectedRow3 = (RoliGrid.SelectedItem as DataRowView).Row[3];
                mailbox.Text = Convert.ToString(selectedRow3);
            }
        }

        private void Button_sotrudniki_Click(object sender, RoutedEventArgs e)
        {
            postavshik2 window = new postavshik2();
            window.Show();
            this.Hide();
        }
    }
}