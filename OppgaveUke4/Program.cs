using System.Collections.Generic;

namespace OppgaveUke4;
class Program
{
    static void Main(string[] args)
    {
        Cardealer cardealer = new Cardealer("Cardealer A", "Address A");

        Car car1 = new Car("Mercedes", "ABC123", 2010, 100000);
        cardealer.AddCar(car1);

        Car car2 = new Car("Ford", "DEF456", 2012, 80000);
        cardealer.AddCar(car2);

        Car car3 = new Car("Toyota", "GHI789", 2015, 50000);
        cardealer.AddCar(car3);

        List <Car> oldCars = cardealer.GetOldCars(2011); // oldCars contains bill and car2
        List<Car> highKilometerCars = cardealer.GetHighKilometerCars(60000); // high kilometer Cars contain bill and car2

        cardealer.RemoveCar("GHI789");

        List<Car> cars = cardealer.GetAllCars(); // cars only contains car1 and car2
    }
}