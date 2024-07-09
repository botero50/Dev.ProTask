using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dev.Pro.Helpers
{
    public class Products
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }

    [XmlRoot("Products")]
    public class ProductList
    {
        [XmlElement("Product")]
        public List<Products> Products { get; set; }
    }
}
