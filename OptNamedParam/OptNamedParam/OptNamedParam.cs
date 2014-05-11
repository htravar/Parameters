using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   class LearningParameters
   {
      //an example of optional and named parameters working together
      public static void LearnOptional(int one, int two = 5, int three = 100)
      {
         Console.WriteLine("The first parameter is required; the last two are optional.");
         Console.WriteLine("The value for the first parameter is: {0}", one);
         Console.WriteLine("The value for the second parameter is: {0}", two);
         Console.WriteLine("The value for the third parameter is: {0}", three);
         Console.WriteLine();
      }

      //when I call this method, I don't name the parameter to show how the arguments are evaluated
      public static void LearnOptional2(int one, int two = 5, int three = 100)
      {
         Console.WriteLine("What happens when you don't name the parameter:");
         Console.WriteLine("Parameter \"two\" gets the value of 67 that was intended for parameter \"three\".");
         Console.WriteLine("The value for the first parameter is: {0}", one);
         Console.WriteLine("The value for the second parameter is: {0}", two);
         Console.WriteLine("The value for the third parameter is: {0}", three);
         Console.WriteLine();
      }

      //an example of optional and named parameters working together
      public static void LearnOrder(int one, int two = 5, int three = 100, int four = 99)
      {
         Console.WriteLine("As long as the required argument is first,");  
         Console.WriteLine("arguments for the named parameters can come in any order.");
         Console.WriteLine("The value for the first parameter is: {0}", one);
         Console.WriteLine("The value for the second parameter is: {0}", two);
         Console.WriteLine("The value for the third parameter is: {0}", three);
         Console.WriteLine("The value for the fourth parameter is: {0}", four);
      }

      static void Main(string[] args)
      {
         LearnOptional(44, three: 67);//using default value for parameter "two"
         LearnOptional2(44, 67);//what happens when you don't name the optional parameter
         LearnOrder(44, three: 6, four: 999, two: 2);//named parameters out of order
         
         Console.ReadKey();
      }
   }

