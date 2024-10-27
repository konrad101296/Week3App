using System.Collections.Generic;
using System.Diagnostics;
using Week3AppMenu.ActionsToChoose;

namespace Week3AppMenu.MainMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            MenuActions menuActions = new MenuActions();
            menuActions.ActionsToChoose();
        }
    }
}