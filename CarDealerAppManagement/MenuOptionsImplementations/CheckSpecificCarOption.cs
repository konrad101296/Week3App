using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Week3AppManagement.CarList;
using Week3AppManagement.Property;

namespace Week3AppManagement.MenuOptionsImplementations
{
    public class CheckSpecificCarOption
    {
        CarListManagement<CarProperty> carListManagement = new CarListManagement<CarProperty>();
        public void CheckSpecificCar()
        {
            Console.WriteLine("Enter car registration number you wont to show");
            string choosenCar = Console.ReadLine();
            var findChoosenCar = carListManagement.CheckAllCars().FirstOrDefault(c => c.RegistrationNumber == choosenCar);
            if (findChoosenCar != null)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"car registration number: {findChoosenCar.RegistrationNumber}");
                Console.WriteLine($"car body type: {findChoosenCar.CarBodyType}");
                Console.WriteLine($"car brand: {findChoosenCar.CarBrand}");
                Console.WriteLine($"car model: {findChoosenCar.CarModel}");
                Console.WriteLine($"car price: {findChoosenCar.CarPrice}");
                Console.WriteLine("car equipment:");
                if (findChoosenCar.CarEquipment != null)
                {
                    foreach (var item in findChoosenCar.CarEquipment)
                    {
                        Console.WriteLine(item);
                    }
                }
                Console.WriteLine("--------------------------------------------------");
            }
            else
            {
                Console.WriteLine("car registration number not faund");
            }
        }
    }
}