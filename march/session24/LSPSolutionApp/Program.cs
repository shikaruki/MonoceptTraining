using LSPSolutionApp.Model;

namespace LSPSolutionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(100, 20);
            ShouldNotChangeHeight_IfWidthIsModified(rectangle);
            ShouldNotChangeHeight_IfWidthIsModified(new Square(50));
        }
        public static void ShouldNotChangeHeight_IfWidthIsModified(IPolygon ipolygon)
        {
            int beforeChangeHeight = ipolygon.GetHeight;
            ipolygon.SetWidth(ipolygon.GetWidth + 10);
            int afterChangeHeight = ipolygon.GetHeight;
            Console.WriteLine(beforeChangeHeight == afterChangeHeight);
            Console.WriteLine("before Change width, Height =" + beforeChangeHeight);
            Console.WriteLine("After change width, Height=" + afterChangeHeight);
            Console.WriteLine();
        }
    }
}