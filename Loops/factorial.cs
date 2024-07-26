using System;


namespace Loops
{
    class Loop
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number know the factorial : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = 1;

            for(int i = num; i > 1; i--)
            {
                fact = fact * i;
            }
            Console.Write(fact);

            Console.ReadLine();
        }
    }
}
