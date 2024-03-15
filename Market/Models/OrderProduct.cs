using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    public class OrderProduct
    {
        public int OrderID { get; set; }
        public int NumberProduct { get; set; }

        public OrderProduct(int orderId, int numberProduct)
        {
            OrderID = orderId;
            NumberProduct = numberProduct;
        }
    }
}
