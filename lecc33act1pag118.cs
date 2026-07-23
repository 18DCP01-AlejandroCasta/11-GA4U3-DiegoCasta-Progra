internal class Program
{
    private static void Main(string[] args)
    {
        string[] nombres = new string[10];
        string[] telefonos = new string[10];

        Console.WriteLine("=== REGISTRO DE AGENDA TELEFÓNICA ===");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"\nContacto #{i + 1}:");

            Console.Write("Nombre: ");
            nombres[i] = Console.ReadLine();

            Console.Write("Teléfono: ");
            telefonos[i] = Console.ReadLine();
        }

        Console.WriteLine("\n-------------------------------------------");
        Console.Write("Ingrese la posición a consultar (1 - 10): ");
        int posicion = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("-------------------------------------------");

        if (posicion >= 1 && posicion <= 10)
        {
            int indice = posicion - 1;
            Console.WriteLine($"\n[Contacto en posición {posicion}]");
            Console.WriteLine($"Nombre:   {nombres[indice]}");
            Console.WriteLine($"Teléfono: {telefonos[indice]}");
        }
        else
        {
            Console.WriteLine("Error: La posición debe estar entre 1 y 10.");
        }
    }
}