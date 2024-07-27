using System;

namespace StringInterpolation{
    class StringInterpol{
        public static void Main(string[] args){
            Console.WriteLine("Enter the name and age");
            string name = Console.ReadLine();
            string age =  Console.ReadLine();
            
            Console.WriteLine($"your name is {name} and your age is {age}");
        }
    }
}
