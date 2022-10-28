using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System.Text;
using System.Reflection;
using System.Diagnostics;
using T4Template.Models;
using T4CodeGenerator.T4Tools;
using T4CodeGenerator.Utilities;
using Base.Shared.Domains;

namespace T4Template
{
    internal class Program
    {
        static void Test()
        {
            //var assembly = Assembly.GetExecutingAssembly();
            //var targetType=typeof(BaseEntityAsync<,>);
            //var types = assembly.GetTypes()
            //    .Where(type => type.BaseType.IsGenericType 
            //    && type.BaseType.GetGenericTypeDefinition()==typeof(BaseEntity<,>) )
            //    .ToList();
            //foreach (var type in types)
            //{
            //    Console.WriteLine(type.Name);
            //}
            //DtoGenerator.GenerateCreateDto(typeof(BaseEntityAsync<,>));
            //DtoGenerator.GenerateUpdateDto(typeof(BaseEntityAsync<,>));
            //DtoGenerator.GenerateBaseDto(typeof(BaseEntityAsync<,>));
            Tool.ProjectType = ProjectTypeEnum.Console;
            DtoGenerator.GenerateAllDtos(typeof(BaseEntity<>));
            DbContextGenerator.GeneratorEFContext(typeof(BaseEntity<>));
            BaseServiceGenerator.GeneratorIService(typeof(BaseEntity<>));
            BaseServiceGenerator.GeneratorService(typeof(BaseEntity<>));
            ControllerGenerator.GeneratorCrudController(typeof(BaseEntity<>));
            ObjectMapGenerator.GeneratorAutoMapProfile(typeof(BaseEntity<>));


        }
        static void Main(string[] args)
        {
            Test();
            //var assembly = Assembly.GetExecutingAssembly();
            //var types = assembly.GetTypes()
            //    .Where(type => type.Name.EndsWith("Controller"));
            //foreach (var type in types)
            //{
            //    var methods = type.GetMethods();
            //    var attrs = type.GetCustomAttributes();
            //    foreach (var method in methods)
            //    {
            //        Console.WriteLine(method);
            //        Console.WriteLine("{");
            //        var attributes = method.GetCustomAttributes();
            //        foreach (var attr in attributes)
            //        {
            //            Console.WriteLine(attr);
            //        }
            //        Console.WriteLine("}");

            //    }


            }



        }
    }
  
