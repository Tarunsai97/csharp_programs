using System;


namespace StringFormatting{
    class Formatting{
        public static void Main(string[] args){
            string name = Console.ReadLine();
            string age = Console.ReadLine();
            
            Console.WriteLine("Your name is "+ name + " Your age is "+ age );
            Console.WriteLine("Your name is {0} and your age is {1}", name,age);
        }
    }
}
