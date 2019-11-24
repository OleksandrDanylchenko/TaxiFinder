namespace TaxiFinder
{
    internal class Taxi
    {
        public Taxi()
        {
            Brand = Model = Color = Driver = Number = string.Empty;
        }

        public Taxi(string brand, string model, string color, string Class, string driver, string number)
        {
            Brand = brand;
            Model = model;
            Color = color;
            this.Class = Class;
            Driver = driver;
            Number = number;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Class { get; set; }
        public string Driver { get; set; }
        public string Number { get; set; }
    }
}
