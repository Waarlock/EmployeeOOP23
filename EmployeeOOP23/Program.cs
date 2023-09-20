// See https://aka.ms/new-console-template for more information
using EmployeeOOP23.Clases;

try
{

    int day, month, year;
    string firstName, lastName;
    decimal salary;

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


    //hardCoding

    Console.Write("Ingresar el nombre completo: ");
    firstName = Console.ReadLine();

    Console.Write("Ingresar apellidos: ");
    lastName = Console.ReadLine();

    Console.Write("Ingresar el salario: ");
    salary = decimal.Parse(Console.ReadLine());


    SalaryEmployee salaryEmployee = new SalaryEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Salary = salary,
    };

    Console.WriteLine(salaryEmployee);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


