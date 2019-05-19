using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFService.DTO
{
    [DataContract]
    public class MobileDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Model { get; set; }
        [DataMember]
        public float Price { get; set; }
        [DataMember]
        public string Producer { get; set; }
    }
}
