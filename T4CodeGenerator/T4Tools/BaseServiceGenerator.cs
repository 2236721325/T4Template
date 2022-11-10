using System;
using System.IO;
using System.Linq;
using T4CodeGenerator.T4Templates.Services;
using T4CodeGenerator.Utilities;

namespace T4CodeGenerator.T4Tools
{
    public class BaseServiceGenerator
    {
        public static void GeneratorIService(Type targetType)
        {
            var types = Tool.GetAllTypes()

               .Where(type => type.BaseType != null
               && type.BaseType.IsGenericType
               && type.BaseType.GetGenericTypeDefinition() == targetType)
               .ToList();


            var projPath = Tool.GetProjectPath();
            var servicePath = Path.Combine(projPath, "IServices");
            if (!Directory.Exists(servicePath))
            {
                Directory.CreateDirectory(servicePath);
            }
            foreach (var type in types)
            {
                var generatorCsfile = Path.Combine(servicePath, $"I{type.Name}Service.cs");
                var generator = new IServiceGenerator(type);
                if (File.Exists(generatorCsfile))
                {
                    if (Tool.AcceptUpdate)
                    {

                        File.WriteAllText(generatorCsfile, generator.TransformText());

                    }
                    continue;
                }
                File.WriteAllText(generatorCsfile, generator.TransformText());
            }
           

        }
        public static void GeneratorEFCoreService(Type targetType)
        {
            var types = Tool.GetAllTypes()

               .Where(type => type.BaseType != null
               && type.BaseType.IsGenericType
               && type.BaseType.GetGenericTypeDefinition() == targetType)
               .ToList();


            var projPath = Tool.GetProjectPath();
            var servicePath = Path.Combine(projPath, "Services");
            if (!Directory.Exists(servicePath))
            {
                Directory.CreateDirectory(servicePath);
            }
            foreach (var type in types)
            {
                var generatorCsfile = Path.Combine(servicePath, $"{type.Name}Service.cs");
                var generator = new ServiceGenerator(type);
                if (File.Exists(generatorCsfile))
                {
                    if (Tool.AcceptUpdate)
                    {

                        File.WriteAllText(generatorCsfile, generator.TransformText());

                    }
                    continue;
                }
                File.WriteAllText(generatorCsfile, generator.TransformText());
            }


        }
        public static void GeneratorFreeSqlService(Type targetType)
        {
            var types = Tool.GetAllTypes()

             .Where(type => type.BaseType != null
             && type.BaseType.IsGenericType
             && type.BaseType.GetGenericTypeDefinition() == targetType)
             .ToList();


            var projPath = Tool.GetProjectPath();
            var servicePath = Path.Combine(projPath, "Services");
            if (!Directory.Exists(servicePath))
            {
                Directory.CreateDirectory(servicePath);
            }
            foreach (var type in types)
            {
                var generatorCsfile = Path.Combine(servicePath, $"{type.Name}Service.cs");
                var generator = new FreeSqlServiceGenerator(type);
                if (File.Exists(generatorCsfile))
                {
                    if (Tool.AcceptUpdate)
                    {

                        File.WriteAllText(generatorCsfile, generator.TransformText());

                    }
                    continue;
                }
                File.WriteAllText(generatorCsfile, generator.TransformText());
            }

        }
    }

}
