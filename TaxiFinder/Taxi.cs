namespace TaxiFinder
{
    internal class Taxi
    {
        public Taxi(string brand, string model, string color, string driver, string number)
        {
            Brand = brand;
            Model = model;
            Color = color;
            Driver = driver;
            Number = number;
        }

        public string Brand { get; }
        public string Model { get; }
        public string Color { get; }
        public string Driver { get; }
        public string Number { get; }
    }
}
