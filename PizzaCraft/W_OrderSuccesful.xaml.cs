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

namespace PizzaCraft
{
    /// <summary>
    /// Логика взаимодействия для W_OrderSuccesful.xaml
    /// </summary>
    public partial class W_OrderSuccesful : Window
    {
        public W_OrderSuccesful()
        {
            InitializeComponent();
        }

        private void BackToMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Wind = new MainWindow(); Wind.Show(); Hide();
        }
    }
}
