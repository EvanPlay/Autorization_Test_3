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

namespace Autorization_Test_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tbLog.MaxLength = 100;
            pbPas.MaxLength = 100;
        }

        private void bEnter_Click(object sender, RoutedEventArgs e)
        {
            if (tbLog.Text.Length > 0)
            {
                if (pbPas.Password.Length > 0)
                {
                    if (tbLog.Text == "Администратор" && pbPas.Password == "7epe-5h2M-93x4-JQGM-kmMZ-etYw-3WbS")
                    {
                        MessageBox.Show("Вход выполнен");
                        //tbMessage.Text = "Вход выполнен";
                    }    
                    else
                    {
                        tbMessage.Text = "Неверен логин или пароль";
                    }    
                }
                else
                {
                    tbMessage.Text = "Введите пароль";
                }
            }
            else
            {
                tbMessage.Text = "Введите логин";
            }
        }
    }
}
//Login - Администратор
//Password - 7epe-5h2M-93x4-JQGM-kmMZ-etYw-3WbS (Password generator)
