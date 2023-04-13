using DelegateApp.Model;
using static DelegateApp.Model.Math;

namespace DelegateApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Model.Math obj = new Model.Math();
            var del_obj1 = new Model.Math.addnum(obj.sum);
            var del_obj2 = new Model.Math.subnum(obj.subtract);

            // pass the values to the methods by delegate object
            del_obj1(100, 40);
            del_obj2(100, 60);

            // These can be written as using
            // "Invoke" method
            del_obj1.Invoke(100, 40);
            del_obj2.Invoke(100, 60);
        }
    }
}