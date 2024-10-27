using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3AppMenu.MenuManagement
{
    internal class MenuProperties
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MenuProperties(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}