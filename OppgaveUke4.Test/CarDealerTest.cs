namespace OppgaveUke4.Test;

public class CarDealerTest
{
    [Test]
    public void CarDealerTestEmpty()
    {
        var cardealer = new Cardealer("Cardealer A", "Address A");

        Assert.That(cardealer.Name, Is.EqualTo("Cardealer A"));
        Assert.That(cardealer.Address, Is.EqualTo("Address A"));
        Assert.That(cardealer.GetAllCars().Count, Is.EqualTo(0));
    }

    [Test]
    public void CarDealerTestOneCar()
    {
        var cardealer = new Cardealer("Cardealer A", "Address A");
        var car = new Car("Mercedes", "ABC123", 2010, 100000);

        cardealer.AddCar(car);

        Assert.That(cardealer.GetAllCars().Count, Is.EqualTo(1));
    }

    [Test]
    public void CarDealerTestTwoCars()
    {
        var cardealer = new Cardealer("Cardealer A", "Address A");
        var car1 = new Car("Mercedes", "ABC123", 2010, 100000);
        var car2 = new Car("Ford", "DEF456", 2012, 80000);

        cardealer.AddCar(car1);
        cardealer.AddCar(car2);

        Assert.That(cardealer.GetAllCars().Count, Is.EqualTo(2));
    }

    [Test]
    public void CarDealerTestGetOldCars()
    {
        var cardealer = new Cardealer("Cardealer A", "Address A");
        var car1 = new Car("Mercedes", "ABC123", 2010, 100000);
        var car2 = new Car("Ford", "DEF456", 2011, 80000);
        var car3 = new Car("Toyota", "GHI789", 2015, 50000);
        cardealer.AddCar(car1);
        cardealer.AddCar(car2);
        cardealer.AddCar(car3);

        var oldCars = cardealer.GetOldCars(2011);

        Assert.That(oldCars.Count, Is.EqualTo(1));
        Assert.Contains(car1, oldCars);
    }

    [Test]
    public void CarDealerTestGetHighKilometerCars()
    {
        var cardealer = new Cardealer("Cardealer A", "Address A");
        var car1 = new Car("Mercedes", "ABC123", 2010, 100000);
        var car2 = new Car("Ford", "DEF456", 2011, 80000);
        var car3 = new Car("Toyota", "GHI789", 2015, 50000);
        cardealer.AddCar(car1);
        cardealer.AddCar(car2);
        cardealer.AddCar(car3);

        var highKilometerCars = cardealer.GetHighKilometerCars(80000);

        Assert.That(highKilometerCars.Count, Is.EqualTo(1));
        Assert.Contains(car1, highKilometerCars);
    }

    [Test]
    public void CarDealerTestRemovingCar()
    {
        var cardealer = new Cardealer("Cardealer A", "Address A");
        var car1 = new Car("Mercedes", "ABC123", 2010, 100000);
        var car2 = new Car("Ford", "DEF456", 2011, 80000);
        cardealer.AddCar(car1);
        cardealer.AddCar(car2);

        Assert.That(cardealer.GetAllCars().Count, Is.EqualTo(2));

        var isCarRemoved = cardealer.RemoveCar("ABC123");

        Assert.That(isCarRemoved, Is.EqualTo(true));
        Assert.That(cardealer.GetAllCars().Count, Is.EqualTo(1));
    }

    [Test]
    public void CarDealerTestRemovingWithWrongRegistrationNumber()
    {
        var cardealer = new Cardealer("Cardealer A", "Address A");
        var car1 = new Car("Mercedes", "ABC123", 2010, 100000);
        var car2 = new Car("Ford", "DEF456", 2011, 80000);
        cardealer.AddCar(car1);
        cardealer.AddCar(car2);

        Assert.That(cardealer.GetAllCars().Count, Is.EqualTo(2));

        var isCarRemoved = cardealer.RemoveCar("BLAHHHH");

        Assert.That(isCarRemoved, Is.EqualTo(false));
        Assert.That(cardealer.GetAllCars().Count, Is.EqualTo(2));
    }
}
