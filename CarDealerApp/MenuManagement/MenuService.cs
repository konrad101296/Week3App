using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3AppMenu.MenuManagement
{
    internal class MenuService : MenuManager<MenuProperties>
    {
        public int MenuOptions()
        {
            MenuList.Clear();
            AddMenuOptions(1, "Add car");
            AddMenuOptions(2, "Interior equipment");
            AddMenuOptions(3, "Delete car");
            AddMenuOptions(4, "Check your cars");
            AddMenuOptions(5, "Check a specific car");
            AddMenuOptions(6, "Change car settings");
            AddMenuOptions(7, "Exit from application");

            ShowMenuList();
            int choosenOption = ChooseMenuOption();
            return choosenOption;
        }

        public void AddMenuOptions(int id, string name)
        {
            MenuProperties menuProperties = new MenuProperties(id, name);
            Add(menuProperties);
        }

        public void ShowMenuList()
        {
            var menuList = ShowList();
            foreach (var menuOption in menuList)
            {
                Console.WriteLine($"{menuOption.Id}. {menuOption.Name}");
            }
        }

        public int ChooseMenuOption()
        {
            string choosenOption = Console.ReadLine();
            int parsedChoosenOption;
            int.TryParse(choosenOption, out parsedChoosenOption);
            return parsedChoosenOption;
        }
    }
}