int opcion;

while (true)
{
    PrintMenu();    
    try
    {
        opcion = int.Parse(Console.ReadLine());
    } catch
    {
        // Opcion no valida
        opcion = 0;   
    }

    if ( opcion == 0 )
    {
        Console.WriteLine("Seleccione una opción valida. \n Pulse una enter para continuar...  ");
        Console.ReadLine();
    } else
    {

    }
}


void PrintMenu()
{
    Console.Clear();
    Console.WriteLine("Selecciona una opción:");
    Console.WriteLine("1. Registrar producto");
    Console.WriteLine("2. Ver productos");
    Console.WriteLine("3. Salir");
    Console.Write("Selecciona una opción: ");
}