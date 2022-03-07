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
using System.Windows.Shapes;

namespace QWER
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            info3 infq = new info3();
            this.Close();
            infq.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            info1 inf = new info1();
            this.Close();
            inf.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            info2 infw = new info2();
            this.Close();
            infw.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MainWindow wind = new MainWindow();
            this.Close();
            wind.Show();
        }
    }
}
