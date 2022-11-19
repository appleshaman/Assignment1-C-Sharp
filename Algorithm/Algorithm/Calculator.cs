using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace Algorithm
{
    public class Calculator
    {
        public  double Add(double first, double second)
        {
            return first + second;
        }

        public  double Subtract(double first, double second)
        {
            return first - second;
        }

        public  double Multiple(double first, double second)
        {
            return first * second;
        }

        public  double Devide(double first, double second)
        {
            
            try
            {
                
                return first / second;
            }
            catch (DivideByZeroException)
            {
             
                throw new DivideByZeroException("Cannot divide by zero");
            }
        }

        public Complex[] SquarRoot(double first)
        {
            
            if(first >= 0)
            {
                first = Math.Sqrt(first);
                Complex complex1 = new Complex(0, first);
                Complex complex2 = new Complex(0, -first);
                Complex[] cplexNumber = { complex1, complex2 };
                return cplexNumber;
            }
            else 
            {

                first = Math.Abs(first);
                first = Math.Sqrt(first);
                Complex complex1 = new Complex(0, first);
                Complex complex2 = new Complex(0, -first);
                Complex[] cplexNumber = { complex1, complex2 };
                return cplexNumber;

            }
                
        }

        

    }
}
