using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySmartHouse.Models
{
    public class Device
    {
        public int id;
        public string MacAdress;
        public type_device type;
        public string status;
        public DateTime date;
    }
}