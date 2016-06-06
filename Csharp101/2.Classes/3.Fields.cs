namespace Csharp101_1.Classes
{
    class Fields
    {
        int aClassIntField = 0;
        string aClassStringField;
        Fields aSelfReferencingField;

        void FieldTest()
        {
            // these are the same thing in this scope
            aClassIntField = 10;
            this.aClassIntField = 10;
        }
    }
}
