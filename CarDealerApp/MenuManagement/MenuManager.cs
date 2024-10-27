using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3AppMenu.MenuInterface;

namespace Week3AppMenu.MenuManagement
{
    internal class MenuManager<T> : IMenuManager<T>
    {
        public List<T> MenuList { get; set; }
        public MenuManager()
        {
            MenuList = new List<T>();
        }

        public void Add(T menuOption)
        {
            MenuList.Add(menuOption);
        }

        public List<T> ShowList()
        {
            return MenuList;
        }
    }
}