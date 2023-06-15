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

namespace WpfApp2
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

        private void cmCalc(object sender, RoutedEventArgs e)
        {
            long N;
            if (!long.TryParse(tbNumber.Text, out N)) 
            {
                MessageBox.Show("Не число!");
                return;
            }
            if ((N<0)||(N>20))
            { 
                MessageBox.Show("Плохое число!");
                return;
            }

            long R = 1;
            for (long i = 2; i<=N; i++) 
            {
                R *= i;
            }
            MessageBox.Show($"Факториал = {R.ToString()}");
        }

        private void cmClose(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
