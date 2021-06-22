using System;
using System.Collections.Generic;


namespace csharp_intro
{
    class Program
    {



        public static void PrintInfoOfStore(Store store){

            Console.WriteLine($"The name of the store is: {store.Name} and is has {store.TotalEmployees} employes and sells {store.Speciality}");

             
            foreach (var item in store.Items)
                 {
                     Console.WriteLine($" is has products : {item}");
                 }

            if (store.IsOpen)
            {
                Console.WriteLine("Store is open");
            }else
            {
                Console.WriteLine("Store is Closed");
            }
        }

        public static string ReturnsNameLargestRevenue(Store[] store){
            
            int LargestRevenue = 0;
            Store Largest = null;
            foreach (var item in store)
            {
                if(item.Revenue > LargestRevenue){
                    LargestRevenue = item.Revenue;
                    Largest = item;

                }
            }

            return Largest.Name;
        }

        
        static void Main(string[] args)
        {
            ShoeStore TimsShoes = new ShoeStore("Tims Shoes", true);
            FoodStore Jims = new FoodStore("Jims", false, "John Johnsen");
            ElectronicStore Pauls = new ElectronicStore("Pauls", true);
            Store[] storeArray = {TimsShoes, Jims, Pauls};

            PrintInfoOfStore(TimsShoes);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------");
            PrintInfoOfStore(Jims);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------");
            PrintInfoOfStore(Pauls);
           
            var largest = ReturnsNameLargestRevenue(storeArray);

             Console.WriteLine(largest);

        }
    }
}
