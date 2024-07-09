using Newtonsoft.Json;
using NUnit.Framework.Internal;
using Dev.Pro.Tasks;
using Dev.Pro.Helpers;

namespace taskTests
{
    public class ProductsSortScenarios
    {
        private Sorter _sort;
        private String _xmlProducts;

        [SetUp]
        public void SetUp()
        {
            _sort = new Sorter();
            _xmlProducts = "[{'name': 'Product A', 'price': 100, 'stock': 5}, {'name': 'Product B', 'price': 200, 'stock': 3}, {'name': 'Product C', 'price': 50, 'stock': 10}]";
        }

        [Test]
        public void xmln_Should_Be_SortedByPriceAsc()
        {
            string sortKey = "price";
            bool ascending = true;
            List<Products> productsBeforeSort = JsonConvert.DeserializeObject<List<Products>>(_xmlProducts);
            List<Products> productsAfterSort = _sort.SortProducts(productsBeforeSort, sortKey, ascending);
           
            Assert.That(productsBeforeSort[0].Name.Equals(productsAfterSort[1].Name), 
                String.Format("products were not sorted correctly with name actual: {0}, found after sort: {1}", productsBeforeSort[0].Name, productsAfterSort[1].Name));
            Assert.That(productsBeforeSort[0].Price.Equals(productsAfterSort[1].Price), 
                String.Format("products were not sorted correctly with price actual: {0}, found after sort: {1}", productsBeforeSort[0].Price, productsAfterSort[1].Price));
            Assert.That(productsBeforeSort[0].Stock.Equals(productsAfterSort[1].Stock), 
                String.Format("products were not sorted correctly with stock actual: {0}, found after sort: {1}", productsBeforeSort[0].Stock, productsAfterSort[1].Stock));
        }

        [Test]
        public void xmln_Should_Be_SortedByPriceDesc()
        {
            string sortKey = "price";
            bool ascending = false;
            
            List<Products> productsBeforeSort = JsonConvert.DeserializeObject<List<Products>>(_xmlProducts);
            List<Products> productsAfterSort = _sort.SortProducts(productsBeforeSort, sortKey, ascending);

            Assert.That(productsBeforeSort[0].Name.Equals(productsAfterSort[1].Name),
                String.Format("products were not sorted correctly with name actual: {0}, found after sort: {1}", productsBeforeSort[0].Name, productsAfterSort[1].Name));
            Assert.That(productsBeforeSort[0].Price.Equals(productsAfterSort[1].Price),
                String.Format("products were not sorted correctly with price actual: {0}, found after sort: {1}", productsBeforeSort[0].Price, productsAfterSort[1].Price));
            Assert.That(productsBeforeSort[0].Stock.Equals(productsAfterSort[1].Stock),
                String.Format("products were not sorted correctly with stock actual: {0}, found after sort: {1}", productsBeforeSort[0].Stock, productsAfterSort[1].Stock));
        }

        [Test]
        public void xmln_Should_Be_SortedByNameAsc()
        {
            string sortKey = "Name";
            bool ascending = true;
            List<Products> productsBeforeSort = JsonConvert.DeserializeObject<List<Products>>(_xmlProducts);
            List<Products> productsAfterSort = _sort.SortProducts(productsBeforeSort, sortKey, ascending);

            Assert.That(productsBeforeSort[0].Name.Equals(productsAfterSort[0].Name),
                String.Format("products were not sorted correctly with name actual: {0}, found after sort: {1}", productsBeforeSort[0].Name, productsAfterSort[0].Name));
            Assert.That(productsBeforeSort[0].Price.Equals(productsAfterSort[0].Price),
                String.Format("products were not sorted correctly with price actual: {0}, found after sort: {1}", productsBeforeSort[0].Price, productsAfterSort[0].Price));
            Assert.That(productsBeforeSort[0].Stock.Equals(productsAfterSort[0].Stock),
                String.Format("products were not sorted correctly with stock actual: {0}, found after sort: {1}", productsBeforeSort[0].Stock, productsAfterSort[0].Stock));
        }

        [Test]
        public void xmln_Should_Be_SortedByNameDesc()
        {
            string sortKey = "Name";
            bool ascending = false;
            List<Products> productsBeforeSort = JsonConvert.DeserializeObject<List<Products>>(_xmlProducts);
            List<Products> productsAfterSort = _sort.SortProducts(productsBeforeSort, sortKey, ascending);

            Assert.That(productsBeforeSort[0].Name.Equals(productsAfterSort[2].Name),
                String.Format("products were not sorted correctly with name actual: {0}, found after sort: {0}", productsBeforeSort[0].Name, productsAfterSort[0].Name));
            Assert.That(productsBeforeSort[0].Price.Equals(productsAfterSort[2].Price),
                String.Format("products were not sorted correctly with price actual: {0}, found after sort: {0}", productsBeforeSort[0].Price, productsAfterSort[0].Price));
            Assert.That(productsBeforeSort[0].Stock.Equals(productsAfterSort[2].Stock),
                String.Format("products were not sorted correctly with stock actual: {0}, found after sort: {0}", productsBeforeSort[0].Stock, productsAfterSort[0].Stock));
        }

        [Test]
        public void xmln_Should_Be_SortedByStockAsc()
        {
            string sortKey = "Stock";
            bool ascending = true;
            List<Products> productsBeforeSort = JsonConvert.DeserializeObject<List<Products>>(_xmlProducts);
            List<Products> productsAfterSort = _sort.SortProducts(productsBeforeSort, sortKey, ascending);

            Assert.That(productsBeforeSort[0].Name.Equals(productsAfterSort[1].Name),
                String.Format("products were not sorted correctly with name actual: {0}, found after sort: {1}", productsBeforeSort[0].Name, productsAfterSort[1].Name));
            Assert.That(productsBeforeSort[0].Price.Equals(productsAfterSort[1].Price),
                String.Format("products were not sorted correctly with price actual: {0}, found after sort: {1}", productsBeforeSort[0].Price, productsAfterSort[1].Price));
            Assert.That(productsBeforeSort[0].Stock.Equals(productsAfterSort[1].Stock),
                String.Format("products were not sorted correctly with stock actual: {0}, found after sort: {1}", productsBeforeSort[0].Stock, productsAfterSort[1].Stock));
        }

        [Test]
        public void xmln_Should_Be_SortedByStockDesc()
        {
            string sortKey = "Stock";
            bool ascending = false;
            List<Products> productsBeforeSort = JsonConvert.DeserializeObject<List<Products>>(_xmlProducts);
            List<Products> productsAfterSort = _sort.SortProducts(productsBeforeSort, sortKey, ascending);

            Assert.That(productsBeforeSort[0].Name.Equals(productsAfterSort[1].Name),
                String.Format("products were not sorted correctly with name actual: {0}, found after sort: {1}", productsBeforeSort[0].Name, productsAfterSort[1].Name));
            Assert.That(productsBeforeSort[0].Price.Equals(productsAfterSort[1].Price),
                String.Format("products were not sorted correctly with price actual: {0}, found after sort: {1}", productsBeforeSort[0].Price, productsAfterSort[1].Price));
            Assert.That(productsBeforeSort[0].Stock.Equals(productsAfterSort[1].Stock),
                String.Format("products were not sorted correctly with stock actual: {0}, found after sort: {1}", productsBeforeSort[0].Stock, productsAfterSort[1].Stock));
        }
    }
}