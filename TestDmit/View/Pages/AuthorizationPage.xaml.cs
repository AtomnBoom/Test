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
using TestDmit.Class;

namespace TestDmit.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string pass = "123";
             if(PassB.Password == null)
            {
                MessageBox.Show("Введите пароль!");
            }
            else if (PassB.Password == pass)
            {
                ClassFrame.MainFrame.Navigate(new MenuPage());
            }
            else
            {
                MessageBox.Show("Пароль не верный!");
            }
        }
    }
}
