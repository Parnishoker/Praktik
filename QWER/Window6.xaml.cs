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
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
          

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 wind2 = new Window2();
            this.Close();
            wind2.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Поздравляю с покупкой!");
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
           
        }
    }
}
