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
    /// Логика взаимодействия для DeleteStudentPage.xaml
    /// </summary>
    public partial class DeleteStudentPage : Page
    {
        public DeleteStudentPage()
        {
            InitializeComponent();

            GroupCmb.SelectedValuePath = "Id";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.Group.ToList();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            GroupCmb.SelectedItem = null;
            StudentLv.ItemsSource = App.context.Student.ToList();
        }

        private void DeleteStudentBtn_Click(object sender, RoutedEventArgs e)
        {
            Student selectedStudent = StudentLv.SelectedItem as Student;
            MessageBoxResult messageBoxResult = MessageBox.Show("Удалить выбранного студента?", "Удалить", MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                App.context.Student.Remove(selectedStudent);
                MessageBox.Show("Студент удален");

            }

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.MainFrame.Navigate(new MenuPage());
        }

        private void GroupCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Group group = GroupCmb.SelectedItem as Group;
            if (GroupCmb.SelectedIndex == 0)
            {
                StudentLv.ItemsSource = App.context.Student.ToList();
            }
            else
            {
                StudentLv.ItemsSource = App.context.Student.Where(s => s.IdGroup == group.ID).ToList();
            }
        }

    }
}