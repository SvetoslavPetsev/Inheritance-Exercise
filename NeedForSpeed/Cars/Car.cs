namespace NeedForSpeed.Cars
{
    public class Car : Vehicle
    {
        private double fuelConsumption = 3;
        public Car(int horsePower, double fuel) 
            : base(horsePower, fuel)
        {
        }
        public override void Drive(double kilometers)
        {
            base.Fuel -= kilometers * this.fuelConsumption;
        }
    }
}
