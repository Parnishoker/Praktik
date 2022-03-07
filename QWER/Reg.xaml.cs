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
    public partial class Reg : Window
    {
        public Reg()
        {
            InitializeComponent();
        }

        QQEntities bd = new QQEntities();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();
        }

        bool check()
        {
            foreach (var item in bd.login)
            {
                if (item.login1 == login.Text)
                {
                    MessageBox.Show("Такой пользователь уже существует");
                    return false;
                }
            }
            return true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (login.Text != "" && Pass.Text != "")
            {
                if (check())
                {
                    login lg = new login();
                    lg.login1 = login.Text;
                    lg.pass = Pass.Text;
                    lg.role = Role.Text;
                    bd.login.Add(lg);
                    bd.SaveChanges();
                    MessageBox.Show("Учётная запись пользователя была создана");
                    Window1 w = new Window1(login.Text);
                    this.Close();
                    w.Show();
                }
            }
        }

        private void Role_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
