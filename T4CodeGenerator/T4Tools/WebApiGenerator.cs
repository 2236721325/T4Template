using System;
using System.Collections.Generic;
using System.Text;
using T4CodeGenerator.Utilities;

namespace T4CodeGenerator.T4Tools
{
    public class WebApiGenerator
    {
        public static void GenerateSingelProjectEFCoreWebApi(Type targetType)
        {
            Tool.ProjectType = ProjectTypeEnum.WebApi;
            DtoGenerator.GenerateAllDtos(targetType);
            DbContextGenerator.GeneratorEFContext(targetType);
            BaseServiceGenerator.GeneratorIService(targetType);
            BaseServiceGenerator.GeneratorEFCoreService(targetType);
            ControllerGenerator.GeneratorCrudController(targetType);
            ObjectMapGenerator.GeneratorAutoMapProfile(targetType);
        }
        public static void GenerateSingelProjectFreeSqlWebApi(Type targetType)
        {
            Tool.ProjectType = ProjectTypeEnum.WebApi;
            DtoGenerator.GenerateAllDtos(targetType);
            BaseServiceGenerator.GeneratorIService(targetType);
            BaseServiceGenerator.GeneratorFreeSqlService(targetType);
            ControllerGenerator.GeneratorCrudController(targetType);
            ObjectMapGenerator.GeneratorAutoMapProfile(targetType);
        }
    }
}
