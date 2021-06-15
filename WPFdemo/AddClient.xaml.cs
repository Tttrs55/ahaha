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
    /// Логика взаимодействия для AddClient.xaml
    /// </summary>
    public partial class AddClient : Page
    {
        private Client client = new Client();
        public AddClient(Client editClient)
        {
            InitializeComponent();
            if (client != null)
                client = editClient;
            DataContext = client;
            cbGender.ItemsSource = DB.GetGender();
        }

        private void btnok_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrEmpty(client.LastName))
                errors.AppendLine("Введите фамилию!");
            if (string.IsNullOrEmpty(client.FirstName))
                errors.AppendLine("Введите имя!");
            if (string.IsNullOrEmpty(client.Patronymic))
                errors.AppendLine("Введите Отчество!");
            if (Birth.SelectedDate == null)
                errors.AppendLine("Введите дату рождения!");
            if (Reg.SelectedDate == null)
                errors.AppendLine("Введите дату регистрации!");
            if (string.IsNullOrEmpty(client.Email))
                errors.AppendLine("Введите Email!");
            if (string.IsNullOrEmpty(client.Phone))
                errors.AppendLine("Введите телефон!");
            if (client.Gender==null)
                errors.AppendLine("Введите пол!");

            if (errors.Length>0)
            {
                MessageBox.Show(errors.ToString());
            }
            else
            {
                DB.AddClient(client);
                Manager.MainFrame.GoBack();
            }
        }
    }
}
