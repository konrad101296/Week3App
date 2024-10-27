using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3AppManagement.BodyType
{
    public class CarBodyType
    {
        public string[] ArrayBodyType()
        {
            string[] arrayBodyType = { "Small Car", "City Car", "Coupe", "Convertible", "Estate", "Compact", "Minivan", "Saloon", "SUV" };
            return arrayBodyType;
        }

        public void ShowArrayBodyType()
        {
            string[] arrayBodyType = ArrayBodyType();
            foreach (string str in arrayBodyType)
            {
                Console.WriteLine(str);
            }
        }

        public string ChooseBodyType()
        {
            Console.WriteLine("Choose body type");
            string bodyType = Console.ReadLine();
            string choosenBodyType = ArrayBodyType().FirstOrDefault(b => b.Equals(bodyType, StringComparison.OrdinalIgnoreCase));
            if (choosenBodyType != null)
            {
                return choosenBodyType;
            }
            else
            {
                Console.WriteLine("Body type not found try agien");
                return ChooseBodyType();
            }
        }
    }
}