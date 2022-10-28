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
        public static void GenerateCreateDto(Type targetType)
        {
            var types=Tool.GetAllTypes()

                .Where(type => type.BaseType!=null
                &&type.BaseType.IsGenericType
                &&type.BaseType.GetGenericTypeDefinition() == targetType)
                .ToList();


            var projPath = Tool.GetProjectPath();
            var dtosPath = Path.Combine(projPath, "Dtos");
            if (!Directory.Exists(dtosPath))
            {
                Directory.CreateDirectory(dtosPath);
            }
            foreach (var type in types)
            {
                var typePath= Path.Combine(dtosPath, $"{type.Name}Dtos");
                if (!Directory.Exists(typePath))
                {
                    Directory.CreateDirectory(typePath);
                }
                var generatorCsfile = Path.Combine(typePath, $"{type.Name}CreateDto.cs");
                var generator = new CreateDtoGenerator(type);
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
        public static void GenerateUpdateDto(Type targetType)
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
                var typePath = Path.Combine(dtosPath, $"{type.Name}Dtos");
                if (!Directory.Exists(typePath))
                {
                    Directory.CreateDirectory(typePath);
                }

                var generatorCsfile = Path.Combine(typePath, $"{type.Name}UpdateDto.cs");
                var generator = new UpdateDtoGenerator(type);
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
        public static void GenerateBaseDto(Type targetType)
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
                var typePath = Path.Combine(dtosPath, $"{type.Name}Dtos");
                if (!Directory.Exists(typePath))
                {
                    Directory.CreateDirectory(typePath);
                }
                var generatorCsfile = Path.Combine(typePath, $"{type.Name}Dto.cs");
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
            GenerateBaseDto(targetType);
            GenerateCreateDto(targetType);
            GenerateUpdateDto(targetType);
        }
    }

}


