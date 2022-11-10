using Namotion.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using T4CodeGenerator.Extensions;

namespace T4CodeGenerator.T4Templates.Dtos
{
    public partial class BaseDtoGenerator
    {
        private readonly Type _type;
        private readonly List<ContextualPropertyInfo> _propertyInfos;
        private readonly string _assemblyName;
        public BaseDtoGenerator(Type type)
        {
            _type = type;
            _propertyInfos = type.GetContextualProperties().ToList();
            //foreach (var item in _propertyInfos)
            //{
            //    item.PropertyType.ToCodeString();
            //}
           
            _assemblyName = Assembly.GetEntryAssembly().GetName().Name;
        }
    }
}
