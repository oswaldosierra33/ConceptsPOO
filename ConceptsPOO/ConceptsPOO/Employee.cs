
namespace ConceptsPOO
{
    public abstract class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }


        public string LastName { get; set; }


        public Date BirtDate { get; set; }


        public Date HiringDate { get; set; }


        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            //interpolación de strines
            return $"{Id} - {FirstName} {LastName}, " +
                $"Birth; {BirtDate}, " +
                $"Hiring: {HiringDate}, " +
                $"Is Active: {IsActive}";
        }
    }
}