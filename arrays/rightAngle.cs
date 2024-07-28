using System;

namespace ArrayOp{
    class RightAngleOrNot{
        public static void Main(string[] args){
            int[] angles = new int[3];
            int sum = 0;
            Console.WriteLine("Enter angles :");
            for(int i=0;i<angles.Length;i++){
                angles[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            foreach(int num in angles){
                sum = sum+num;
            }
            if(sum == 180){
                Console.WriteLine("valid !");
            } else{
                Console.WriteLine("Invalid !");
            }
        }
    }
}
