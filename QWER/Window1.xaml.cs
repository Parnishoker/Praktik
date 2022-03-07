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
    public partial class Window1 : Window
    {

        QQEntities bd = new QQEntities();

        public Window1(string login)
        {
            InitializeComponent();
            Login.Content = login;
            foreach (var item in bd.login)
            {
                if (item.login1 == login)
                {
                    Role.Content = item.role;
                    break;

                }
            }
        }
    }
}
