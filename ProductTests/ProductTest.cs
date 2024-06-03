using EcommAssignment;

namespace ProductTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckProductID1()
        {
            var product = new Product(1, "Silver", 10.0m, 100);
            Assert.That(product.productId, Is.EqualTo(1));
        }

        [Test]
        public void CheckProductID2()
        {
            var product = new Product(2, "Silver", 10.0m, 100);
            Assert.That(product.productId, Is.EqualTo(2));
        }

        [Test]
        public void CheckProductID3()
        {
            var product = new Product(3, "Silver", 10.0m, 100);
            Assert.That(product.productId, Is.EqualTo(3));
        }

        [Test]
        public void CheckProductName1()
        {
            var product = new Product(1, "Platinum", 20.0m, 200);
            Assert.That(product.productName, Is.EqualTo("Platinum"));
        }

        [Test]
        public void CheckProductName2()
        {
            var product = new Product(2, "Gold", 20.0m, 200);
            Assert.That(product.productName, Is.EqualTo("Gold"));
        }

        [Test]
        public void CheckProductName3()
        {
            var product = new Product(3, "Silver", 20.0m, 200);
            Assert.That(product.productName, Is.EqualTo("Silver"));
        }

        [Test]
        public void CheckPrice1()
        {
            var product = new Product(1, "Diamond", 10.0m, 300);
            Assert.That(product.price, Is.EqualTo(10.0m));
        }

        [Test]
        public void CheckPrice2()
        {
            var product = new Product(2, "Diamond", 20.0m, 300);
            Assert.That(product.price, Is.EqualTo(20.0m));
        }

        [Test]
        public void CheckPrice3()
        {
            var product = new Product(3, "Diamond", 30.0m, 300);
            Assert.That(product.price, Is.EqualTo(30.0m));
        }

        [Test]
        public void CheckStock1()
        {
            var product = new Product(1, "Diamond", 40.0m, 100);
            Assert.That(product.stock, Is.EqualTo(100));
        }

        [Test]
        public void CheckStock2()
        {
            var product = new Product(2, "Diamond", 40.0m, 200);
            Assert.That(product.stock, Is.EqualTo(200));
        }

        [Test]
        public void CheckStock3()
        {
            var product = new Product(3, "Diamond", 40.0m, 300);
            Assert.That(product.stock, Is.EqualTo(300));
        }

        [Test]
        public void IncreaseStock1()
        {
            var product = new Product(1, "Chocolate", 10.0m, 100);
            product.IncreaseStock(10);
            Assert.That(product.stock, Is.EqualTo(110));
        }

        [Test]
        public void IncreaseStock2()
        {
            var product = new Product(2, "Chocolate", 10.0m, 100);
            product.IncreaseStock(20);
            Assert.That(product.stock, Is.EqualTo(120));
        }

        [Test]
        public void IncreaseStock3()
        {
            var product = new Product(3, "Chocolate", 10.0m, 100);
            product.IncreaseStock(30);
            Assert.That(product.stock, Is.EqualTo(130));
        }

        [Test]
        public void DecreaseStock1()
        {
            var product = new Product(1, "Gold", 10.0m, 100);
            product.DecreaseStock(10);
            Assert.That(product.stock, Is.EqualTo(90));
        }

        [Test]
        public void DecreaseStock2()
        {
            var product = new Product(2, "Gold", 10.0m, 100);
            product.DecreaseStock(20);
            Assert.That(product.stock, Is.EqualTo(80));
        }

        [Test]
        public void DecreaseStock3()
        {
            var product = new Product(3, "Gold", 10.0m, 100);
            product.DecreaseStock(30);
            Assert.That(product.stock, Is.EqualTo(70));
        }
    }
}