using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOCP
{
    public class CanadaTax : ITaxCalculator
    {
        public decimal CalculateTax(decimal income, decimal deductions, string country)
        {
            decimal taxAmount = 0;
            decimal taxableIcome = income - deductions;
            taxAmount = taxableIcome * 0.25m;

            return taxAmount;
        }
    }
}
