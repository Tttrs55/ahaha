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
    /// Логика взаимодействия для FirstWindow.xaml
    /// переход на следующую страницу
    /// </summary>
    public partial class FirstWindow : Window
    {
        public FirstWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Auth());
            Manager.MainFrame = MainFrame;
        }
    }
}
