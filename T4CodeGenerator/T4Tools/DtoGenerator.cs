using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using T4CodeGenerator.T4Templates;
using T4CodeGenerator.T4Templates.DbContexts;
using T4CodeGenerator.T4Templates.Dtos;
using T4CodeGenerator.Utilities;

namespace T4CodeGenerator.T4Tools
{
    public class DtoGenerator
    {
 
        public static void GenerateDtos(Type targetType)
        {
            var types = Tool.GetAllTypes()

                .Where(type => type.BaseType != null
                && type.BaseType.IsGenericType
                && type.BaseType.GetGenericTypeDefinition() == targetType)
                .ToList();


            var projPath = Tool.GetProjectPath();
            var dtosPath = Path.Combine(projPath, "Dtos");
            if (!Directory.Exists(dtosPath))
            {
                Directory.CreateDirectory(dtosPath);
            }
            foreach (var type in types)
            {
   
                var generatorCsfile = Path.Combine(dtosPath, $"{type.Name}Dto.cs");
                var generator = new BaseDtoGenerator(type);
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
        public static void GenerateAllDtos(Type targetType)
        {
            GenerateDtos(targetType);
        }
    }

}


