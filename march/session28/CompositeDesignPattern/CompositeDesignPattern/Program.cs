using CompositeDesignPattern.Model;

namespace CompositeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Folder compositeRoot = new Folder("Movies");
            compositeRoot.AddChild(new File("A.av", 400));
            compositeRoot.AddChild(new File("B.av", 500));

            Folder action = new Folder("Action");
            action.AddChild(new File("c.avi", 700));

            compositeRoot.AddChild(action);


            Folder drama = new Folder("Drama");
            drama.AddChild(new File("d.avi",800));
            drama.AddChild(action);
            compositeRoot.AddChild(drama);
            compositeRoot.Display();

        }
    }
}