using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace T4CodeGenerator.T4Templates.Dtos
{
    public partial class UpdateDtoGenerator
    {
        private readonly Type _type;
        private readonly List<PropertyInfo> _propertyInfos;
        private readonly string _assemblyName;

        public UpdateDtoGenerator(Type type)
        {
            _type = type;
            _propertyInfos = type.GetProperties().ToList();
            _assemblyName = Assembly.GetEntryAssembly().GetName().Name;

        }
    }
}
