internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=======================================");
        Console.WriteLine("    CONVERTIDOR DECIMAL / BINARIO");
        Console.WriteLine("=======================================");
        Console.WriteLine("1. Convertir de Decimal a Binario");
        Console.WriteLine("2. Convertir de Binario a Decimal");
        Console.Write("Seleccione una opción (1-2): ");
        int opcion = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n---------------------------------------");

        if (opcion == 1)
        {
            // --- DECIMAL A BINARIO ---
            Console.Write("Ingrese un número decimal: ");
            int numDecimal = Convert.ToInt32(Console.ReadLine());

            if (numDecimal == 0)
            {
                Console.WriteLine("El número en binario es: 0");
            }
            else
            {
                string binario = "";
                int temp = numDecimal;

                while (temp > 0)
                {
                    int residuo = temp % 2;
                    binario = residuo + binario; // Concatenar al frente
                    temp = temp / 2;
                }

                Console.WriteLine($"El número {numDecimal} en binario es: {binario}");
            }
        }
        else if (opcion == 2)
        {
            // --- BINARIO A DECIMAL ---
            Console.Write("Ingrese un número binario: ");
            string binarioStr = Console.ReadLine();

            int numDecimal = 0;
            int baseValor = 1; // Representa 2^0, 2^1, 2^2, etc.

            // Recorrer la cadena de derecha a izquierda
            for (int i = binarioStr.Length - 1; i >= 0; i--)
            {
                if (binarioStr[i] == '1')
                {
                    numDecimal += baseValor;
                }
                baseValor *= 2;
            }

            Console.WriteLine($"El número binario {binarioStr} en decimal es: {numDecimal}");
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }

        Console.WriteLine("---------------------------------------");
    }
}