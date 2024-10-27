using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3AppManagement.CarList;
using Week3AppManagement.Property;

namespace Week3AppManagement.MenuOptionsImplementations
{
    public class ChangeCarSettings
    {
        CarListManagement<CarProperty> carListManagement = new CarListManagement<CarProperty>();
        DeleteAndShowCarOption deleteAndShowCarOption = new DeleteAndShowCarOption();
        AddCarOption addCarOption = new AddCarOption();
        public void FindCarAndChangeSettings()
        {
            CarProperty carToChange = null;
            while (carToChange == null)
            {
                var carList = deleteAndShowCarOption.ShowAllCars();
                Console.WriteLine("enter car registration number you want to change");
                string registrationNumber = Console.ReadLine();
                carToChange = carList.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);
                if (carToChange == null)
                {
                    Console.WriteLine("car registration number not found try agien");
                }
            }
            if (carToChange != null)
            {
                List<string> equipmentList = null;
                if (carToChange.CarEquipment != null)
                {
                    equipmentList = carToChange.CarEquipment;
                }
                addCarOption.AddNewCar(equipmentList);
                carListManagement.DeleteCar(carToChange);
            }
        }
    }
}