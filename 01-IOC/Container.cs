using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_IOC.Service.IService
{
    public class Container
    {
        private readonly Dictionary<Type, Type> _registrations = new();

        public void Register<TInterface, TImplementation>()
        {
            _registrations[typeof(TInterface)] = typeof(TImplementation);
        }

        public TInterface Resolve<TInterface>()
        {
            var implType = _registrations[typeof(TInterface)];
            return (TInterface)Activator.CreateInstance(implType)!;
        }
    }
}
