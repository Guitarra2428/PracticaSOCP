namespace PracticaOCP
{
    public class TaxCalculator : ITaxCalculator
    {
        public decimal CalculateTax(decimal income, decimal deductions, string country)
        {
            decimal taxAmount = 0;
            decimal taxableIcome = income-deductions;


            switch (country)
            {
                case "US":
                    taxAmount = taxableIcome * 0.3m; 
                    break;

                case "Canada":
                    
                    taxAmount = taxableIcome * 0.25m;
                    break;

                case "UK":
                    taxAmount = taxableIcome * 0.2m; 
                    break;

                default:
                    throw new Exception("pais no soportado");
            }

            return taxAmount;
        }
    }
}
