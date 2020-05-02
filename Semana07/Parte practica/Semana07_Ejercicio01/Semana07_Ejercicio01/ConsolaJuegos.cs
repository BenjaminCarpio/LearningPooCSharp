using System;

namespace Semana07_Ejercicio01
{
    public class ConsolaJuegos
    {
        public static void comprarJuego(){
                Console.Write("\nNúmero de tarjeta: ");
                string numero = Console.ReadLine();
        
                if(Banco.realizarCompras(numero)){
                    Console.Write("\nNombre del juego: ");
                    string juego = Console.ReadLine();
            
                    GestorArchivos.Anexar("Juegos.txt", juego);
            
                    Console.WriteLine("\nJuego comprado exitosamente!");
                }
            }
    
            public static void jugar(){
                Console.Write("Nombre del juego: ");
                string juego = Console.ReadLine();
        
                if(GestorArchivos.Buscar("Juegos.txt", juego))
                    Console.WriteLine("Listo para jugar!");
                else
                    Console.WriteLine("Primero debe comprar el juego :(");
            }
    }
}