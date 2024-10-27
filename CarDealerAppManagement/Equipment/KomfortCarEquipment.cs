namespace Week3AppManagement.Equipment
{
    public class KomfortCarEquipment : MultimediaCarEquipment
    {
        protected List<string> listOfKomfortEquipment;

        public void EquipmentKomfort()
        {
            listOfKomfortEquipment = new List<string>
            {
                "air curtains",
                "heated side mirrors",
                "electrochromatic rear-view mirror",
                "rearview camera",
                "automatic climate control",
                "electric front windows",
                "electric rear windows",
                "cd",
                "alloy wheels",
                "tinted windows",
                "electrically adjustable mirrors",
                "power steering"
            };
            CarEquipmentManagement.AddListToList(listOfKomfortEquipment);
        }
    }
}