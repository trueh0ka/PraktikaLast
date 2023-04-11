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
    public partial class istoria_pokupok : Window
    {
        Istoria_pokupokTableAdapter istoria = new Istoria_pokupokTableAdapter();
        PokypatelTableAdapter pokupatel = new PokypatelTableAdapter();
        SotrudnikTableAdapter sotrudnik = new SotrudnikTableAdapter();
        Tip_oplatiTableAdapter tip = new Tip_oplatiTableAdapter();
        TovarTableAdapter tovar = new TovarTableAdapter();
        public istoria_pokupok()
        {
            InitializeComponent();
            RoliGrid.ItemsSource = istoria.GetData();
            combo_pokupatel.ItemsSource = pokupatel.GetData();
            combo_pokupatel.DisplayMemberPath = "pokypatel_id";
            combo_sotdudnik.ItemsSource = sotrudnik.GetData();
            combo_sotdudnik.DisplayMemberPath = "sotrudnik_id";
            combo_tovar.ItemsSource = tovar.GetData();
            combo_tovar.DisplayMemberPath = "id_tovar";
            combo_tip.ItemsSource = tip.GetData();
            combo_tip.DisplayMemberPath = "oplati_id";
        }

        private void button_roli_Click(object sender, RoutedEventArgs e)
        {
            prodavec_pocupatel window1 = new prodavec_pocupatel();
            window1.Show();
            this.Hide();
        }

        private void Button_sotrudniki_Click(object sender, RoutedEventArgs e)
        {
            prodavec_tip_oplati window2 = new prodavec_tip_oplati();
            window2.Show();
            this.Hide();
        }

        private void RoliGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RoliGrid.SelectedItem != null)
            {
                object selectedRow = (RoliGrid.SelectedItem as DataRowView).Row[1];
                object selectedRow2 = (RoliGrid.SelectedItem as DataRowView).Row[5];
                object selectedRow3 = (RoliGrid.SelectedItem as DataRowView).Row[4];
                object selectedRow4 = (RoliGrid.SelectedItem as DataRowView).Row[7];
                object selectedRow5 = (RoliGrid.SelectedItem as DataRowView).Row[4];
                RolBox.Text = Convert.ToString(selectedRow);
                combo_tip.Text = Convert.ToString(selectedRow2);
                combo_sotdudnik.Text = Convert.ToString(selectedRow3);
                combo_tovar.Text = Convert.ToString(selectedRow4);
                combo_pokupatel.Text = Convert.ToString(selectedRow5);
            }
        }

        private void Button_dobavit_Click(object sender, RoutedEventArgs e)
        {
            if (RolBox.Text != "" && combo_tip.Text != "" && combo_pokupatel.Text != "" && combo_sotdudnik.Text != "" && combo_tovar.Text != "")
            {
                string a1 = RolBox.Text;
                if (System.Text.RegularExpressions.Regex.IsMatch(a1, "^[0-9]+$"))
                {
                    istoria.InsertQuery(Convert.ToInt32(RolBox.Text), Convert.ToDouble((combo_tovar.SelectedItem as DataRowView).Row[2]) * Convert.ToInt32(RolBox.Text), Convert.ToString(DateTime.Now), Convert.ToInt32((combo_pokupatel.SelectedItem as DataRowView).Row[0]), Convert.ToInt32((combo_tip.SelectedItem as DataRowView).Row[0]), Convert.ToInt32((combo_sotdudnik.SelectedItem as DataRowView).Row[0]), Convert.ToInt32((combo_tovar.SelectedItem as DataRowView).Row[0]));
                    RoliGrid.ItemsSource = istoria.GetData();
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
            if (RoliGrid.SelectedItem != null && RolBox.Text != "" && combo_tip.Text != "" && combo_pokupatel.Text != "" && combo_sotdudnik.Text != "" && combo_tovar.Text != "")
            {
                string a1 = RolBox.Text;
                if (System.Text.RegularExpressions.Regex.IsMatch(a1, "^[0-9]+$"))
                {
                    object id2 = (RoliGrid.SelectedItem as DataRowView).Row[0];
                    istoria.UpdateQuery(Convert.ToInt32(RolBox.Text), Convert.ToDouble((combo_tovar.SelectedItem as DataRowView).Row[2]) * Convert.ToInt32(RolBox.Text), Convert.ToString(DateTime.Now), Convert.ToInt32((combo_pokupatel.SelectedItem as DataRowView).Row[0]), Convert.ToInt32((combo_tip.SelectedItem as DataRowView).Row[0]), Convert.ToInt32((combo_sotdudnik.SelectedItem as DataRowView).Row[0]), Convert.ToInt32((combo_tovar.SelectedItem as DataRowView).Row[0]), Convert.ToInt32(id2));
                    RoliGrid.ItemsSource = istoria.GetData();
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
                istoria.DeleteQuery(Convert.ToInt32(id));
                RoliGrid.ItemsSource = istoria.GetData();
            }
        }
    }
}