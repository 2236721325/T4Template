using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace T4CodeGenerator.Utilities
{
    public enum ProjectTypeEnum
    {
        WebApi,
        Console
    }
    public class Tool
    {
        public static bool AcceptUpdate = false;
        public static ProjectTypeEnum? ProjectType { get; set; }
        //不同类型的 项目获取的地址不同 这个是获取控制台项目的项目文件夹。
        public static string GetProjectPath()
        {
            if (ProjectType == null) throw new NullReferenceException();
            switch (ProjectType)
            {
                case ProjectTypeEnum.WebApi:
                    return new DirectoryInfo(Directory.GetCurrentDirectory()).FullName;
                    
                case ProjectTypeEnum.Console:
                    return new DirectoryInfo(Directory.GetCurrentDirectory())
                           .Parent.Parent.Parent.FullName;
                default:
                    throw new ArgumentException();
            }
          
        }
        //获取所有的程序集（有缺陷）
        public static IEnumerable<Type> GetAllTypes()
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            var types = assemblies.SelectMany(e => e.GetTypes());
            return types;
        }
        //public static Assembly GetAssemble()
        //{
        //    var a = Assembly.GetCallingAssembly();
        //    var b = Assembly.GetEntryAssembly();
        //    var c = Assembly.GetExecutingAssembly();
        //    return a;

        //}
    }
}
