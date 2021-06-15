using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFdemo
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void Normalbtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ServicePage());
            MessageBox.Show("Добро пожаловать");
        }

        private void adminbtn_Click(object sender, RoutedEventArgs e)
        {
            if (tbcode.Text == "0000")
            {
                Manager.MainFrame.Navigate(new ServicePage());
                MessageBox.Show("Добро пожаловать");
            }
            else
            {
                MessageBox.Show("Неверный пароль. Повторите попытку");
            }
        }
    }
}
