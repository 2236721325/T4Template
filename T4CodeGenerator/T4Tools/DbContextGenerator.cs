using System;
using System.IO;
using System.Linq;
using T4CodeGenerator.T4Templates.DbContexts;
using T4CodeGenerator.T4Templates.Dtos;
using T4CodeGenerator.Utilities;

namespace T4CodeGenerator.T4Tools
{
    public class DbContextGenerator
    {
        public static void GeneratorEFContext(Type targetType)
        {
            var types = Tool.GetAllTypes()

               .Where(type => type.BaseType != null
               && type.BaseType.IsGenericType
               && type.BaseType.GetGenericTypeDefinition() == targetType)
               .ToList();


            var projPath = Tool.GetProjectPath();
            var datasPath = Path.Combine(projPath, "Datas");
            if (!Directory.Exists(datasPath))
            {
                Directory.CreateDirectory(datasPath);
            }
            var generatorCsfile = Path.Combine(datasPath, $"MyDbContext.cs");
            var generator = new EFDbContextGenerator(types);
            File.WriteAllText(generatorCsfile, generator.TransformText());

        }
    }

}
