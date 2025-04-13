using System;
using System.Reflection;

namespace MyApp
{
    internal class Reflection
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.LoadFrom(@"Tutorial-Reflection/PrintAll/bin/Debug/net9.0/PrintAll.dll");

            foreach (var type in assembly.GetTypes())  
            {
                Console.WriteLine($"Type: {type.Name}");
                Console.WriteLine("------------------");
                var instance = Activator.CreateInstance(type)

                foreach (var field in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly))
                {
                     Console.WriteLine($"Field: {field.Name}");
                    //  field.SetValue(instance, "Frdo")
                }
                 Console.WriteLine("------------------");

                 foreach (var methods in type.GetMethods(BindingFlags.Public |BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly).Where(m => m.IsSpecialName))
                 {
                    Console.WriteLine($"Methods: {methods.Name}");
                    if(method.GetParameters().length > 0)
                    {
                        method.Invoke(instance, new[] {'Biblo'})
                    }
                    else if(method.ReturnType.Name != "Void")
                    {
                        var returnedValue = methods.Invoke(instance, null);
                        Console.WriteLine($"Returned valur form method: {returnedValue}");
                    }
                    else{
                         methods.Invoke(instance, null);
                    }
                   
                 }
                  Console.WriteLine("------------------");
                  foreach (var property in type.GetProperties())
                  {
                    Console.WriteLine($"Property: {property.Name}");
                    var propertyValue = property.GetValue(instance);
                    Console.WriteLine($"Property Value: {propertyValue}");
                  }
            }
        }
    }
}