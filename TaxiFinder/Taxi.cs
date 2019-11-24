namespace TaxiFinder
{
    internal class Taxi
    {
        public Taxi(string brand, string model, string color, string @class, string driver, string number)
        {
            Brand = brand;
            Model = model;
            Color = color;
            Class = @class;
            Driver = driver;
            Number = number;
        }

        public string Brand { get; }
        public string Model { get; }
        public string Color { get; }
        public string Class { get; }
        public string Driver { get; }
        public string Number { get; }
    }
}
