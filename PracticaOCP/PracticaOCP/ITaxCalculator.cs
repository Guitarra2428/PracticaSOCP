using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOCP
{
    public interface ITaxCalculator
    {
        decimal CalculateTax(decimal income, decimal deductions, string country);
    }
}
