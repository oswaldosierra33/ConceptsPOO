using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    internal class CommissionEmployee : Employee
    {
        public float CommissionPercentaje { get; set; }

        public decimal Sales {  get; set; }
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentaje;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"\n\tCommissionPercentaje: {$"{CommissionPercentaje:P2}", 20}" +
                $"\n\tSales...............: {$"{Sales:C2}", 20}" +
                $"\n\tValue to pay:.......: {$"{GetValueToPay():c2}", 20}";
        }
    }
}
