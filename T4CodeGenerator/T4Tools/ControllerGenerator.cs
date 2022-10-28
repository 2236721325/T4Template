using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using T4CodeGenerator.T4Templates;
using T4CodeGenerator.Utilities;

namespace T4CodeGenerator.T4Tools
{
    public class ControllerGenerator
    {
        public static void GeneratorCrudController(Type targetType)
        {
            var types = Tool.GetAllTypes()

               .Where(type => type.BaseType != null
               && type.BaseType.IsGenericType
               && type.BaseType.GetGenericTypeDefinition() == targetType)
               .ToList();


            var projPath = Tool.GetProjectPath();
            var controllerPath = Path.Combine(projPath, "Controllers");
            if (!Directory.Exists(controllerPath))
            {
                Directory.CreateDirectory(controllerPath);
            }
            foreach (var type in types)
            {
                var generatorCsfile = Path.Combine(controllerPath, $"{type.Name}Controller.cs");
                var generator = new ApiControllerGenerator(type);
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
