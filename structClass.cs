using System;

namespace StructConcept
{


public struct Sum
{
     int Sum1;
     int Sum2;
     public  Sum(int Sum1, int Sum2)
     {
         this.Sum1 = Sum1;
         this.Sum2 = Sum2;
          
     }
     public void display()
     {
         int Add = Sum1 + Sum2;
         Console.WriteLine("Add VAlues : "+Add);
     }
     static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Sum S = new Sum(12,13);
            //S.Sum(12,13);
            S.display();
        }
}
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         Console.WriteLine("Hello World!");
    //     }
    // }
}
