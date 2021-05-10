using System;

namespace clobj1
{
    class Program
    {

      public int sumValue;
      public int sumValues1;
        public Program()
        {
             Console.WriteLine("This is Default Constrctor");
        }
          public Program(int sum1, int sum2)
        {
                sumValue = sum1;
                sumValues1 = sum2;
        // Console.WriteLine(sum1 + "" + sum2);
        }
        public void Add()
        {

          Console.WriteLine(sumValue+""+sumValues1);
            // int addValue =  sumValues + sumValues1;
            // int addValue1 = sumValues - sumValues1;
            // int addValue2 = sumValues * sumValues1;
            // int addValue3 = sumValues / sumValues1;
            // int addValue4 = sumValues % sumValues1;
            // Console.WriteLine("Add Value : "+addValue);
            // Console.WriteLine("Subraction Value : "+addValue1);
            // Console.WriteLine("Multiplication Value : "+addValue2);
            // Console.WriteLine("Division Value : "+addValue3);
            // Console.WriteLine("Modulo Value : "+addValue4);
        }
       
    }
    public class TestEmployee{
     public static void Main(string[] args)
        {
            Console.WriteLine("Constructors");
           Console.Write("Enter Values 1 : ");
           int s1=Convert.ToInt32( Console.ReadLine() );
            Console.Write("Enter Values 2 : ");
           int s2=Convert.ToInt32( Console.ReadLine() );
            Program P = new Program();
           Program P1 = new Program(s1, s2);
           P1.Add();
        }
    }

}
