using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderDeliveryDate { get; set; }
        public string OrderPickupPoint { get; set; }

        public Order(int orderId, string orderStatus, DateTime orderDeliveryDate, string orderPickupPoint)
        {
            OrderID = orderId;
            OrderStatus = orderStatus;
            OrderDeliveryDate = orderDeliveryDate;
            OrderPickupPoint = orderPickupPoint;
        }
    }
}
