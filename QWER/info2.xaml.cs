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
    /// Логика взаимодействия для info2.xaml
    /// </summary>
    public partial class info2 : Window
    {
        public info2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 wind2 = new Window2();
            this.Close();
            wind2.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window6 wind6 = new Window6();
            this.Close();
            wind6.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window6 wind6 = new Window6();
            this.Close();
            wind6.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            QQEntities db = new QQEntities();
            login apt = new login();
            foreach (var info in db.login)
            {
                apt = info;
                break;
            }
            apt.login1 = text3.Text;
            MessageBox.Show("Изменения применины!", "Успех");
            db.SaveChanges();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            QQEntities db = new QQEntities();
            login apt = new login();
            foreach (var info in db.login)
            {
                apt = info;
                break;
            }
            apt.login1 = text4.Text;
            MessageBox.Show("Изменения применины!", "Успех");
            db.SaveChanges();
        }
    }
}
