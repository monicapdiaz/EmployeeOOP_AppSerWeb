using EmployeeOOP.Clases;

try
{
    //Declaración de variables
    int day, month, year;
    Console.WriteLine("OOP APPLICATION");
    Console.WriteLine("---------------");

    Console.Write("Ingresar el día: ");
    day =  Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el Mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el Año: ");
    year = Convert.ToInt32(Console.ReadLine());

    //Inicialización clase date
    Date dateObject = new Date(day, month, year);
    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());


}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}






