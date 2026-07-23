internal class Program
{
    private static void Main(string[] args)
    {
        char repetir;

        do
        {
            Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("        CONVERTIDOR DE MONEDA");
            Console.WriteLine("=======================================");

            Console.Write("Ingrese la cantidad en moneda local: ");
            double cantidadLocal = Convert.ToDouble(Console.ReadLine());

            double usd = cantidadLocal * 0.13; // Estados Unidos (Dólar)
            double eur = cantidadLocal * 0.12; // Unión Europea (Euro)
            double mxn = cantidadLocal * 2.30; // México (Peso Mexicano)
            double jpy = cantidadLocal * 20.5; // Japón (Yen)
            double gbp = cantidadLocal * 0.10; // Reino Unido (Libra Esterlina)

            Console.WriteLine("\n--- EQUIVALENCIA EN 5 PAÍSES ---");
            Console.WriteLine($"1. Estados Unidos (USD): ${usd:F2}");
            Console.WriteLine($"2. Unión Europea (EUR) : €{eur:F2}");
            Console.WriteLine($"3. México (MXN)        : ${mxn:F2}");
            Console.WriteLine($"4. Japón (JPY)         : ¥{jpy:F2}");
            Console.WriteLine($"5. Reino Unido (GBP)   : £{gbp:F2}");
            Console.WriteLine("---------------------------------------");

            Console.Write("\n¿Desea convertir otra cantidad? (s/n): ");
            repetir = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

        } while (repetir == 's');

        Console.WriteLine("\n¡Gracias por usar el convertidor!");
    }
}