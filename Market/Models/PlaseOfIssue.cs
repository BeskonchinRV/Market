using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    public class PlaseOfIssue
    {
        public int PointID { get; set; }
        public string Address { get; set; }

        public PlaseOfIssue(int pointId, string address)
        {
            PointID = pointId;
            Address = address;
        }
    }
}
