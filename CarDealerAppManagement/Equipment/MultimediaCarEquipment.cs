using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3AppManagement.Equipment
{
    public class MultimediaCarEquipment
    {
        protected List<string> ListOfMultimediaEquipment;

        public void EquipmentMultimedia()
        {
            ListOfMultimediaEquipment = new List<string>
            {
                "bluetooth",
                "usb socket",
                "mp3",
                "factory radio",
                "gps navigation"
            };
            CarEquipmentManagement.AddListToList(ListOfMultimediaEquipment);
        }
    }
}