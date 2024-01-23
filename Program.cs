
using System;

namespace Ejercicio1Repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutosXmes;
            Console.WriteLine("Introduzca el número de minutos trabajados en el mes: ");
            minutosXmes = int.Parse(Console.ReadLine());

            int dias = minutosXmes / (60 * 24);
            int minutosRestantes = minutosXmes % (60 * 24);

            int horas = minutosRestantes / (60);
            minutosRestantes = minutosXmes % (60);

            if (dias == 1)
            {
                if (horas == 1)
                {
                    if (minutosRestantes == 1)
                    {
                        Console.WriteLine(dias + "dia," + horas + "hora," + minutosRestantes + "minuto");
                    }
                }
                Console.WriteLine(dias + "dia," + horas + "horas," + minutosRestantes + "minutos");
            }
            if (minutosRestantes == 0)
            {
                Console.WriteLine(dias + "dias," + horas + "horas, ");
            }
            else
            {
                Console.WriteLine(dias + "dias," + horas + "horas, " + minutosRestantes + "minutos.");
                Console.ReadKey();
            }
            if(horas == 1)
            {
                Console.WriteLine(dias + "dias," + horas + "hora " + minutosRestantes + "minutos");
            }
            else
            {
                Console.WriteLine(dias + "dias," + horas + "horas, " + minutosRestantes + "minutos.");
                Console.ReadKey();
            }
            if(minutosRestantes == 1)
            {
                Console.WriteLine(dias + "dias," + horas + "hora " + minutosRestantes + "minuto");
            }
            else
            {
                Console.WriteLine(dias + "dias," + horas + "horas, " + minutosRestantes + "minutos.");
                Console.ReadKey();
            }
        }
    }
}

