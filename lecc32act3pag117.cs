internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese la medida del primer lado: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la medida del segundo lado: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la medida del tercer lado: ");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n-------------------------------------------");

        if (lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine("El triángulo es EQUILÁTERO (tiene sus 3 lados iguales).");
        }
        else if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
        {
            Console.WriteLine("El triángulo es ESCALENO (todos sus lados son diferentes).");
        }
        else
        {
            Console.WriteLine("El triángulo es ISÓSCELES (tiene 2 lados iguales).");
        }

        Console.WriteLine("-------------------------------------------");
    }
}