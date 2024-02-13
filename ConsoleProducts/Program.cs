using ConsoleProducts.Repositories;
using ConsoleProducts.Services;

//Inicializando servicio e injectando repositorio
ProductRepository productRepository = new ProductRepository();
ProductService productService = new ProductService(productRepository);

// Inicializando opcón de menú
int opcion=0;

while (opcion != 3)
{
    printMenu();    
    try
    {
        opcion = int.Parse(Console.ReadLine());
    } catch
    {
        // Opcion no valida
        opcion = 0;   
    }

    switch (opcion)
    {
        case 0:
            Console.WriteLine("Seleccione una opçion valida");
            Console.WriteLine("Pulse una tecla para continuar... ");
            Console.ReadKey();
            break;
        case 1:
            registrarProducto();
            break;
        case 2:
            verProductos();
            break;
        case 3:
            break;
    }
}


void printMenu()
{
    Console.Clear();
    Console.WriteLine("Selecciona una opción:");
    Console.WriteLine("1. Registrar producto");
    Console.WriteLine("2. Ver productos");
    Console.WriteLine("3. Salir");
    Console.Write("Selecciona una opción: ");
}


void registrarProducto()
{

}

void verProductos()
{

}
