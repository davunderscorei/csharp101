namespace Csharp101_1.Classes
{
    // an interface is like a prototype or "contract" 
    // declaring what the class will implement
    public interface IMyInterface
    {
        bool ICanDoStuff { get; set; }
    }

    public interface IMyOtherInterface
    {
        bool ICanDoOtherStuff { get; set; }
    }

    public class IWillImplementStuff : IMyInterface, IMyOtherInterface
    {
        public bool ICanDoStuff { get; set; }
        public bool ICanDoOtherStuff { get; set; }
    }
}
