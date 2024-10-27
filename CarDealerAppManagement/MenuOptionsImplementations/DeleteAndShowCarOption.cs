using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3AppManagement.CarList;
using Week3AppManagement.Property;

namespace Week3AppManagement.MenuOptionsImplementations
{
    public class DeleteAndShowCarOption
    {
        CarListManagement<CarProperty> carManagement = new CarListManagement<CarProperty>();

        public List<CarProperty> ShowAllCars()
        {
            var carList = carManagement.CheckAllCars();
            foreach (var car in carList)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"car registration number: {car.RegistrationNumber}");
                Console.WriteLine($"car body type: {car.CarBodyType}");
                Console.WriteLine($"car brand: {car.CarBrand}");
                Console.WriteLine($"car model: {car.CarModel}");
                Console.WriteLine($"car price: {car.CarPrice}");
                Console.WriteLine("car equipment:");
                if (car.CarEquipment != null)
                {
                    foreach (var item in car.CarEquipment)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            Console.WriteLine("--------------------------------------------------");
            return carList;
        }

        public void DeleteCar()
        {
            var carList = ShowAllCars();
            Console.WriteLine("Enter car registration number you want to delete");
            string chooseCar = Console.ReadLine();
            var findCarToDelete = carList.FirstOrDefault(c => c.RegistrationNumber == chooseCar);
            if (findCarToDelete != null)
            {
                Console.WriteLine("car deleted");
                carManagement.DeleteCar(findCarToDelete);
            }
            else
            {
                Console.WriteLine("car registration number not faund");
            }
        }
    }
}