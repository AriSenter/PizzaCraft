using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.Remoting.Messaging;
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

namespace PizzaCraft
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PizzaBody.Source = new BitmapImage(new Uri("img/пицца.png", UriKind.Relative));
        }
        int Price = 0;
        private void Option_Click(object sender, RoutedEventArgs e)
        {
            string buttonName = (sender as Image).Name.ToString();

            switch (buttonName)
            {
                case "Цезарь":
                    PizzaSauce.Source = new BitmapImage(new Uri("img/соусы/соус цезарь.png", UriKind.Relative));
                    Price = 30;
                    CalculatePrice();
                    break;
                case "Майонез":
                    PizzaSauce.Source = new BitmapImage(new Uri("img/соусы/майонез.png", UriKind.Relative));
                    Price = 40;
                    CalculatePrice();
                    break;
                case "Кетчуп":
                    PizzaSauce.Source = new BitmapImage(new Uri("img/соусы/кетчуп.png", UriKind.Relative));
                    Price = 25;
                    CalculatePrice();
                    break;
                case "Моцарелла":
                    PizzaCheese.Source = new BitmapImage(new Uri("img/сыр/моцарелла.png", UriKind.Relative));
                    Price =150;
                    CalculatePrice();
                    break;
                case "Бекон":
                    PizzaMeat.Source = new BitmapImage(new Uri("img/колбаса/бекон.png", UriKind.Relative));
                    Price = 300;
                    CalculatePrice();
                    break;
                case "Салями":
                    PizzaMeat.Source = new BitmapImage(new Uri("img/колбаса/салями.png", UriKind.Relative));
                    Price = 350;
                    CalculatePrice();
                    break;
                case "Огурчики":
                    PizzaSpecie.Source = new BitmapImage(new Uri("img/другое/огурчики.png", UriKind.Relative));
                    Price = 550;
                    CalculatePrice();
                    break;
                case "Помидоры":
                    PizzaSpecie.Source = new BitmapImage(new Uri("img/другое/помидоры.png", UriKind.Relative));
                    Price = 535;
                    CalculatePrice();
                    break;
                case "Маслины":
                    PizzaSpecie.Source = new BitmapImage(new Uri("img/другое/маслины.png", UriKind.Relative));
                    Price = 540;
                    CalculatePrice();
                    break;
                case "Перец":
                    PizzaSpecie.Source = new BitmapImage(new Uri("img/другое/перец.png", UriKind.Relative));
                    Price = 560;
                    CalculatePrice();
                    break;
            }
        }
        private void CalculatePrice()
        {
            TotalPrice.Content = Price.ToString() + " руб.";
        }

        private void BuyPizza_Click(object sender, RoutedEventArgs e)
        {
            W_OrderSuccesful Wind = new W_OrderSuccesful(); Wind.Show(); Hide();
        }

        public MediaTypeNames.Image FindName(string v)
        {
            throw new NotImplementedException();
        }
    }
}
