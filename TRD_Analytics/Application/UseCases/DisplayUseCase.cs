using System.Reflection;

namespace TRD_Analytics.Application;

public class DisplayUseCase
{
    public void execute<T>(List<T> inputs)
    where T : class
    {
        if (inputs == null) return;
        
        PropertyInfo[] properties = typeof(T).GetProperties();

        foreach (PropertyInfo property in properties)
        {
            string name = property.Name;
            
            Console.Write($"{name}\t|");
        }
        Console.WriteLine();
        foreach (var input in inputs)
        {
            foreach (PropertyInfo property in properties)
            {
                string name = property.Name;
                object value = property.GetValue(input) ?? "null";
            
                Console.Write($"{value, -25}");
            }
            Console.WriteLine();
        }
        
        Console.WriteLine($"\n Total Displayed Element : {inputs.Count()}");

    }
}