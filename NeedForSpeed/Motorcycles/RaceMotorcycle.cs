namespace NeedForSpeed.Motorcycles
{
    public class RaceMotorcycle : Motorcycle
    {
        private double fuelConsumption = 8;
        public RaceMotorcycle(int horsePower, double fuel) 
            : base(horsePower, fuel)
        {
        }
        public override void Drive(double kilometers)
        {
            base.Fuel -= kilometers * this.fuelConsumption;
        }
    }
}
