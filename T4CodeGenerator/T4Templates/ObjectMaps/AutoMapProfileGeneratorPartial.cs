using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace T4CodeGenerator.T4Templates.ObjectMaps
{
    public partial class AutoMapProfileGenerator
    {
        private readonly List<Type> _modelTypes;
        private readonly string _assemblyName;

        public AutoMapProfileGenerator(List<Type> modelTypes)
        {
            _modelTypes = modelTypes;
            _assemblyName = Assembly.GetEntryAssembly().GetName().Name;

        }
    }
}
