internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese la cantidad en metros: ");
        double metros = Convert.ToDouble(Console.ReadLine());

        // 2. Mostrar el menú de opciones
        Console.WriteLine("\n¿A qué unidad desea convertir?");
        Console.WriteLine("a) Milímetros");
        Console.WriteLine("b) Centímetros");
        Console.WriteLine("c) Decímetros");
        Console.WriteLine("d) Hectómetros");
        Console.WriteLine("e) Kilómetros");
        Console.Write("Seleccione una opción (a-e): ");

        // ReadKey captura la tecla presionada y la convierte a minúscula
        char opcion = char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine("\n"); // Salto de línea para dar formato

        // 3. Evaluar la opción seleccionada y realizar el cálculo correspondiente
        switch (opcion)
        {
            case 'a':
                double mm = metros * 1000;
                Console.WriteLine($"{metros} metros equivale a {mm:N0} milímetros.");
                break;

            case 'b':
                double cm = metros * 100;
                Console.WriteLine($"{metros} metros equivale a {cm:N0} centímetros.");
                break;

            case 'c':
                double dm = metros * 10;
                Console.WriteLine($"{metros} metros equivale a {dm:N0} decímetros.");
                break;

            case 'd':
                double hm = metros / 100;
                Console.WriteLine($"{metros} metros equivale a {hm} hectómetros.");
                break;

            case 'e':
                double km = metros / 1000;
                Console.WriteLine($"{metros} metros equivale a {km} kilómetros.");
                break;

            default:
                Console.WriteLine("Opción no válida. Por favor ejecute el programa de nuevo e intente con las letras de la 'a' a la 'e'.");
                break;
        }
    }
}