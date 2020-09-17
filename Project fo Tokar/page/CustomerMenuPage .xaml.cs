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
    /// Логика взаимодействия для CustomerMenuPage.xaml
    /// </summary>
    public partial class CustomerMenuPage : Page
    {
        public CustomerMenuPage()
        {
            InitializeComponent();
        }

    //    private void Button_Click(object sender, RoutedEventArgs e)
    //    {
    //
    //    }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Page2());
        }

        
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AuthoPage());
        }

        private void Button_Clikc_3(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Menu());
        }
    }
}
