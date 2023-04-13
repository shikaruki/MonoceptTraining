
namespace FixDepositCoreLib.Model
{
    public delegate double DCalculateRate();
    public interface IRatePolicy
    {
         double CalculateRate();
    }
}
