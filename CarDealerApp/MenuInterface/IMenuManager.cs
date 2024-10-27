using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3AppMenu.MenuInterface
{
    internal interface IMenuManager<T>
    {
        List<T> MenuList { get; }
        void Add(T menuOption);
        List<T> ShowList();
    }
}