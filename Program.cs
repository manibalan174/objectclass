using System;

namespace StaticFunction1
{
     class Program
    {

        public   enum  Seson  {
            Winter=10,
            Spring,
            Summer,
            Atoumn,
            Fall
        };
         public enum fruits { Apple , Orange, Moango, JackFruits };
        public static void EnumTraversNames()
        {
               foreach (string frt in Enum.GetNames(typeof(fruits)))  
                 {  
                     Console.WriteLine(frt);  
                 } 

        }
         public static void EnumTraversValues()
        {
               foreach (fruits frt in Enum.GetValues(typeof(fruits)))  
                 {  
                     Console.WriteLine(frt);  
                 } 

        }
           
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int Sesons1 =(int) Seson.Winter;
            int Sesons2 =(int) Seson.Spring;
            int Sesons3 = (int)Seson.Summer;
            Console.WriteLine("Sesond  = {0} \n Sesons = {1} \n Sesons = {2}",Sesons1,Sesons2 ,Sesons3 );
             EnumTraversNames();
             EnumTraversValues();

        }
    }

}
