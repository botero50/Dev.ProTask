using System.Xml.Serialization;
using Dev.Pro.Helpers;

namespace Dev.Pro.Tasks
{

    public class Sorter
    {
        public List<Products> SortProducts(List<Products> products, string sortKey, bool ascending)
        {
            switch (sortKey.ToLower())
            {
                case "price":
                    products = ascending ? products.OrderBy(p => p.Price).ToList() : products.OrderByDescending(p => p.Price).ToList();
                    break;
                case "name":
                    products = ascending ? products.OrderBy(p => p.Name).ToList() : products.OrderByDescending(p => p.Name).ToList();
                    break;
                case "stock":
                    products = ascending ? products.OrderBy(p => p.Stock).ToList() : products.OrderByDescending(p => p.Stock).ToList();
                    break;
                default:
                    throw new ArgumentException("Invalid sort key");
            }
            return products;
        }

        public string SerializeToXml(List<Products> products)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ProductList));
            ProductList productList = new ProductList { Products = products };

            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, productList);
                return writer.ToString();
            }
        }
    }
}