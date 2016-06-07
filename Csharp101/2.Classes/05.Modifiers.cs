namespace Csharp101_1.Classes
{
    public class PublicModifiers
    {
        // can be accessed by all assemblies and callers
        public string myPublicField;
    }

    public class PrivateModifiers
    {
        // can be accessed only by methods withint the PrivateModifiers class
        private string myPrivateField;
    }

    public class ProtectedModifiers
    {
        // can only be accessed by ProtectedModifiers or classes that inherit from it
        protected string myProtectedField;
    }

    public class InternalModifiers
    {
        // can be accessed by any code within the same assembly as this is defined in
        internal string myInternalField;

        string myOtherInternalField; // no modifier defaults to internal
    }
}
