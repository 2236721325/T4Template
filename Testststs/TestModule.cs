using Autofac;
using Base.Shared;
using System.Reflection;
using Module = Autofac.Module;

namespace Testststs
{
    public class TestModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var baseType = typeof(ITransientDependency);
            var assembly = Assembly.GetEntryAssembly();
            if (assembly == null) throw new ArgumentException("无法找到入口程序集");

            builder.RegisterAssemblyTypes(assembly)
                            .Where(t => baseType.IsAssignableFrom(t) && t != baseType)
                            .AsImplementedInterfaces();

        }
    }
}
