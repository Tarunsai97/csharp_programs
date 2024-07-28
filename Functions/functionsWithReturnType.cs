using System;


namespace Functions{
    class Fun{
        public static void Main(string[] args){
            Console.WriteLine($"Your name is {getAge()} and you are age is {getName()}");
        }
        
        public static int getAge(){
            return 23;
        }
        
        public static string getName(){
            return "Tarun";
        }
    }
}
