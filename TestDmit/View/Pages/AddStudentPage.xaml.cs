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
using TestDmit.Model;

namespace TestDmit.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddStudentPage.xaml
    /// </summary>
    public partial class AddStudentPage : Page
    {
        public AddStudentPage()
        {
            InitializeComponent();

            GroupCb.SelectedValuePath = "ID";
            GroupCb.DisplayMemberPath = "Name";
            GroupCb.ItemsSource = App.context.Group.ToList();
            GroupCb.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(NameTb.Text) && string.IsNullOrEmpty(GroupCb.Text))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                Student newStudent = new Student()
                {
                    Name = NameTb.Text,
                    Group = GroupCb.SelectedItem as Group
                };

                App.context.Student.Add(newStudent);
                App.context.SaveChanges();
                MessageBox.Show("Студент добавлен");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ClassFrame.MainFrame.Navigate(new MenuPage());
        }
    }
}
