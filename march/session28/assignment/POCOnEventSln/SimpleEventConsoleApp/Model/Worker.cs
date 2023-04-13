
namespace SimpleEventConsoleApp.Model
{
    public delegate void WorkPerformHandler(int hours,WorkType workType);
    internal class Worker
    {
        public event WorkPerformHandler workPerformed;
        public event EventHandler WorkCompleted;
        public void DoWork(int hours,WorkType worktype)
        {
            if(workPerformed != null)
            {
                workPerformed(8, WorkType.GOTOMEETING);
            }
            workPerformed?.Invoke(8, WorkType.GENERATE_REPORT);
        }
    }
}
