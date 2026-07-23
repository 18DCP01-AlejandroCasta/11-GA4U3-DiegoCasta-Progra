internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        char jugarNuevo;

        do
        {
            Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("       PIEDRA, PAPEL O TIJERAS");
            Console.WriteLine("=======================================");
            Console.WriteLine("1. Piedra");
            Console.WriteLine("2. Papel");
            Console.WriteLine("3. Tijeras");
            Console.Write("Elija su opción (1-3): ");

            int eleccionUsuario = Convert.ToInt32(Console.ReadLine());

            int eleccionComp = random.Next(1, 4);

            string[] opciones = { "", "Piedra", "Papel", "Tijeras" };

            if (eleccionUsuario >= 1 && eleccionUsuario <= 3)
            {
                Console.WriteLine("\n---------------------------------------");
                Console.WriteLine($"Tú elegiste:        {opciones[eleccionUsuario]}");
                Console.WriteLine($"La computadora eligió: {opciones[eleccionComp]}");
                Console.WriteLine("---------------------------------------");

                if (eleccionUsuario == eleccionComp)
                {
                    Console.WriteLine("¡Es un EMPATE!");
                }
                else if ((eleccionUsuario == 1 && eleccionComp == 3) ||
                         (eleccionUsuario == 2 && eleccionComp == 1) ||
                         (eleccionUsuario == 3 && eleccionComp == 2))
                {
                    Console.WriteLine("¡Felicidades, GANASTE!");
                }
                else
                {
                    Console.WriteLine("¡Gana la COMPUTADORA!");
                }
            }
            else
            {
                Console.WriteLine("\nOpción no válida. Debes elegir 1, 2 o 3.");
            }

            Console.Write("\n¿Desea jugar de nuevo? (s/n): ");
            jugarNuevo = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

        } while (jugarNuevo == 's');

        Console.WriteLine("\n¡Gracias por jugar! Hasta pronto.");
    }
}