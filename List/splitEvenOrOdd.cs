using System;
using System.Collections.Generic;

namespace ListOp{
    class OddOrEvenSplit{
        public static void Main(string[] args){
        List<int> evenList = new List<int>();
        List<int> oddList = new List<int>();
        
        for(int i =1; i<=20; i++){
            if(i%2 == 0){
                evenList.Add(i);
            }
            else{
                oddList.Add(i);
            }
        }
        foreach(int num in evenList){
            Console.Write($"{num} ");
        }
        Console.WriteLine();
        foreach(int num in oddList){
            Console.Write($"{num} ");
        }
        }
    }
}
