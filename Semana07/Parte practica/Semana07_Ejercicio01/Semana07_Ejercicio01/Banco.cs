using System;

namespace Semana07_Ejercicio01
{
    public class Banco
    {
        public static void registrarTarjeta(){
            Console.Write("\nNúmero de tarjeta: ");
            string numero = Console.ReadLine();

            if (numero != null && (numero.Length == 11 && numero[3] .Equals('-') && numero[7] .Equals('-')))
            {
                GestorArchivos.Anexar("Tarjetas.txt", numero);
                Console.WriteLine("Tarjeta creada exitosamente!");
            }
            else
            {
                Console.WriteLine("Ingrese una tarjeta valida.\nUse el formato siguiente:\nxxx-xxx-xxx\n");
            }
        }
    
        public static void consultarTarjetas(){
            Console.WriteLine("\n" + GestorArchivos.Leer("Tarjetas.txt"));
        }
        public static bool realizarCompras(string tarjeta){
            return GestorArchivos.Buscar("Tarjetas.txt", tarjeta);
        }
    }
}