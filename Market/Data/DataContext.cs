using Market.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Data
{
    public static class DataContext
    {
        public static List<OrderProduct> OrderProducts { get; set; }
        public static List<Client> Clients { get; set; }
        public static List<Order> Orders { get; set; }
        public static List<PlaseOfIssue> PlacesOfIssue { get; set; }
        public static List<Product> Products { get; set; }
        public static List<Role> Roles { get; set; }

        static DataContext()
        {
            // Примеры данных для каждой таблицы
            OrderProducts = new List<OrderProduct>
            {
                new OrderProduct(1, 10),
                new OrderProduct(2, 20)
            };

            Clients = new List<Client>
            {
                new Client(1, "Иванов", "ivanov@example.com", "Адрес 1"),
                new Client(2, "Петров", "petrov@example.com", "Адрес 2")
            };

            Orders = new List<Order>
            {
                new Order(1, "В обработке", DateTime.Today, "Точка 1"),
                new Order(2, "Доставлен", DateTime.Today.AddDays(-3), "Точка 2")
            };

            PlacesOfIssue = new List<PlaseOfIssue>
            {
                new PlaseOfIssue(1, "Адрес точки 1"),
                new PlaseOfIssue(2, "Адрес точки 2")
            };

            Products = new List<Product>
            {
                new Product(1, "Товар 1", 100, "Фото 1", "Производитель 1", 10),
                new Product(2, "Товар 2", 200, "Фото 2", "Производитель 2", 20)
            };

            Roles = new List<Role>
            {
                new Role(1, "Роль 1"),
                new Role(2, "Роль 2")
            };
        }
    }
}
