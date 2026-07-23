internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese su mes de nacimiento (1-12): ");
        int mes = Convert.ToInt32(Console.ReadLine());

        // 2. Pedir el día de nacimiento
        Console.Write("Ingrese su día de nacimiento (1-31): ");
        int dia = Convert.ToInt32(Console.ReadLine());

        string signo = "";
        string horoscopo = "";

        // 3. Evaluar el signo zodiacal según la fecha
        if ((mes == 3 && dia >= 21) || (mes == 4 && dia <= 19))
        {
            signo = "Aries";
            horoscopo = "Hoy es un gran día para iniciar nuevos proyectos con energía.";
        }
        else if ((mes == 4 && dia >= 20) || (mes == 5 && dia <= 20))
        {
            signo = "Tauro";
            horoscopo = "La paciencia y el enfoque te llevarán a cumplir tus metas.";
        }
        else if ((mes == 5 && dia >= 21) || (mes == 6 && dia <= 20))
        {
            signo = "Géminis";
            horoscopo = "Tu curiosidad y buena comunicación te abrirán muchas puertas.";
        }
        else if ((mes == 6 && dia >= 21) || (mes == 7 && dia <= 22))
        {
            signo = "Cáncer";
            horoscopo = "Dedica un tiempo para compartir y conectar con tus seres queridos.";
        }
        else if ((mes == 7 && dia >= 23) || (mes == 8 && dia <= 22))
        {
            signo = "Leo";
            horoscopo = "Tu liderazgo y entusiasmo inspirarán a las personas a tu alrededor.";
        }
        else if ((mes == 8 && dia >= 23) || (mes == 9 && dia <= 22))
        {
            signo = "Virgo";
            horoscopo = "El orden y el análisis te ayudarán a resolver cualquier inconveniente.";
        }
        else if ((mes == 9 && dia >= 23) || (mes == 10 && dia <= 22))
        {
            signo = "Libra";
            horoscopo = "Busca el equilibrio en tus actividades y toma un descanso merecido.";
        }
        else if ((mes == 10 && dia >= 23) || (mes == 11 && dia <= 21))
        {
            signo = "Escorpio";
            horoscopo = "Tu intuición estará muy acertada hoy, confía en tus instintos.";
        }
        else if ((mes == 11 && dia >= 22) || (mes == 12 && dia <= 21))
        {
            signo = "Sagitario";
            horoscopo = "Una excelente oportunidad para aprender algo nuevo se aproxima.";
        }
        else if ((mes == 12 && dia >= 22) || (mes == 1 && dia <= 19))
        {
            signo = "Capricornio";
            horoscopo = "Tu constancia y esfuerzo darán frutos muy pronto.";
        }
        else if ((mes == 1 && dia >= 20) || (mes == 2 && dia <= 18))
        {
            signo = "Acuario";
            horoscopo = "Tu creatividad estará al máximo, aprovecha para innovar.";
        }
        else if ((mes == 2 && dia >= 19) || (mes == 3 && dia <= 20))
        {
            signo = "Piscis";
            horoscopo = "Tu amabilidad y empatía ayudarán a alegrar el día de alguien más.";
        }
        else
        {
            signo = "Desconocido";
            horoscopo = "La fecha ingresada no es válida.";
        }

        // 4. Mostrar el resultado
        Console.WriteLine("\n-------------------------------------------");
        Console.WriteLine($"Signo zodiacal: {signo}");
        Console.WriteLine($"Horóscopo: {horoscopo}");
        Console.WriteLine("-------------------------------------------");
    }
}