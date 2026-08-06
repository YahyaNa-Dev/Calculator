using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatotr
{
    internal class Program
    {

         class clsCalculator
        {
         private int _Result = 0;
         private int _OldValue = 0;
         private string _TheSituation = "";

            public int AvoidTheDisasterOfDivisionByZero(int Num)
            {
                if (Num == 0)
                    return 1;

                return Num;
            }
            public void Add(int Num)
            {
                _TheSituation = "Adding";
                _OldValue = Num;
                _Result += Num;
            }

            public void Subtract(int Num)
            {
                _TheSituation = "Subtracting";
                _OldValue = Num;
                _Result -= Num;
            }

            public void Divide(int Num)
            {
                Num = AvoidTheDisasterOfDivisionByZero(Num);
                _TheSituation = "Divideing";
                _OldValue = Num;
                _Result /= Num;
            }

            public void Multiply(int Num)
            {
                _TheSituation = "Multiplying";
                _OldValue = Num;
                _Result *= Num;
            }

            public void Clear()
            {
              _Result = 0;
              _OldValue = 0;
              _TheSituation = "Clear";
        }

            public void PrintResult()
            {
                Console.WriteLine("Result After {0} {1} is : {2}", _TheSituation, _OldValue, _Result);
            }
        }


        static void Main(string[] args)
        {
            clsCalculator calculator = new clsCalculator();

            calculator.Add(10);
            calculator.PrintResult();

            calculator.Add(100);
            calculator.PrintResult();

            calculator.Subtract(20);
            calculator.PrintResult();

            calculator.Divide(0);
            calculator.PrintResult();

            calculator.Divide(2);
            calculator.PrintResult();

            calculator.Multiply(3);
            calculator.PrintResult();

            calculator.Clear();
            calculator.PrintResult();

            calculator.Add(10);
            calculator.PrintResult();

            calculator.Multiply(3);
            calculator.PrintResult();
        }
    }
}
