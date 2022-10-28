using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace T4CodeGenerator.T4Templates.Services
{
    public partial class ServiceGenerator
    {
        private readonly Type _type;
        private readonly PropertyInfo _idproperty;
        private readonly string _assemblyName;

        public ServiceGenerator(Type type)
        {
            _type = type;
            _idproperty = _type.GetProperties()
                .Where(t => t.Name == "Id").First();
            _assemblyName = Assembly.GetEntryAssembly().GetName().Name;


        }
    }
}
