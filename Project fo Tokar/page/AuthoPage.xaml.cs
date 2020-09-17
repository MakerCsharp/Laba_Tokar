using Project_fo_Tokar.database;
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

namespace Project_fo_Tokar.page
{
    /// <summary>
    /// Логика взаимодействия для AuthoPage.xaml
    /// </summary>
    public partial class AuthoPage : Page
    {
        public AuthoPage()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Auth(TextBoxLogin.Text, PasswordBox.Password);
        }

        private bool   Auth(string login, string password) {
            if(string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль");
                return false;
            }
          
            using (var db = new Entities())
            {
                var Логины_клиентов = db.Логины_клиентов.AsNoTracking().FirstOrDefault
                (u => u.Login == TextBoxLogin.Text && u.Password == PasswordBox.Password);

                if (Логины_клиентов == null)
                {
                    MessageBox.Show("Пользователя с такими данными не существует ");
                    return false;
                }
                switch (Логины_клиентов.id)
                {
                    case 1:
                        NavigationService?.Navigate(new Menu());
                        break;
                    case 2:
                        NavigationService?.Navigate(new Menu());
                        break;
                }
                return true;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Page2());
        }

       
    }
}
