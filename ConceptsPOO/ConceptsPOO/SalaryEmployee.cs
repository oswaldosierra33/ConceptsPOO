namespace ConceptsPOO
{
    // para heredar se utiliza :
    // esta heredando de una clase abstracta Employee
    internal class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }
        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            //base.ToString es interpolar la información que se tiene del empleado
            return $"{base.ToString()}\n\t" + 
                $"Value to pay........: {$"{GetValueToPay():C2}", 20}";
        }

    }
}
