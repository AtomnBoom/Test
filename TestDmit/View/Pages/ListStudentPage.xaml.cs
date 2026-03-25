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
    /// Логика взаимодействия для ListStudentPage.xaml
    /// </summary>
    public partial class ListStudentPage : Page
    {
        public ListStudentPage()
        {
            InitializeComponent();

            GroupCmb.SelectedValuePath = "Id";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.Group.ToList();

            StudentCmb.SelectedValuePath = "Id";
            StudentCmb.DisplayMemberPath = "Name";
            StudentCmb.ItemsSource = App.context.Student.ToList();

            ListStudentDg.ItemsSource = App.context.Journal.ToList();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.MainFrame.Navigate(new MenuPage());
        }

        private void StudentCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Student student = StudentCmb.SelectedItem as Student;
            if (StudentCmb.SelectedItem == null)
            {
                ListStudentDg.ItemsSource = App.context.Journal.ToList();
            }
            else
            {
                ListStudentDg.ItemsSource = App.context.Journal.Where(j => j.IdStudent == student.Id).ToList();
            }
        }

        private void GroupCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Group group = GroupCmb.SelectedItem as Group;
            if (GroupCmb.SelectedItem == null)
            {
                ListStudentDg.ItemsSource = App.context.Journal.ToList();
            }
            else
            {
                ListStudentDg.ItemsSource = App.context.Journal.Where(j => j.Student.IdGroup == group.ID).ToList();
            }
        }
    }
}