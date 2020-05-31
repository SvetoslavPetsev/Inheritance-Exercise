namespace NeedForSpeed.Cars
{
    public class SportCar : Car
    {
        private double fuelConsumption = 10;

        public SportCar(int horsePower, double fuel) 
            : base(horsePower, fuel)
        {
        }

        public override void Drive(double kilometers)
        {
            base.Fuel -= kilometers * this.fuelConsumption;
        }
    }
}
