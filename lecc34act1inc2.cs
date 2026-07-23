internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("     CÁLCULO DEL IMC (PESO/ALTURA²)");

        Console.Write("Ingrese su peso en kilogramos (ej. 70.5): ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese su altura en metros (ej. 1.75): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double imc = peso / Math.Pow(altura, 2);

        Console.WriteLine("\n---------------------------------------");
        Console.WriteLine($"Su IMC es: {imc:F2}");

        if (imc < 18.5)
        {
            Console.WriteLine("Estado: Bajo peso");
        }
        else if (imc >= 18.5 && imc < 25)
        {
            Console.WriteLine("Estado: Peso normal");
        }
        else if (imc >= 25 && imc < 30)
        {
            Console.WriteLine("Estado: Sobrepeso");
        }
        else
        {
            Console.WriteLine("Estado: Obesidad");
        }
        Console.WriteLine("---------------------------------------");
    }
}