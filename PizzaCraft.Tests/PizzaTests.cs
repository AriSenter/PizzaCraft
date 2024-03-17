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
            Image button = (Image)window.FindName("Цезарь");
            button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            Assert.AreEqual("img/соусы/соус цезарь.png", ((BitmapImage)window.PizzaSauce.Source).UriSource.ToString());
            Assert.AreEqual(30, window.Price);
        }

        [Test]
        public void TestSelectMayo()
        {
            Image button = (Image)window.FindName("Майонез");
            button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            Assert.AreEqual("img/соусы/майонез.png", ((BitmapImage)window.PizzaSauce.Source).UriSource.ToString());
            Assert.AreEqual(40, window.Price);
        }

        [Test]
        public void TestSelectKetchup()
        {
            Image button = (Image)window.FindName("Кетчуп");
            button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            Assert.AreEqual("img/соусы/кетчуп.png", ((BitmapImage)window.PizzaSauce.Source).UriSource.ToString());
            Assert.AreEqual(25, window.Price);
        }

        [Test]
        public void TestSelectMultipleOptions()
        {
            Image button1 = (Image)window.FindName("Моцарелла");
            Image button2 = (Image)window.FindName("Бекон");

            button1.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            button2.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            Assert.AreEqual("img/сыр/моцарелла.png", ((BitmapImage)window.PizzaCheese.Source).UriSource.ToString());
            Assert.AreEqual("img/колбаса/бекон.png", ((BitmapImage)window.PizzaMeat.Source).UriSource.ToString());
            Assert.AreEqual(150 + 300, window.Price);
        }

        [Test]
        public void TestCalculatePrice()
        {
            Image button1 = (Image)window.FindName("Огурчики");
            Image button2 = (Image)window.FindName("Маслины");

            button1.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            button2.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            window.CalculatePrice();

            Assert.AreEqual(550 + 540, window.TotalPrice.Content.ToString().Replace(" ", string.Empty).Replace("руб.", string.Empty));
        }
    }
}