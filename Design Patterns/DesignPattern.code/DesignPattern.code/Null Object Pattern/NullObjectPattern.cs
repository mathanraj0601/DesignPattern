using DesignPattern.code.Null_Object_Pattern.models;

namespace DesignPattern.code.Null_Object_Pattern
{
    public class NullObjectPattern
    {
        public void Demo()
        {
            Car realCar = new RealCar();
            Car nullCar = new NullCar();

            CarService carService = new();

            carService.Service(realCar);
            carService.Service(nullCar);
        }
    }
}
