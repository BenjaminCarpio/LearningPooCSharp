using System;
using System.Collections.Generic;

namespace DefaultNamespace
{
    public static class CalcularNota
    {
        public static double CalculandoNota(List<Evaluacion> calcular)
        {
            int porcentaje;
            double notaObtenida, notaFinal = 0;
            bool continnuar = true;
            Console.WriteLine("A continuacion se mostraran las evaluaciones, favor digitar la nota obtenida para cada una: ");
            foreach (Evaluacion evaluacion in calcular)
            {
                Console.WriteLine("\n" + evaluacion);
                do
                {
                    Console.Write("\nIngrese la nota obtenida para la evaluacion mostrada: ");
                    notaObtenida = Convert.ToDouble(Console.ReadLine());
                    if (notaObtenida<=10 && notaObtenida>=0)
                    {
                        continnuar = false;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese una nota valida, entre 0 y 10");
                    }
                } while (continnuar);
                porcentaje = evaluacion.Porcentaje;
                notaFinal += (notaObtenida * porcentaje);
            }
            notaFinal /= 100;
            return notaFinal;
        }
    }
}
