using System;

namespace StringOp{
    class PasswordChecker{
        public static void Main(string[] args){
                Console.Write("Enter the Password : ");
        var new_pass = Console.ReadLine();
        Console.Write("Confirm the password : ");
        var con_pass = Console.ReadLine();
        if(!string.IsNullOrEmpty(new_pass) && !string.IsNullOrEmpty(new_pass)){
                if(new_pass.Equals(con_pass)){
                    Console.WriteLine("Password Match");
                }
                else{
                    Console.WriteLine("Password Doesn't Match");
                }
            
        }
        else{
            Console.WriteLine("Passwords can't be null or empty");
        }
        }
    
    }
}
