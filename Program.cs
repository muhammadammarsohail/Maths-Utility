using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double fNum = Convert.ToInt32(Console.ReadLine()), sNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Divide(fNum,sNum));
            }
            catch(DivideByZeroException excD)
            {
                Console.WriteLine(excD.Message);
            }
            catch(NotAnEvenException excE)
            {
                Console.WriteLine(excE.Message);
            }
        }

        static double Divide(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
                throw new DivideByZeroException();

                if (firstNumber % 2 != 0 || secondNumber % 2 != 0)
                    throw new ApplicationException("One of the parameters is not even!");

            return firstNumber / secondNumber;

            
            
        }
    }
}
