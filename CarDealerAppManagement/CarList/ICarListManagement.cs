using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3AppManagement.CarList
{
    public interface ICarListManagement<T>
    {
        static List<T> CarList { get; set; }
        void AddCar(T newCar);
        List<T> CheckAllCars();
        void DeleteCar(T carToDelete);
    }
}