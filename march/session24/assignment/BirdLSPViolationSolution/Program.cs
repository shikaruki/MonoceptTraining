using BirdLSPViolationSolution.Model;

namespace BirdLSPViolationSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintBirdDetails(new Eagle("Eagle"));
            PrintBirdDetails(new Penguine("PEnguine"));
        }
        public static void PrintBirdDetails(ICanFly bird)
        {

            Console.WriteLine("{1} - Bird Can Fly :{0}", bird.CanFly(),bird.Name);

            Console.WriteLine();
        }
    }
}