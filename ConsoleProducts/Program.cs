using ConsoleProducts.Models;
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
    Product newProduct = new Product();
    Console.WriteLine("----- Registrar un producto -----");
    Console.WriteLine("Introduzca el id: ");
    newProduct.Id = int.Parse(Console.ReadLine());
    Console.WriteLine("Introduzca el Nombre: ");
    newProduct.Name = Console.ReadLine();
    Console.WriteLine("Introduzca la descripción: ");
    newProduct.Description = Console.ReadLine();
    Console.WriteLine("Introduzca la Categoria: ");
    newProduct.Category = Console.ReadLine();
    Console.WriteLine("Introduzca el precio: ");
    newProduct.Price = Decimal.Parse(Console.ReadLine());

    productService.addProduct(newProduct);

    Console.WriteLine("Producto agregado.");
    Console.WriteLine("Pulse algo para continuar");
    Console.ReadKey();
}

void verProductos()
{
    List<Product> products;
    Console.WriteLine("----- Ver productos -----");
    products = productService.GetProducts();
    foreach (Product product in products)
    {
        Console.WriteLine("---- PRODUCTO ----");
        Console.WriteLine("Id: " + product.Id);
        Console.WriteLine("Nombre: " + product.Name);
        Console.WriteLine("Descripción: " + product.Description);
        Console.WriteLine("Categoría: " + product.Price);
        Console.WriteLine("------------------");
    }
    Console.WriteLine("Pulse algo para continuar");
    Console.ReadKey();
}
