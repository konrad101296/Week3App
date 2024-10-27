using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Week3AppManagement.Equipment;
using Week3AppManagement.MenuOptionsImplementations;
using Week3AppMenu.MenuManagement;

namespace Week3AppMenu.ActionsToChoose
{
    internal class MenuActions
    {
        MenuService menuService = new MenuService();
        AddCarOption addCarOption = new AddCarOption();
        DeleteAndShowCarOption deleteAndShowCarOption = new DeleteAndShowCarOption();
        CheckSpecificCarOption checkSpecificCarOption = new CheckSpecificCarOption();
        ChangeCarSettings changeCarSettings = new ChangeCarSettings();
        CarEquipmentManagement carEquipmentManagement = new CarEquipmentManagement();
        public void ActionsToChoose()
        {
            Console.WriteLine("Welcome in your used car dealer\nChoose what you wonna do");
            bool loop = true;
            while (loop)
            {
                int choosenOption = menuService.MenuOptions();
                switch (choosenOption)
                {
                    case 1:
                        addCarOption.AddNewCar(null);
                        break;
                    case 2:
                        carEquipmentManagement.ChooseAction();
                        break;
                    case 3:
                        deleteAndShowCarOption.DeleteCar();
                        break;
                    case 4:
                        deleteAndShowCarOption.ShowAllCars();
                        break;
                    case 5:
                        checkSpecificCarOption.CheckSpecificCar();
                        break;
                    case 6:
                        changeCarSettings.FindCarAndChangeSettings();
                        break;
                    case 7:
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("the number you entered does not exist");
                        break;
                }
            }
        }
    }
}