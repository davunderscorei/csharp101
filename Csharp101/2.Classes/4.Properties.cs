namespace Csharp101_1.Classes
{
    class Properties
    {
        // java style
        private int myPropertyValue = 0;

        public int GetMyProperty()
        {
            return myPropertyValue;
        }

        public void SetMyProperty(int value)
        {
            myPropertyValue = value;
        }

        // workaround #1
        public int MyProperty1
        {
            get
            {
                return myPropertyValue;
            }
            set
            {
                myPropertyValue = value;
            }
        }

        // workaround #2 (implicit backing variable)
        public int MyProperty2 { get; set; }

        // workaround #3 (private access implicit backing variable)
        public int MyProperty3 { get; private set; }

        // workaround #4 (same as #3 except uses myPropertyValue)
        public int MyProperty4 => myPropertyValue;
    }
}
