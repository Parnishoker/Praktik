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

namespace QWER
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

        QQEntities bd = new QQEntities();

        bool check()
        {
            foreach (var item in bd.login)
            {
                if (login.Text == item.login1 && Pass.Text == item.pass)
                    return true;
            }
            MessageBox.Show("Неверный логин или пароль");
            return false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (login.Text != "" && Pass.Text != "")
            {
                if (check())
                {
                    Window2 win = new Window2();
                    win.Show();
                    this.Close();
                }
                MessageBox.Show("Потльзователь успешно вошёл");
            }
            else
                MessageBox.Show("Введите данные!!");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Reg reg = new Reg();
            this.Close();
            reg.Show();
        }
    }
}
