using System;
using System.Collections.Generic;


namespace csharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoeStore TimsShoes = new ShoeStore("Tims Shoes", true);
            if (TimsShoes.IsOpen)
            {
                 Console.WriteLine($"The name of the store is: {TimsShoes.Name} and is has {TimsShoes.TotalEmployees} employes and sells {TimsShoes.Speciality}");
                 foreach (var item in TimsShoes.Items)
                 {
                     Console.WriteLine($" is has products from: {item}");
                 }
            }
           
            
        }
    }
}
