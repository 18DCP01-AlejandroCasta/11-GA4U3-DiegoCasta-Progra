internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=======================================");
        Console.WriteLine("   CONVERTIDOR DE TEMPERATURA");
        Console.WriteLine("=======================================");

        Console.Write("Ingrese la cantidad en grados Centígrados (°C): ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n¿A qué unidad desea convertir?");
        Console.WriteLine("a. Fahrenheit");
        Console.WriteLine("b. Celsius");
        Console.WriteLine("c. Kelvin");
        Console.Write("Seleccione una opción (a, b o c): ");

        char opcion = char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine("\n");

        Console.WriteLine("---------------------------------------");

        switch (opcion)
        {
            case 'a':
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"{celsius} °C equivalen a {fahrenheit:F2} °F.");
                break;

            case 'b':
                Console.WriteLine($"{celsius} °C equivalen a {celsius:F2} °C.");
                break;

            case 'c':
                double kelvin = celsius + 273.15;
                Console.WriteLine($"{celsius} °C equivalen a {kelvin:F2} K.");
                break;

            default:
                Console.WriteLine("Opción no válida. Intente de nuevo usando a, b o c.");
                break;
        }

        Console.WriteLine("---------------------------------------");
    }
}