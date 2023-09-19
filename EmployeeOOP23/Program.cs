// See https://aka.ms/new-console-template for more information
using EmployeeOOP23.Clases;

try
{

    int day, month, year;

    Console.WriteLine("OOP APPLICATION");
    Console.WriteLine("---------------");

    Console.Write("Ingresar el dia: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el Mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el Año: ");
    year = Convert.ToInt32(Console.ReadLine());



    // Inicializacion de la clase date
    Date dateObject = new Date(day, month, year);
    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


