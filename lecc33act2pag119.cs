internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine();

        string fraseInvertida = "";

        for (int i = frase.Length - 1; i >= 0; i--)
        {
            fraseInvertida += frase[i];
        }

        Console.WriteLine("\n-------------------------------------------");
        Console.WriteLine($"Frase original:  {frase}");
        Console.WriteLine($"Frase invertida: {fraseInvertida}");
        Console.WriteLine("-------------------------------------------");
    }
}