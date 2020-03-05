using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalc {
    class Calculator {
        static void Main(string[] args) {
            int a;

            int b;

            string op;

            int answer;

            bool parseSuccess;

        //take input
        Start:
            

            Console.WriteLine("Enter your first number: ");
            parseSuccess = int.TryParse(Console.ReadLine(), out a);
            if (parseSuccess == false) {
                Console.WriteLine("Please type a valid number!");
                goto Start;
            }
            



            Console.WriteLine("Enter your second number: ");
            parseSuccess = int.TryParse(Console.ReadLine(), out b);
            if (parseSuccess == false ) {
                Console.WriteLine("Please type a valid number!");
                goto Start;
            }
            
            Start2:

            Console.WriteLine("Please enter operator ");
            op = Console.ReadLine();
        
            if (op == "+") {
                answer = a + b;
                Console.WriteLine(a + " + " + b + " = " + answer);
                Console.ReadLine();
            }
            else if (op == "/") {
                answer = a / b;
                Console.WriteLine(a + " / " + b + " = " + answer);
            }
            else if (op == "x") {
                answer = a * b;
                Console.WriteLine(a + "x" + b + "=" + answer);
            }
            else if (op == "*") {
                answer = a * b;
                Console.WriteLine(a + "x" + b + "=" + answer);
            }
            else if (op == "-") {
                answer = a - b;
                Console.WriteLine(a + "-" + b + "=" + answer);
            }
            else if (op == "reset") {
                goto Start;
            }
            else {
                Console.WriteLine("Incorrect Format. Please try again. You only need to re-enter your operator. To reset, type reset");
                goto Start2;
            }

        }

    }
}
