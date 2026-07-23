internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("CALCULADORA DE CAMBIO");

        Console.Write("Ingrese el precio del producto: ");
        int precio = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese la cantidad recibida (pago): ");
        int pago = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n---------------------------------------");

        if (pago < precio)
        {
            Console.WriteLine("Error: El dinero ingresado es insuficiente.");
        }
        else
        {
            int cambio = pago - precio;
            Console.WriteLine($"Cambio total a devolver: ${cambio}\n");

            int b200 = cambio / 200;
            cambio %= 200;

            int b100 = cambio / 100;
            cambio %= 100;

            int b50 = cambio / 50;
            cambio %= 50;

            int b20 = cambio / 20;
            cambio %= 20;

            int monedas = cambio;

            Console.WriteLine("Desglose del cambio:");
            Console.WriteLine($"- Billetes de 200: {b200}");
            Console.WriteLine($"- Billetes de 100: {b100}");
            Console.WriteLine($"- Billetes de 50 : {b50}");
            Console.WriteLine($"- Billetes de 20 : {b20}");
            Console.WriteLine($"- Monedas        : {monedas}");
        }

        Console.WriteLine("---------------------------------------");
    }
}