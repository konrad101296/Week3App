using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Week3AppManagement.CarList;
using Week3AppManagement.Property;

namespace Week3AppManagement.Equipment
{
    public class CarEquipmentManagement : SafetyCarEquipment
    {
        CarListManagement<CarProperty> carListManagement = new CarListManagement<CarProperty>();
        static private List<List<string>> EquipmentList = new List<List<string>>();

        static public void AddListToList(List<string> typeOfEquipment)
        {
            EquipmentList.Add(typeOfEquipment);
        }

        public List<List<string>> GetAllLists()
        {
            return EquipmentList;
        }

        public void CallingMethodsCarEquipment()
        {
            EquipmentSafety();
            EquipmentKomfort();
            EquipmentMultimedia();
        }

        public string AddEquipmenToCar(List<string> list)
        {
            while (true)
            {
                Console.WriteLine("\nEnter equipment name to add it to car or... \nPress 1 to exit\nPress 2 to add equipment not listed\n");
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
                string nameEquipment = Console.ReadLine();
                if (nameEquipment == "1")
                {
                    break;
                }
                if (nameEquipment == "2")
                {
                    Console.WriteLine("Enter equipment name");
                    string equipmentNotListed = Console.ReadLine();
                    return equipmentNotListed;
                }
                string foundEquipment = list.FirstOrDefault(e => e == nameEquipment);
                if (foundEquipment != null)
                {
                    return foundEquipment;
                }
                else
                {
                    Console.WriteLine("equipment name not faund press any key to continue");
                    Console.ReadKey();
                }
            }
            return null;
        }

        public void ChooseCarAndAddEquipment()
        {
            CallingMethodsCarEquipment();
            var allCars = carListManagement.CheckAllCars();
            Console.WriteLine("enter car registrationNumber to which you want to add equipment");
            string registrationNumber = Console.ReadLine();
            var findCar = allCars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);
            if (findCar != null)
            {
                string equipmentToAdd = null;
                Console.WriteLine("choose which type of equipment you wont to add press 1,2 or 3");
                Console.WriteLine("1.safety equipment");
                Console.WriteLine("2.komfort equipment");
                Console.WriteLine("3.multimedia equipment");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        equipmentToAdd = AddEquipmenToCar(ListOfSafetyEquipment);
                        break;
                    case "2":
                        equipmentToAdd = AddEquipmenToCar(listOfKomfortEquipment);
                        break;
                    case "3":
                        equipmentToAdd = AddEquipmenToCar(ListOfMultimediaEquipment);
                        break;
                    default:
                        Console.WriteLine("invalid choice press 1,2 or 3");
                        break;
                }
                if (equipmentToAdd != null)
                {
                    findCar.CarEquipment ??= new List<string>();
                    Console.WriteLine($"{equipmentToAdd} added");
                    findCar.CarEquipment.Add(equipmentToAdd);
                }
            }
            else
            {
                Console.WriteLine("car not faund");
            }
        }

        public void ChooseCarAndDeleteEquipment()
        {
            var carList = carListManagement.CheckAllCars();
            Console.WriteLine("enter car registration number you want to delete");
            string registrationNumber = Console.ReadLine();
            var findCar = carList.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);
            if (findCar != null)
            {
                Console.WriteLine("\nchoose car equipment you want to delete");
                foreach (var item in findCar.CarEquipment)
                {
                    Console.WriteLine(item);
                }
                string equipmentToDelete = Console.ReadLine();
                string findEquipmentToDelete = findCar.CarEquipment.FirstOrDefault(c => c == equipmentToDelete);
                if (findEquipmentToDelete != null)
                {
                    Console.WriteLine($"{findEquipmentToDelete} removed");
                    findCar.CarEquipment.Remove(findEquipmentToDelete);
                }
                else
                {
                    Console.WriteLine("equipment not faund");
                }
            }
            else
            {
                Console.WriteLine("car not faund");
            }
        }

        public void ChooseAction()
        {
            Console.WriteLine("1.Add equipment to car\n2.Delete equipment from car");
            string actionNumber = Console.ReadLine();
            switch (actionNumber)
            {
                case "1":
                    ChooseCarAndAddEquipment();
                    break;
                case "2":
                    ChooseCarAndDeleteEquipment();
                    break;
                default:
                    Console.WriteLine("invalid choice press 1 or 2");
                    break;
            }
        }
    }
}