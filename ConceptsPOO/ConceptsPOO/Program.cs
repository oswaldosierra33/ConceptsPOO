// See https://aka.ms/new-console-template for more information
using ConceptsPOO;

Console.WriteLine("POO Concepts!");
Console.WriteLine("==============");

//Date oll
//Date date1 = new Date(2026, 01, 16);
try
{
	Console.WriteLine(new Date(2024, 2, 29));
	Console.WriteLine(new Date(1974, 9, 3));
	Console.WriteLine(new Date(1985, 11, 10));
	Console.WriteLine(new Date(1960, 12, 31));
}
catch (Exception error)
{
		Console.WriteLine(error.Message);
}