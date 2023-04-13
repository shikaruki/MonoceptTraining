using SimpleEventConsoleApp.Model;

namespace SimpleEventConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            worker.workPerformed += new EventHandler<WorkPerformHandler>(Worker_Performed);
        }
        private void Worker_Performed(object sender,Wor)
    }
}