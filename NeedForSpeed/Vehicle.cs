namespace NeedForSpeed
{
    public class Vehicle
    {
        private double fuelConsumption = 1.25;
        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public double Fuel { get; set; }
        public int HorsePower { get; set; }
        public virtual void Drive(double kilometers)
        {
            this.Fuel -= kilometers * this.fuelConsumption;
        }
    }
}
