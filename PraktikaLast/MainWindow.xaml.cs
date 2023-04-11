using System;
using System.Collections.Generic;
using System.IO.Packaging;
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
    public partial class MainWindow : Window
    {
        DannieTableAdapter adapter = new DannieTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var allLogins = adapter.GetData().Rows;

            int a = 0;
            string a1 = login.Text;
            string a2 = password.Password;
            if (login.Text != "" && password.Password != "")
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(a1, "^[a-zA-Za0-9]+$") &&
                    System.Text.RegularExpressions.Regex.IsMatch(a2, "^[a-zA-Za0-9]+$"))
                {
                    for (int i = 0; i < allLogins.Count; i++)
                    {
                        if (allLogins[i][1].ToString() == login.Text &&
                            allLogins[i][2].ToString() == password.Password)
                        {
                            a = 1;
                            int roleID = (int)allLogins[i][3];                   
                            switch (roleID)
                            {
                                case 1:
                                    admin window1 = new admin();
                                    window1.Show();
                                    this.Hide();
                                    break;
                                case 4:
                                    prodavec_pocupatel window4 = new prodavec_pocupatel();
                                    window4.Show();
                                    this.Hide();
                                    break;
                                case 2:
                                    user window2 = new user();
                                    window2.Show();
                                    this.Hide();
                                    break;
                                case 3:
                                    postavshik window3 = new postavshik();
                                    window3.Show();
                                    this.Hide();
                                    break;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Лишние символы!");
                }
            }
            else
            {
                MessageBox.Show("Пустые поля!");
            }
            if (a == 0)
            {
                MessageBox.Show("Авторизация не пройдена.");
            }
        }
    }
}