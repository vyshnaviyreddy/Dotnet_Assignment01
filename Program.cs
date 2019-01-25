using System;

namespace Vyshnavi_Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
           var c = 'q';
            var n = 1;
            var doub = 0.0;
            var U_rate= 71.05m;
            var I_rate = 0.014m;
            var r = 0.0m;
            var b = true;
            var name = String.Empty;
            Console.WriteLine("Welcome to Currency Converter!\nEnter your name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter any button to continue, 'q' to quit !");
            var ch=Console.ReadLine();
            c = Convert.ToChar(ch);
            if(c=='q'){
                Console.WriteLine($"Thank You {name}!");
            }
            else
            {
                while(b){
                Console.WriteLine($"Enter {n} to convert from USD to INR. ");
                Console.WriteLine($"Enter {n+1} to convert from INR to USD.");
                var i = Console.ReadLine();
                var num = Convert.ToInt32(i);
                
                switch (num)
                {
                    case 1: Console.WriteLine("Enter amount in USD :");
                    var d=Console.ReadLine();
                    doub = Convert.ToDouble(d);
                    usd2inr(doub);
                    break;

                    case 2: Console.WriteLine("Enter amount in INR :");
                    var  j = Console.ReadLine();
                    doub = Convert.ToDouble(j);
                     inr2usd(doub);
                    break;

                    default: Console.WriteLine($"Sorry {name}! Invalid number.");
                    break;
                }
                
                

                void usd2inr(double u){
                    r = Convert.ToDecimal(u);
                    Console.WriteLine($"Amount in INR is {r*U_rate}.\nThank you for using my application {name}.");
                }

                void inr2usd(double k){
                    r = Convert.ToDecimal(k);
                    Console.WriteLine($"Amount in USD is {r*I_rate}.\nThank you for using my application {name}.");

                }
                b= false;
            }
            }
        }
    }
}
