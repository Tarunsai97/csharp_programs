using System;

namespace FunctionOp{
    class SumOfArray{
        public static void Main(string[] args){
            int[] array = new int[5]{1,2,3,4,5};
            int sum = 0;
            sumOfArray(array, out sum);
            Console.WriteLine(sum);
            
        }
        
        public static void sumOfArray(int[] numbers,out int sum){
            sum = 0;
            for(int i = 0; i< numbers.Length; i++){
                sum = sum + numbers[i];
            }
        }
    }
}
