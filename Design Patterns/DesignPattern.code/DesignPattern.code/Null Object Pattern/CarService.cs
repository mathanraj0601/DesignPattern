using DesignPattern.code.Null_Object_Pattern.models;

namespace DesignPattern.code.Null_Object_Pattern
{
    public class CarService
    {
        public CarService() {
        }

        public void Service(Car car)
        {
            // no null check as no value is passed as a object instead of null
            car.drive();
            car.stop();
        }
    }
}
