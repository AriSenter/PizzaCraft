using static System.Net.Mime.MediaTypeNames;

namespace PizzaCraft.Tests
{
    [TestFixture]
    public class MainWindowTests
    {
        private MainWindow window;

        [SetUp]
        public void Setup()
        {
            window = new MainWindow();
        }

        [Test]
        public void TestSelectCeasar()
        {
            Image button = (Image)window.FindName("������");
            button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            Assert.AreEqual("img/�����/���� ������.png", ((BitmapImage)window.PizzaSauce.Source).UriSource.ToString());
            Assert.AreEqual(30, window.Price);
        }

        [Test]
        public void TestSelectMayo()
        {
            Image button = (Image)window.FindName("�������");
            button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            Assert.AreEqual("img/�����/�������.png", ((BitmapImage)window.PizzaSauce.Source).UriSource.ToString());
            Assert.AreEqual(40, window.Price);
        }

        [Test]
        public void TestSelectKetchup()
        {
            Image button = (Image)window.FindName("������");
            button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            Assert.AreEqual("img/�����/������.png", ((BitmapImage)window.PizzaSauce.Source).UriSource.ToString());
            Assert.AreEqual(25, window.Price);
        }

        [Test]
        public void TestSelectMultipleOptions()
        {
            Image button1 = (Image)window.FindName("���������");
            Image button2 = (Image)window.FindName("�����");

            button1.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            button2.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            Assert.AreEqual("img/���/���������.png", ((BitmapImage)window.PizzaCheese.Source).UriSource.ToString());
            Assert.AreEqual("img/�������/�����.png", ((BitmapImage)window.PizzaMeat.Source).UriSource.ToString());
            Assert.AreEqual(150 + 300, window.Price);
        }

        [Test]
        public void TestCalculatePrice()
        {
            Image button1 = (Image)window.FindName("��������");
            Image button2 = (Image)window.FindName("�������");

            button1.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            button2.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            window.CalculatePrice();

            Assert.AreEqual(550 + 540, window.TotalPrice.Content.ToString().Replace(" ", string.Empty).Replace("���.", string.Empty));
        }
    }
}