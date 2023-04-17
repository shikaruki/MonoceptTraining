using SingletonPatternAppv1.Model;

namespace SingletonPatternAppv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(DataService.GetInstance().DoSomething);
            t1.Start();

            Thread t2 = new Thread(DataService.GetInstance().DoSomething);
            t2.Start();

            Thread t3 = new Thread(DataService.GetInstance().DoSomething);
            t3.Start();
        }
    }
}