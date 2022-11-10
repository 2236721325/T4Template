using Namotion.Reflection;
using System.Reflection;
using T4CodeGenerator.Extensions;

namespace ConsoleTest
{
    public class Person
    {
        /// <summary>
        /// Gets or sets the optional middle name.
        /// </summary>
        //public string? MiddleName { get; set; }
        public List<List<int?>?> Hellos { get; set; }
        //public int? MyInt { get; set; }


    }

    class Program
    {
        static void Main(string[] args)
        {
            var properties = typeof(Person)
                .GetContextualProperties();


            foreach (var property in properties)
            {
                Console.WriteLine(property.PropertyType.ToCodeString());
            }

        }

    }
}

