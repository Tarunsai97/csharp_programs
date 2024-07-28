using System;

namespace Exceptionhandling{
    class Exceptions{
        public static void Main(string[] args){
        try{
            Console.Write("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException){
            Console.WriteLine("Enter only Integers");
        }
        
        catch (OverflowException){
            Console.WriteLine("Enter less than 2 Billion");
        }
        
        catch( Exception){
            Console.WriteLine("Something went Wrong");
        }
        
        Console.WriteLine("GoodBye");
        }
    }
}
