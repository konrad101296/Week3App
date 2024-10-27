namespace Week3AppManagement.CarList
{
    public class CarListManagement<T> : ICarListManagement<T>
    {
        static public List<T> CarList { get; set; }
        public CarListManagement()
        {
            CarList = new List<T>();
        }

        public void AddCar(T newCar)
        {
            CarList.Add(newCar);
        }

        public List<T> CheckAllCars()
        {
            return CarList;
        }

        public void DeleteCar(T carToDelete)
        {
            CarList.Remove(carToDelete);
        }
    }
}