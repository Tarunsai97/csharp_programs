using System;

namespace ArrayOp{
    class ArrayOp{
        public static void Main(string[] args){
            Console.Write("Enter the Length : ");
            int len = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the numbers : ");
            int value = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[len];
            for(int i=0;i<=len-1;i++){
                numbers[i] = value * i;
            }
            
            foreach(int n in numbers){
                Console.Write($"{n} ");
            }
        }
    }
}
