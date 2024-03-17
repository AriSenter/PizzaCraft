using static System.Net.Mime.MediaTypeNames;

namespace TestPizza
{
    public class Tests
    {
        [TestMethod]
        public void TestPizzaSauce()
        {
            // Arrange
            MainWindow window = new MainWindow();
            Image sauceButton = (Image)window.FindName("������");

            // Act
            sauceButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            // Assert
            BitmapImage sauceImage = (BitmapImage)window.PizzaSauce.Source;
            Assert.AreEqual("img/�����/���� ������.png", sauceImage.UriSource.LocalPath);
        }

        [TestMethod]
        public void TestPizzaCheese()
        {
            // Arrange
            MainWindow window = new MainWindow();
            Image cheeseButton = (Image)window.FindName("���������");

            // Act
            cheeseButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            // Assert
            BitmapImage cheeseImage = (BitmapImage)window.PizzaCheese.Source;
            Assert.AreEqual("img/���/���������.png", cheeseImage.UriSource.LocalPath);
        }

        [TestMethod]
        public void TestPizzaMeat()
        {
            // Arrange
            MainWindow window = new MainWindow();
            Image meatButton = (Image)window.FindName("�����");

            // Act
            meatButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            // Assert
            BitmapImage meatImage = (BitmapImage)window.PizzaMeat.Source;
            Assert.AreEqual("img/�������/�����.png", meatImage.UriSource.LocalPath);
        }

        [TestMethod]
        public void TestCalculatePrice()
        {
            // Arrange
            MainWindow window = new MainWindow();
            int expectedPrice = 30;

            // Act
            Image sauceButton = (Image)window.FindName("������");
            sauceButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            // Assert
            string totalPriceText = (string)window.TotalPrice.Content;
            int totalPrice = int.Parse(totalPriceText.Replace(" ���.", ""));
            Assert.AreEqual(expectedPrice, totalPrice);
        }

        [TestMethod]
        public void TestBuyPizza()
        {
            // Arrange
            MainWindow window = new MainWindow();
            W_OrderSuccesful wind = new W_OrderSuccesful();

            // Act
            Image sauceButton = (Image)window.FindName("������");
            sauceButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            Button buyButton = (Button)window.FindName("BuyPizza");
            buyButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            // Assert
            Assert.IsTrue(wind.IsVisible);
            Assert.IsFalse(window.IsVisible);
        }
    }
}