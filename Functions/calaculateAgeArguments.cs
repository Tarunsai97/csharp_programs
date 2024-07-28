using System;

namespace FunctionParam{
    class Fun{
        public static void Main(string[] args){
            Console.Write("Enter your name : ");
            string name = getInfoFromConsole();
            Console.WriteLine(name);
            Console.Write("Enter current Year :");
            int currentYear = Convert.ToInt32(getInfoFromConsole());
            Console.Write("Enter birth year :");
            int birthYear = Convert.ToInt32(getInfoFromConsole());
            int age = calCulateAge(currentYear,birthYear);
            Console.WriteLine($"Your name is {name} and age is {age}");
        }
        
        public static string getInfoFromConsole(){
            string something = Console.ReadLine();
            return something;
        }
        
        public static int calCulateAge(int currentYear, int birthYear){
            return currentYear-birthYear;
        }
    }
}
