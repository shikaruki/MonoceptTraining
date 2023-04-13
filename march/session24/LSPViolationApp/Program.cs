using LSPViolationApp.Model;

namespace LSPViolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShouldNotChangeHeight_IfWidthIsModified(new Rectangle(100, 20));
            ShouldNotChangeHeight_IfWidthIsModified(new Square(50));
        }
        public static void ShouldNotChangeHeight_IfWidthIsModified(Rectangle rectangle)
        {
            int beforeChangeHeight = rectangle.GetHeight();
            rectangle.SetWidth(rectangle.GetWidth()+10);
            int afterChangeHeight = rectangle.GetHeight();
            Console.WriteLine(beforeChangeHeight ==  afterChangeHeight);
            Console.WriteLine("before Change width, Height ="+beforeChangeHeight);
            Console.WriteLine("After change width, Height="+afterChangeHeight);
            Console.WriteLine();
        }
    }
}