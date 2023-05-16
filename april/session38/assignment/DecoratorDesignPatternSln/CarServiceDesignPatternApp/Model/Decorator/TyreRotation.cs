using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceDesignPatternApp.Model.Decorator
{
    internal class TyreRotation:ICarService
    {
        private readonly ICarService _service;

        public TyreRotation(ICarService service)
        {
            _service = service;
        }

        public double GetCost()
        {
            return 350 + _service.GetCost();
        }

        public string GetDetails()
        {
            return _service.GetDetails() + ", Tyre Rotation";
        }
    }
}
