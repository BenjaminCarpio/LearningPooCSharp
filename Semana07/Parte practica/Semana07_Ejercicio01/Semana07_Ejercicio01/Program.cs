using System;

namespace Semana07_Ejercicio01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
          bool continuar = true;
          int opcion;
                do{
                    Console.Write(menu());
                    try
                    {
                        opcion = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Ingrese algo valido.");
                        opcion = 0;
                    }
                    catch (OverflowException e)
                    {
                        Console.WriteLine("Te pelaste con el tamano del numero.");
                        opcion = 0;
                    }

                    switch(opcion){
                        case 1: Banco.registrarTarjeta(); break;
                        case 2: Banco.consultarTarjetas(); break;
                        case 3: ConsolaJuegos.comprarJuego(); break;
                        case 4: ConsolaJuegos.jugar(); break;
                        case 5: continuar = false; break;
                        case 0: break;
                        default: Console.WriteLine("Opcion errónea!"); break;
                    }
                }while(continuar);
                Console.WriteLine("\nTenga un buen día!");
        }
        static string menu(){
            return "\nBienvenido:\n" +
                   "1) Registrar tarjeta (banco).\n" +
                   "2) Consultar tarjetas (banco).\n" +
                   "3) Comprar videojuego (consola).\n" +
                   "4) Jugar videojuego (consola).\n" +
                   "5) Salir.\n" +
                   "Opción elegida: ";
        }
    }
}