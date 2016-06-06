namespace Csharp101_1.Classes
{
    public class Vehicle
    {
        public bool HasWheels { get; set; }
    }

    // a class can only ever inherit ONE other class (including abstract classes)
    public class Car : Vehicle
    {
        public Car()
        {
            this.HasWheels = true;
        }
    }
}
