using System;

namespace ArrayOp{
    class ArrayFun{
      public static void Main(string[] args){
        Console.WriteLine("Enter how many numbers you want to insert");
        var indexLength = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[indexLength];
        for(int i=0; i<=numbers.Length-1;i++){
            numbers[i]=Convert.ToInt32(Console.ReadLine());
        }
        Array.Sort(numbers);
        int min = numbers[0];
        int max = numbers[indexLength-1];
        Console.WriteLine($"minimum value : {min}");
        Console.WriteLine($"maximum value : {max}");
      }
    }
}
