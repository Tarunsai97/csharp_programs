using System;
using System.Threading;

namespace StringOps{
    class StringRev{
        public static void Main(string[] args){
            Console.WriteLine("Enter the message :");
            var msg = Console.ReadLine();
            
            for(int i=0;i<msg.Length;i++){
                Console.Write(msg[i]);
                Thread.Sleep(250);
            }
                Console.WriteLine();
            for(int i = msg.Length-1; i >= 0; i--){
                
                Console.Write(msg[i]);
                Thread.Sleep(250);
            }
        }
    }
}
