using System;

namespace NoAdd{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("This Program will, given two numbers, add them without using an addition operator." + "\n");
            Program.GetNoAddFunction();
        }

        // Using Subtraction Operator
        public static int addMethodOne(int a, int b)
        {
            return a-(-b);
        }

        // Repeated Addition/Subtraction Using --/++ Operator
        public static int addMethodTwo(int a, int b)
        {
            // To handle positive 'a'
            while (a > 0)
            {
                b++;
                a--;
            }

            // To handle negative 'a'
            while (a < 0)
            {
                b--;
                a++;
            }

            return b;

        }

         // Using Logarithm And Exponential Function
        public static double addMethodFour(double a, double b)
        {
            return Math.Log(Math.Exp(a) * Math.Exp(b));
        }

        public static void GetNoAddFunction()
        {
            // Prompt user to enter the first number
            Console.WriteLine("Please Enter A Number: ");
            string inputOne = Console.ReadLine();
            char[] addNumOne = inputOne.ToCharArray();
            int a;
            for(int i = 0; i < addNumOne.Length; i++) {
                if(!Char.IsLetterOrDigit(addNumOne[i])){
                  Console.WriteLine("Your entry contains special characters!" + "\n" + "Hit any key to close the program, and try again.");
                  Console.ReadKey();
                  return;
                }
                if (!int.TryParse(inputOne, out a)) {
                    Console.WriteLine("That's not a number!");
                    Console.WriteLine("You are an Ape." + "\n" + "Hit any key to close the program, and try again.");
                    Console.ReadKey();
                    return;
                } else if (string.IsNullOrWhiteSpace(inputOne)) {
                    Console.WriteLine("You didn't type anything!" + "\n" + "Hit any key to close the program, and try again.");
                    Console.ReadKey();
                    return;
                }   
            }

            // Prompt user to enter the second number
            Console.WriteLine("Please Enter A Second Number: ");
            string inputTwo = Console.ReadLine();
            char[] addNumTwo = inputTwo.ToCharArray();
            int b;
            for(int j = 0; j < addNumTwo.Length; j++) {
                if(!Char.IsLetterOrDigit(addNumTwo[j])){
                Console.WriteLine("Your entry contains special characters!" + "\n" + "Hit any key to close the program, and try again.");
                Console.ReadKey();
                return;
                }
            }
            if (!int.TryParse(inputTwo, out b)){
                Console.WriteLine("That's not a number!");  
            } else if (string.IsNullOrWhiteSpace(inputTwo)) {
                    Console.WriteLine("You didn't type anything!" + "\n" + "Hit any key to close the program, and try again.");
                    Console.ReadKey();
                    return;
                } 
                    
            if(int.TryParse(inputOne, out a) && int.TryParse(inputTwo, out b)){
                Console.WriteLine("Sum is: " + Program.addMethodOne(a, b) + "\n");
            }
            else {
                Console.WriteLine("You are an Ape." + "\n" + "Hit any key to close the program, and try again.");
                Console.ReadKey();
                return;
            }
        }
    }
}