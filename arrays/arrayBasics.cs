using System;

namespace Arrayop{
    class ArrayBasics{
        public static void Main(string[] args){
            int[] numbers = new int[3];
            Console.WriteLine("Enter Numbers :");
            for(int i=0;i<numbers.Length;i++){
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            foreach (int num in numbers){
                Console.Write($"{num} ");
            }
        }
    }
}
