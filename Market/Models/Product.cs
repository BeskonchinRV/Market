using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Photo { get; set; }
        public string Manufacturer { get; set; }
        public int Quantity { get; set; }

        public Product(int productId, string name, int price, string photo, string manufacturer, int quantity)
        {
            ProductID = productId;
            Name = name;
            Price = price;
            Photo = photo;
            Manufacturer = manufacturer;
            Quantity = quantity;
        }
    }
}
