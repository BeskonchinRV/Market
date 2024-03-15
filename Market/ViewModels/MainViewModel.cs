using System.Collections.ObjectModel;
using System.ComponentModel;
using Market.Data;
using Market.Models;

namespace Market.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // Коллекции для отображения данных из различных таблиц
        public ObservableCollection<Client> Clients { get; set; }
        public ObservableCollection<Order> Orders { get; set; }
        public ObservableCollection<OrderProduct> OrderProducts { get; set; }
        public ObservableCollection<PlaseOfIssue> PlacesOfIssue { get; set; }
        public ObservableCollection<Product> Products { get; set; }
        public ObservableCollection<Role> Roles { get; set; }
        public MainViewModel()
        {
            // Инициализация коллекций
            Clients = new ObservableCollection<Client>(DataContext.Clients);
            Orders = new ObservableCollection<Order>(DataContext.Orders);
            OrderProducts = new ObservableCollection<OrderProduct>(DataContext.OrderProducts);
            PlacesOfIssue = new ObservableCollection<PlaseOfIssue>(DataContext.PlacesOfIssue);
            Products = new ObservableCollection<Product>(DataContext.Products);
            Roles = new ObservableCollection<Role>(DataContext.Roles);
        }
    }
}
