namespace NeedForSpeed
{
    using NeedForSpeed.Cars;
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Car car = new Car(5, 10);
            car.Drive(2);
            Console.WriteLine(car.Fuel);
            Console.WriteLine();

            SportCar sport = new SportCar(25, 10);
            sport.Drive(1);
            Console.WriteLine(sport.Fuel);
        }
    }
}
