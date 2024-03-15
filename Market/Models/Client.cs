using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    public class Client
    {
        public int ClientID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Client(int clientID, string name, string email, string address)
        {
            ClientID = clientID;
            Name = name;
            Email = email;
            Address = address;
        }
    }
}
