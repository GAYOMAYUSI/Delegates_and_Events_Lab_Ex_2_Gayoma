using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication_.frmCal
{
    public class CalculatorClass
    { 
        public delegate T formula<T>(T args1, T args2);
        public delegate T Information<T>(T args);
        
        public event formula<double> CalculateEvent;
        public void AddFormula(formula<double> formula)
        {
            CalculateEvent += formula;
            Console.WriteLine("Added the delegate");
        }
        public void RemoveFormula(formula<double> formula)
        {
            CalculateEvent -= formula;
            Console.WriteLine("Remove the Delegate");
        }
        
        public double GetSum(double a, double b)
        {
            return a + b;
        }
        public double GetDifference(double a, double b)
        {
            return a - b;
        }
        public double GetProduct(double a, double b)
        {
            return a * b;
        }
        public double GetQuotient(double a, double b)
        {
            if (b == 0) return 0;
            return a / b;
        }
    }

    internal class FrmCalcu
    {
    }
}
