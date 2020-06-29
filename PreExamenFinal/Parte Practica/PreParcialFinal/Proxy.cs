using System;
using System.Collections.Generic;
using PreParcialFinal;

namespace DefaultNamespace
{
    public class Proxy
    {

        public class ProxySencillo
        {

            public void MostrarEvaluaciones(List<Evaluacion> lista)
            {
                {
                    if (lista.Count == 0)
                    {
                        Console.WriteLine("La lista no contiene ninguna evaluacion ingresada.");
                    }
                    else
                    {
                        foreach (Evaluacion evaluacion in lista)
                        {
                            Console.WriteLine("\n" + evaluacion);
                        }
                    }
                }
            }

            public void TerminarPrograma(List<Evaluacion> lista)
            {
                double notaFinal = 0;
                double verificadorPorcentaje = Program.verificadorPorcentaje;
                if (verificadorPorcentaje == 100)
                {
                    Console.WriteLine("Se ingreso el 100% de las calificaciones, procediendo a evaluar nota.....");
                    notaFinal = CalcularNota.CalculandoNota(lista);
                    Console.WriteLine("La nota final es: " + notaFinal);
                }
                else
                {
                    Boolean continuarSubMenu = true;
                    do
                    {
                        Console.WriteLine("No se llego al 100% del porcentaje\nDesea agregar mas evaluaciones?(S/N)");
                        String masEvaluaciones = Console.ReadLine();
                        if (masEvaluaciones.ToLower() == "s")
                        {
                            Console.WriteLine("Volviendo al menu para agregar más evaluaciones......");
                            continuarSubMenu = false;
                        }
                        else if (masEvaluaciones.ToLower() == "n")
                        {
                            Console.WriteLine(
                                "Se procedera a calcular la nota con las evaluaciones ingresadas." +
                                "El " + verificadorPorcentaje +
                                "% se evaluara con las calificaciones que ingrese" +
                                " mientras que el resto de evaluaciones se tomaran como un 0 de calificacion ");
                            notaFinal = CalcularNota.CalculandoNota(lista);
                            Console.WriteLine("La nota final es: " + notaFinal);
                            continuarSubMenu = false;
                        }
                        else
                        {
                            Console.WriteLine("Opcion invalida, intente nuevamente.");
                        }
                    } while (continuarSubMenu);
                }
            }
        }

        public class ProxySeguro
        {
            public void AgregarEvaluacion()
            {
                Console.Write("Ingrese la clave para acceder a este metodo:");
                var password = Console.ReadLine();
                if (password.Equals("123Hola321.."))
                {

                    Console.WriteLine("Que tipo de evaluacion desea agregar?\n1)Parcial\n2)Laboratorio\n3)Tarea");
                    int opcionEvaluacion = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Porcentaje disponible: " + (100 - Program.verificadorPorcentaje));
                    Console.Write("\nIngrese el porcentaje que tendra la evaluacion: ");
                    int porcentajeEvaluacion = Convert.ToInt32(Console.ReadLine());
                    if (Program.verificadorPorcentaje <= 100 && porcentajeEvaluacion <= (100 - Program.verificadorPorcentaje))
                    {
                        Console.Write("Ingrese el nombre que se le asignara a la evaluacion: ");
                        String nombreEvaluacion = Console.ReadLine();
                        switch (opcionEvaluacion)
                        {
                            case 1:
                                Console.Write("Ingrese la cantidad de preguntas que tendra el parcial: ");
                                int cantidadPreguntas = Convert.ToInt32(Console.ReadLine());
                                Program.listaDeEvaluacion.Add(new Parcial(porcentajeEvaluacion, nombreEvaluacion,
                                    cantidadPreguntas));
                                Program.verificadorPorcentaje += porcentajeEvaluacion;
                                break;
                            case 2:
                                Console.Write("Ingrese el tipo del laboratorio: ");
                                String tipoLaboratorio = Console.ReadLine();
                                Program.listaDeEvaluacion.Add(new Laboratorio(porcentajeEvaluacion, nombreEvaluacion,
                                    tipoLaboratorio));
                                Program.verificadorPorcentaje += porcentajeEvaluacion;
                                break;
                            case 3:
                                Console.Write(
                                    "Indique la fecha de entrega para la terea con el formate (Mes/Dia/Anio): ");
                                DateTime fechaEntrega = Convert.ToDateTime(Console.ReadLine());
                                Program.listaDeEvaluacion.Add(new Tarea(porcentajeEvaluacion, nombreEvaluacion,
                                    fechaEntrega));
                                Program.verificadorPorcentaje += porcentajeEvaluacion;
                                break;
                        }
                    }
                    else
                    {
                        throw new PercentageExceedsTheLimits("Ha superado el porcentaje permitido.");
                    }

                }
                else
                {
                    Console.WriteLine("Clave incorrecta, acceso al metodo denegado.");
                }
            }

            public void EliminarEvaluacion()
            {
                Console.Write("Ingrese la clave para acceder a este metodo:");
                var password2 = Console.ReadLine();
                if (password2.Equals("123Hola321.."))
                {
                    Console.Write("Ingrese el nombre de la evaluacion a eliminar:");
                    String nombreEliminar = Console.ReadLine();
                    String opcion;
                    int contadorPrincipal = 0, contador = 0, eliminar = 0, porcentajeAuxiliar = 0;
                    bool eliminado = false;
                    foreach (Evaluacion ev in Program.listaDeEvaluacion)
                    {
                        if (ev.Nombre.Equals(nombreEliminar, StringComparison.InvariantCultureIgnoreCase))
                        {
                            contador++;
                            eliminar = contadorPrincipal;
                            porcentajeAuxiliar = ev.Porcentaje;
                        }

                        contadorPrincipal++;
                    }

                    if (contador == 0)
                    {
                        Console.WriteLine("No se encontro la evaluacion");
                    }
                    else if (contador == 1)
                    {
                        Program.listaDeEvaluacion.RemoveAt(eliminar);
                        Program.verificadorPorcentaje -= porcentajeAuxiliar;
                        Console.WriteLine("Se elimino exitosamente ");
                    }
                    else if (contador > 1)
                    {
                        contadorPrincipal = 0;
                        contador = 0;
                        Console.WriteLine(
                            "Hay mas de 1 evaluacion con ese nombre, favor especifique cual evaluacion es la que desea eliminar.");
                        foreach (var eva in Program.listaDeEvaluacion)
                        {
                            if (eva.Nombre.Equals(nombreEliminar, StringComparison.InvariantCultureIgnoreCase))
                            {
                                Console.WriteLine(eva + "\n Esta es la evaluacion que desea eliminar? (S/N)");
                                opcion = Console.ReadLine();
                                if (opcion != null && (opcion.Equals("s") || opcion.Equals("S")))
                                {
                                    porcentajeAuxiliar = eva.Porcentaje;
                                    Program.verificadorPorcentaje -= porcentajeAuxiliar;
                                    contador = contadorPrincipal;
                                    Console.WriteLine("La evaluacion se elimino con exito");
                                    break;
                                }

                                if (opcion != null && (opcion.Equals("n") || opcion.Equals("N")))
                                {
                                    Console.WriteLine("\nBuscando siguiente evaluacion....\n");
                                }
                            }

                            contadorPrincipal++;
                        }

                        Program.listaDeEvaluacion.RemoveAt(contador);
                    }
                }
                else
                {
                    Console.WriteLine("Clave incorrecta, acceso al metodo denegado.");
                }
            }
        }
    }
}