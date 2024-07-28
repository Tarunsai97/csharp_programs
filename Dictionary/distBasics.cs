using System;
using System.Collections.Generic;

namespace Dictinory{
    class Program{
        public static void  Main(string[] args){
            Dictionary<int,string> names = new Dictionary<int, string> {
                {1,"Tarun"},
                {2, "Sai"},
                {3, "kiran"}
            };
            
            for(int i=1;i<=3; i++){
                Console.WriteLine($"{names[i]}");
            }
            
        }
    }
}
