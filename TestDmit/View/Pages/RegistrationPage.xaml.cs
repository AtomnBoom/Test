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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();

            GroupCb.SelectedValuePath = "ID";
            GroupCb.DisplayMemberPath = "Name";
            GroupCb.ItemsSource = App.context.Group.ToList();
            GroupCb.SelectedIndex = 0;


            StudentCb.SelectedValuePath = "ID";
            StudentCb.DisplayMemberPath = "Name";
            StudentCb.SelectedIndex = 0;

            TestCb.SelectedValuePath = "ID";
            TestCb.DisplayMemberPath = "Name";
            TestCb.ItemsSource = App.context.Test.ToList();
            TestCb.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(GroupCb.Text) && string.IsNullOrEmpty(StudentCb.Text) && string.IsNullOrEmpty(TestCb.Text))
            {
                MessageBox.Show("Заполните все поля");
            }
            else if (TestCb.Text == "Общие основы функционирования субъектов хозяйствования")
            {
                ClassFrame.MainFrame.Navigate(new Test1Page());
            }
            else if (TestCb.Text == "Сущность и структура основного капитала и оборотных средств предприятия")
            {
                ClassFrame.MainFrame.Navigate(new Test2Page());
            }

            ClassVariable.classman = Convert.ToInt32(GroupCb.SelectedValue);
        }

        private void GroupCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedGroup = Convert.ToInt32(GroupCb.SelectedValue);
            StudentCb.ItemsSource = App.context.Student.Where(s => s.IdGroup == selectedGroup).ToList();
            StudentCb.SelectedIndex = 0;
        }
    }
}
