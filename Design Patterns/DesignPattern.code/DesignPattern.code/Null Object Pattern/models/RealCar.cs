namespace DesignPattern.code.Null_Object_Pattern.models
{
    public class RealCar : Car
    {
        public override void drive()
        {
            Console.WriteLine("Car is running");
        }

        public override void stop()
        {
            Console.WriteLine("Car is stopped");

        }
    }
}
