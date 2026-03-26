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
    /// Логика взаимодействия для Test2Page.xaml
    /// </summary>
    public partial class Test2Page : Page
    {
        int b = 0;
        int c = 0;
        public Test2Page()
        {
            InitializeComponent();
        }
        private void AnswerBtn_Click(object sender, RoutedEventArgs e)
        {
            if (RB.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
                ProductsTc.SelectedItem = v2;
            }
            else
            {
                MessageBox.Show("Неправильно");
                AnswerBtn.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v2;
            }
        }

        private void Answer2Btn_Click(object sender, RoutedEventArgs e)
        {
            if (RB2.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
                ProductsTc.SelectedItem = v3;
            }
            else
            {
                MessageBox.Show("Неправильно");
                Answer2Btn.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v3;
            }
        }

        private void Answer3Btn_Click_1(object sender, RoutedEventArgs e)
        {
            if (RB3.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
                ProductsTc.SelectedItem = v4;
            }
            else
            {
                MessageBox.Show("Неправильно");
                Answer3Btn.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v4;
            }
        }

        private void Answer4Btn_Click(object sender, RoutedEventArgs e)
        {
            if (RB4.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
                ProductsTc.SelectedItem = v5;
            }
            else
            {
                MessageBox.Show("Неправильно");
                Answer4Btn.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v5;
            }
        }

        private void Answer5Btn_Click(object sender, RoutedEventArgs e)
        {
            if (RB5.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
                ProductsTc.SelectedItem = result;
            }
            else
            {
                MessageBox.Show("Неправильно");
                Answer5Btn.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = result;
            }

        }

        private void ResultBtn_Click(object sender, RoutedEventArgs e)
        {
            AnswerTbl.Text = Convert.ToString(b);
            if (b >= 2)
            {
                c = b;
            }
            else if (b == 1) { c = 2; }

                MarkTbl.Text = Convert.ToString(c);
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            Journal journal = new Journal()
            {
                DateTest = DateTime.Now,
                Mark = c,
                IdStudent = ClassVariable.classman,
                IdTest = 1
            };

            App.context.Journal.Add(journal);

            ClassFrame.MainFrame.Navigate(new RegistrationPage());
        }
    }
}