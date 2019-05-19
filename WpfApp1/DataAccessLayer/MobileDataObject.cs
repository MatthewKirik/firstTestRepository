using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class MobileDataObject
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Producer { get; set; }
    }
}
