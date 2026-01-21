namespace ConceptsPOO
{
    public abstract class Employee
    {
        public int id { get; set; }

        public int FirstName { get; set; }


        public int LastName { get; set; }


        public Date BirtDate { get; set; }


        public Date HiringDate { get; set; }


        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            //interpolación de strines
            return $"{id} - {FirstName} {LastName}, " +
                $"Birth; {BirtDate}, " +
                $"Hiring: {HiringDate}, " +
                $"Is Active: {IsActive}";
        }

    }
}