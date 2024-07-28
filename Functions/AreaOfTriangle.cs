using System;

namespace FunctionOp{
    class AreaOfTriangle{
        public static void Main(string[] args){
          Console.Write("Enter the height of the triangle : ");
          var height = Convert.ToSingle(Console.ReadLine());
          Console.Write("Enter the width of the triangle : ");      
          var width = Convert.ToSingle(Console.ReadLine());
          float area = areaOfTriangle(height,width);
          Console.WriteLine($"Area of triangle is : {area}");
          
        }
        
        public static float areaOfTriangle(float height, float width){
            return (height * width)/2;
        }
        
    }
}
