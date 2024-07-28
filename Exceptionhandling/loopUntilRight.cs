using System;

namespace Exceptionhandling{
    
    class Exceptions{
        public static void Main(string[] args){
        bool looping = true;
        while(looping){
        try{
            Console.Write("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            looping = false;
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
        }
        Console.WriteLine("GoodBye");
        }
    }
}
