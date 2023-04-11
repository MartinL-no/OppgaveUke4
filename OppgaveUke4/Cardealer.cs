using System.Collections;
using System.Linq;

namespace OppgaveUke4
{
    public class Cardealer
    {
        public string Name { get; }
        public string Address { get; }
        private List<Car> _cars;

        public Cardealer(string name, string address)
        {
            Name = name;
            Address = address;
            _cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            _cars.Add(car);
        }
        public List<Car> GetAllCars()
        {
            return _cars;
        }

        public List<Car> GetOldCars(int year)
        {
            return _cars.Where(c => c.Year < year).ToList();
        }

        public List<Car> GetHighKilometerCars(int numberOfKilometers)
        {
            return _cars.Where(c => c.NumberOfKilometers > numberOfKilometers).ToList();
        }

        public bool RemoveCar(string registrationNumber)
        {
            var carToRemove = _cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);

            return _cars.Remove(carToRemove);
        }
    }
}