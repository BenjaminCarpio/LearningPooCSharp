using System;
using System.Collections.Generic;
using DefaultNamespace;

namespace PreParcialFinal
{
    internal class Program
    {
        public static List<Evaluacion> listaDeEvaluacion = new List<Evaluacion>();
        public static int verificadorPorcentaje = 0, porcentajeEvaluacion = 0;
        

        public static void Main(string[] args)
        {
            Proxy.ProxySencillo myProxy = new Proxy.ProxySencillo();
            Proxy.ProxySeguro myProxySeguro = new Proxy.ProxySeguro();
            
            int opcion;
            bool continuar = true;
            //Para evitar problemas revisando el codigo dejo el pass ahí :)
            Console.WriteLine("La clave para elproxy seguro es: 123Hola321..");
            do
            {
                Console.WriteLine(Menu());
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException exc)
                {
                    opcion = 0;
                    Console.WriteLine("Favor ingresar algo valido.");
                }

                switch (opcion)
                {
                    case 1:
                        try
                        {
                            myProxySeguro.AgregarEvaluacion();
                        }
                        catch (PercentageExceedsTheLimits e)
                        {
                            Console.WriteLine("El porcentaje ingresado supera al 100%, volviendo al menu...");
                            
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Favor ingresar algo valido.");
                        }

                        break;
                    case 2:
                        myProxy.MostrarEvaluaciones(listaDeEvaluacion);
                        break;
                    case 3:
                        myProxySeguro.EliminarEvaluacion();
                        break;
                    case 4:
                        try
                        {
                            myProxy.TerminarPrograma(listaDeEvaluacion);
                            continuar = false;
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Favor ingresar algo valido.");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Volviendo al menu");
                        }

                        break;
                    case 0: break; //Para el try catch
                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }
            } while (continuar);
        }
        
        static string Menu()
        {
            return "\nSeleccione una opcion:\n" +
                   "1) Agregar evaluacion\n" +
                   "2) Mostrar evaluaciones almacenadas\n" +
                   "3) Eliminar evaluacion\n" +
                   "4) Terminar programa\n";
        }
        
    }
}