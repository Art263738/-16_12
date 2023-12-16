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

namespace Задания_Эл.управления
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Создание нового элемента для добавления в список
            string newItem = "Новый элемент";

            // Добавление элемента в ListBox
            listBox.Items.Add(newItem);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(tb1.Text) || string.IsNullOrEmpty(tb2.Text))
            {
                MessageBox.Show("Обязательно нужно ввести числа!");
            }
            else
            {
                int num1 = int.Parse(tb1.Text);
                int num2 = int.Parse(tb2.Text);

                //суммируем числа
                int summa = num1 + num2;

                //вывод результата в лайбеле
                lb_rezultat.Content = ($"Результат сложения \n {num1} + {num2} = {summa}");
            }
           
        }
    }
}
