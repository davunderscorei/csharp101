namespace Csharp101_1.Classes
{
    public class MyIntClass
    {
        public int MyValue { get; set; }
    }

    public class MyStringClass
    {
        public string MyValue { get; set; }
    }

    class Test1
    {
        void Tester()
        {
            var intClass = new MyIntClass();
            intClass.MyValue = 1;

            var stringClass = new MyStringClass();
            stringClass.MyValue = "hi";
        }
    }

    public class MyGenericClass<TType>
    {
        public TType MyValue { get; set; }
    }

    class Test2
    {
        void Tester()
        {
            var intClass = new MyGenericClass<int>();
            intClass.MyValue = 1;

            var stringClass = new MyGenericClass<string>();
            stringClass.MyValue = "hi";
        }
    }
}
