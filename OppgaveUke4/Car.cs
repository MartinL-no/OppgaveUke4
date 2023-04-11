namespace OppgaveUke4
{
    public class Car
    {
        public string Brand { get; }
        public string RegistrationNumber { get; }
        public int Year { get; }
        public int NumberOfKilometers { get; }

        public Car(string brand, string registrationNumber, int year, int numberOfKilometers)
        {
            Brand = brand;
            RegistrationNumber = registrationNumber;
            Year = year;
            NumberOfKilometers = numberOfKilometers;
        }
    }
}