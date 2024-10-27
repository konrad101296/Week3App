using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3AppManagement.Equipment
{
    public class SafetyCarEquipment : KomfortCarEquipment
    {
        protected List<string> ListOfSafetyEquipment;

        public void EquipmentSafety()
        {
            ListOfSafetyEquipment = new List<string>
            {
            "driver airbag",
            "passenger airbag",
            "front side airbags",
            "driving track stabilization",
            "traction control",
            "ABS",
            "twilight sensor",
            "lane assistant",
            "central lock",
            "cruise control",
            "rain sensor",
            "immobilizer",
            "led lights",
            "rear parking sensors",
            "front parking sensors"
            };
            CarEquipmentManagement.AddListToList(ListOfSafetyEquipment);
        }
    }
}