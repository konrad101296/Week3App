using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3AppManagement.Property
{
    public class CarProperty
    {
        public string RegistrationNumber { get; set; }
        public string CarBodyType { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string CarPrice { get; set; }
        public List<string> CarEquipment { get; set; }

    }
}