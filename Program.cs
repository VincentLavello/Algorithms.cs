using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // result = Not (IsSpicy) ? "Is not Spicy" : Not (IsSweet) ? "Is not Sweet" : "Is Sweet and Spicy";
            // string result;
            // result = (!true) ? "Is not spicy" : (!true) ? "Is not sweet" : "Is sweet and spicy" ;
            // System.Console.WriteLine(result);
            // Console.WriteLine("Testing rSigma...");
            // System.Console.WriteLine(rSigma(255).ToString());
            // Console.WriteLine("Testing Factorial...");
            // System.Console.WriteLine(Factorial(255).ToString());
            
            Console.WriteLine(FibonacciAlgebraic(7).ToString());
            Console.WriteLine(FibonacciIterative(7).ToString());
            Console.WriteLine(FibonacciRecursive(7).ToString());

        }
        static public int rSigma(int n)
        {
            if (n==0  || n==1)  {
                return n;
            }
            else {
                return rSigma(n-1) + n;
        }
        }//rSigma
        static public int Factorial(int n)
        {
            if (n==0  || n==1)  {
                return n;
            }
            else {
                return rSigma(n-1) * n;
            }
        }//factorial

        static public int FibonacciRecursive(int idx) // for a 11235... seq no zero
        {
            if ( idx ==0 ) {return 0;}
            if (idx==1) {return 1;}
            return FibonacciRecursive(idx -1) + FibonacciRecursive(idx -2);

        }
        // using a iteration to build the sequence up to the idx..
        static public int FibonacciIterative(int idx) // for a 011235..
        {
            List<int> fibonacci = new List<int>();

            if ( idx ==0 ) {return 0;}
            if (idx<4) {return idx;}
                fibonacci.Add(0);
                fibonacci.Add(1);
                fibonacci.Add(1);
                fibonacci.Add(2);
                fibonacci.Add(3);

            for (int i = 5; i <idx +1; i++) 
            {
                fibonacci.Add(fibonacci[i-1] + fibonacci[i-2]);
                // Console.WriteLine("index: " + i.ToString() + " fib count: " +  fibonacci.Count.ToString() + " val: " + fibonacci[i]);
            }
            return fibonacci[idx];

        }
        // using a formula..
        static public double FibonacciAlgebraic(int idxFib) // for a 11235... seq no zero
        {
            double fibVal;
            fibVal=((Math.Pow(((1+Math.Sqrt(5))/2),idxFib)  - Math.Pow(((1-Math.Sqrt(5))/2), idxFib)) / Math.Sqrt(5));
            return fibVal;

        } 
    }
}
// F I B O N A C C I   R E F E R E N C E S 
             // /https://www.math.hmc.edu/funfacts/ffiles/10002.4-5.shtml
            // an = [ Phi^n - (phi)^n ]/Sqrt[5].

            //where Phi=(1+Sqrt[5])/2 is the so-called golden mean, 
            //and   phi=(1-Sqrt[5])/2 is an associated golden number, 
            //also equal to (-1/Phi). This formula is attributed to Binet in 1843, 
            //though known by Euler before him.
            // the recursive way:
            //https://www.c-sharpcorner.com/UploadFile/19b1bd/calculate-fibonacci-series-in-various-ways-using-C-Sharp/
            // /https://stackoverflow.com/questions/18367240/math-pow-vs-math-exp-c-sharp-net