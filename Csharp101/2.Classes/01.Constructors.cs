namespace Csharp101_1._2.Classes
{
    class Constructors
    {
        Constructors()
        {
            // I run when `new Constructors()` is called
        }

        Constructors(int param1)
        {
            // I run when `new Constructors(xxx)` is called
        }

        private Constructors(string magic)
        {
            // I can only be run internally with this class
        }

        public static Constructors CreateInstance()
        {
            return new Constructors("magic code");
        }
    }
}
