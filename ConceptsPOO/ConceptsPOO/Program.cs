// See https://aka.ms/new-console-template for more information
using ConceptsPOO;

Console.WriteLine("POO Concepts!");
Console.WriteLine("==============");

//implementación
Employee employee1 = new SalaryEmployee()
{ 
    Id = 1010, 
    FirstName = "Oswaldo", 
    LastName = "Sierra", 
    BirtDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15), 
    IsActive = true, 
    Salary = 1834000.45M, };

Console.WriteLine(employee1);


Employee employee2 = new CommissionEmployee()
{
    Id = 2010,
    FirstName = "Juan Carlos",
    LastName = "RIvera Oquendo",
    BirtDate = new Date(1983, 7, 21),
    HiringDate = new Date (2015, 09, 28),
    IsActive = true,
    CommissionPercentaje = 0.03f,
    Sales = 400000000M,
};
Console.WriteLine(employee2);