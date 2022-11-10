using Namotion.Reflection;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace T4CodeGenerator.Extensions
{
    public static class GeneratorCodeExtensions
    {
        public static string ToCodeStringIgnoreNullable(this ContextualType @this)
        {
            if (@this.GenericArguments.Length > 0)
            {
                var innerCode = string.Join(',', @this.GenericArguments.Select(e => e.ToCodeString()));
                return $"{@this.Type.Name.Remove(@this.Type.Name.Length - 2, 2)}<{innerCode}>";
            }
            return @this.Type.Name;
        }
        public static string ToCodeString(this ContextualType @this)
        {
            if (@this.Nullability == Nullability.Nullable)
            {
                return $"{@this.ToCodeStringIgnoreNullable()}?";
            }
            if (@this.GenericArguments.Length > 0)
            {
                var innerCode = string.Join(',', @this.GenericArguments.Select(e => e.ToCodeString()));
                return $"{@this.Type.Name.Remove(@this.Type.Name.Length - 2, 2)}<{innerCode}>";
            }
            return @this.Type.Name;

        }
        public static IEnumerable<ContextualPropertyInfo> ToDtoPropertyInfos(this IEnumerable<ContextualPropertyInfo> @this)
        {
            return @this;
        }
        public static IEnumerable<ContextualPropertyInfo> ToCreateDtoPropertyInfos(this IEnumerable<ContextualPropertyInfo> @this)
        {
            return @this.Where(e => e.Name != "Id");
        }
        public static IEnumerable<ContextualPropertyInfo> ToUpdateDtoPropertyInfos(this IEnumerable<ContextualPropertyInfo> @this)
        {
            return @this;
        }

    }
}
