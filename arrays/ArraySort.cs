using System;


namespace ArrayOp{
    class ArrayFunc{
        public static void Main(string[] args){
            int[] numbers = new int[] {
                5,6,7,3,1
            };
            Array.Sort(numbers);
            foreach(int num in numbers){
                Console.Write($"{num} ");
            }
            
        }
    }
}
