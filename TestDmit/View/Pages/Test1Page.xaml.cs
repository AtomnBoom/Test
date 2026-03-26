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
    /// Логика взаимодействия для Test1Page.xaml
    /// </summary>
    public partial class Test1Page : Page
    {
        int b = 0;
        int c = 0;
        public Test1Page()
        {
            InitializeComponent();
        }
        private void AnswerBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AnswerTb.Text == "5")
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

        private void Answer3Btn_Click(object sender, RoutedEventArgs e)
        {
            if (VCb1.IsChecked == false && VCb2.IsChecked == false && VCb3.IsChecked == false && VCb4.IsChecked == false && VCb5.IsChecked == true)
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

        private void Answer6Btn_Click(object sender, RoutedEventArgs e)
        {
            if (RB6.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
                ProductsTc.SelectedItem = v7;
            }
            else
            {
                MessageBox.Show("Неправильно");
                Answer6Btn.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v7;
            }
        }

        private void Answer5Btn_Click(object sender, RoutedEventArgs e)
        {
            if (RB5.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
                ProductsTc.SelectedItem = v6;
            }
            else
            {
                MessageBox.Show("Неправильно");
                Answer5Btn.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v6;
            }
        }

        private void Answer7Btn_Click(object sender, RoutedEventArgs e)
        {
            if (RB7.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
                ProductsTc.SelectedItem = v8;
            }
            else
            {
                MessageBox.Show("Неправильно");
                Answer7Btn.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v8;
            }
        }

        private void Answer8Btn_Click(object sender, RoutedEventArgs e)
        {
            if (RB8.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
                ProductsTc.SelectedItem = v9;
            }
            else
            {
                MessageBox.Show("Неправильно");
                Answer8Btn.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v9;
            }
        }

        private void Answer9Btn_Click(object sender, RoutedEventArgs e)
        {
            if (RB9.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
                ProductsTc.SelectedItem = v10;
            }
            else
            {
                MessageBox.Show("Неправильно");
                Answer9Btn.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v10;
            }
        }

        private void Answer10Btn_Click(object sender, RoutedEventArgs e)
        {
            if (RB10.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
                ProductsTc.SelectedItem = v11;
            }
            else
            {
                MessageBox.Show("Неправильно");
                Answer10Btn.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v11;
            }
        }

        private void Answer11Btn_Click(object sender, RoutedEventArgs e)
        {
            if (RB11.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
                ProductsTc.SelectedItem = v12;
            }
            else
            {
                MessageBox.Show("Неправильно");
                Answer11Btn.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v12;
            }
        }

        private void Answer12Btn_Click(object sender, RoutedEventArgs e)
        {
            if (RB12.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
                ProductsTc.SelectedItem = v13;
            }
            else
            {
                MessageBox.Show("Неправильно");
                Answer12Btn.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v13;
            }
        }

        private void Answer13Btn_Click(object sender, RoutedEventArgs e)
        {
            if (RB13.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
                ProductsTc.SelectedItem = v14;
            }
            else
            {
                MessageBox.Show("Неправильно");
                Answer13Btn.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v14;
            }
        }

        private void Answer14Btn_Click(object sender, RoutedEventArgs e)
        {
            if (RB14.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
                ProductsTc.SelectedItem = v15;
            }
            else
            {
                MessageBox.Show("Неправильно");
                Answer14Btn.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v15;
            }
        }

        private void Answer15Btn_Click_1(object sender, RoutedEventArgs e)
        {
            if (Answer15Tb.Text == "4")
            {
                MessageBox.Show("Правильно");
                b = b + 1;
                ProductsTc.SelectedItem = v16;
            }
            else
            {
                MessageBox.Show("Неправильно");
                Answer15Btn.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v16;
            }
        }

        private void Answer16Btn_Click(object sender, RoutedEventArgs e)
        {
            if (RB16.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
                ProductsTc.SelectedItem = v17;
            }
            else
            {
                MessageBox.Show("Неправильно");
                Answer16Btn.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v17;
            }
        }

        private void Answer17Btn_Click(object sender, RoutedEventArgs e)
        {
            if (RB17.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
                ProductsTc.SelectedItem = v18;
            }
            else
            {
                MessageBox.Show("Неправильно");
                Answer17Btn.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v18;
            }
        }

        private void Answer18Btn_Click(object sender, RoutedEventArgs e)
        {
            if (RB18.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
                ProductsTc.SelectedItem = v19;
            }
            else
            {
                MessageBox.Show("Неправильно");
                Answer18Btn.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v19;
            }
        }

        private void Answer19Btn_Click(object sender, RoutedEventArgs e)
        {
            if (RB19.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
                ProductsTc.SelectedItem = v20;
            }
            else
            {
                MessageBox.Show("Неправильно");
                Answer19Btn.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v20;
            }
        }

        private void Answer20Btn_Click(object sender, RoutedEventArgs e)
        {
            if (RB20.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
                ProductsTc.SelectedItem = v21;
            }
            else
            {
                MessageBox.Show("Неправильно");
                Answer20Btn.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = v21;
            }
        }

        private void Answer21Btn_Click(object sender, RoutedEventArgs e)
        {
            if (RB21.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b = b + 1;
                ProductsTc.SelectedItem = result;
            }
            else
            {
                MessageBox.Show("Неправильно");
                Answer21Btn.Visibility = Visibility.Collapsed;
                ProductsTc.SelectedItem = result;
            }
        }

        private void ResultBtn_Click(object sender, RoutedEventArgs e)
        {
            AnswerTbl.Text = Convert.ToString(b);

            if (b >= 20) c = 5;
            if (b > 11 && b < 20) c = 4;
            if (b > 5 && b < 12) c = 3;
            if (b < 6 && b > 0) c = 2;
            if (b == 0) c = 1;

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