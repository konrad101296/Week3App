using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3AppManagement.BodyType;
using Week3AppManagement.CarList;
using Week3AppManagement.Property;

namespace Week3AppManagement.MenuOptionsImplementations
{
    public class AddCarOption
    {
        CarListManagement<CarProperty> carListManagement = new CarListManagement<CarProperty>();
        CarBodyType carBodyType = new CarBodyType();
        public void AddNewCar(List<string> equipmentList)
        {
            CarProperty newCar = new CarProperty();
            Console.WriteLine("Please enter car registration number you wont to add");
            string registrationNumber = Console.ReadLine();
            newCar.RegistrationNumber = registrationNumber;

            carBodyType.ShowArrayBodyType();
            string choosenBodyType = carBodyType.ChooseBodyType();
            newCar.CarBodyType = choosenBodyType;

            Console.WriteLine("Please enter car brand");
            string carBrand = Console.ReadLine();
            newCar.CarBrand = carBrand;

            Console.WriteLine("Please enter car model");
            string carModel = Console.ReadLine();
            newCar.CarModel = carModel;

            Console.WriteLine("Please enter car price");
            string carPrice = Console.ReadLine();
            newCar.CarPrice = carPrice;

            carListManagement.AddCar(newCar);
            newCar.CarEquipment = equipmentList;
            Console.WriteLine("car added");
        }
    }
}