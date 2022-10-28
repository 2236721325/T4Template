using System;
using System.IO;
using System.Linq;
using T4CodeGenerator.T4Templates.ObjectMaps;
using T4CodeGenerator.Utilities;

namespace T4CodeGenerator.T4Tools
{
    public class ObjectMapGenerator
    {
        public static void GeneratorAutoMapProfile(Type targetType)
        {
            var types = Tool.GetAllTypes()

               .Where(type => type.BaseType != null
               && type.BaseType.IsGenericType
               && type.BaseType.GetGenericTypeDefinition() == targetType)
               .ToList();


            var projPath = Tool.GetProjectPath();
            var datasPath = Path.Combine(projPath, "ObjectMappers");
            if (!Directory.Exists(datasPath))
            {
                Directory.CreateDirectory(datasPath);
            }
            var generatorCsfile = Path.Combine(datasPath, $"CustomProfile.cs");
            var generator = new AutoMapProfileGenerator(types);
            if (File.Exists(generatorCsfile))
            {
                if (Tool.AcceptUpdate)
                {

                    File.WriteAllText(generatorCsfile, generator.TransformText());

                }
                return;
            }
            File.WriteAllText(generatorCsfile, generator.TransformText());

        }
    }

}


