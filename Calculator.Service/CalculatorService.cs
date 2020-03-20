using System;
using System.Data;

namespace Calculator.Service
{
    public class CalculatorService : ICalculator
    {

        public float CalculateStringExpression(string expression)
        {
            if (expression == null)
                throw new ArgumentNullException(nameof(expression));

            DataTable dt = new DataTable();
            var v = dt.Compute(expression, "");
            return float.Parse(v.ToString());
        }
    }
}
