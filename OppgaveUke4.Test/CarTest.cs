namespace OppgaveUke4.Test;

public class CarTest
{
    [Test]
    public void CarTestOne()
    {
        Car car = new Car("Mercedes", "ABC123", 2010, 100000);

        Assert.That(car.Brand, Is.EqualTo("Mercedes"));
        Assert.That(car.RegistrationNumber, Is.EqualTo("ABC123"));
        Assert.That(car.Year, Is.EqualTo(2010));
        Assert.That(car.NumberOfKilometers, Is.EqualTo(100000));
    }
}
