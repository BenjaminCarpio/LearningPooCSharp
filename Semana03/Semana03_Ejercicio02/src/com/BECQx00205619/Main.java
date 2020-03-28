package com.BECQx00205619;

import java.util.ArrayList;
import java.util.Scanner;

public class Main {
    static ArrayList<Autor> ListaAutores = new ArrayList<>();
    static ArrayList<Libro> ListaLibros = new ArrayList<>();
    static String nombre, email, ISBN;
    static int paginas;
    static char genero;
    static int opc = 0, opc1 = 0, opc2 = 0, opc3=0, opc4 = 0;
    static Scanner scan = new Scanner(System.in);

    public static void main(String[] args) {


        do{
            System.out.println("1) Agregar Libro/Autor");
            System.out.println("2) Eliminar Libro/Autor");
            System.out.println("3) Mostrar Libros/Autores");
            System.out.println("4) Salir");

            opc1 = scan.nextInt(); scan.nextLine();
            switch (opc1){
                case 1:
                    System.out.println("1) Agregar autor");
                    System.out.println("2) Agregar libro");
                    opc2 = scan.nextInt(); scan.nextLine();
                    switch (opc2){
                        case 1:
                            System.out.println("Ingrese el nombre del Autor: ");
                            nombre = scan.nextLine();
                            System.out.println("Ingrese el Email del Autor: ");
                            email = scan.nextLine();
                            boolean Arroba = email.contains("@");
                            if (Arroba) {
                                System.out.println("Ingrese el genero del Autor (m/f): ");
                                genero = scan.next().charAt(0);
                                if (genero != 'F' && genero != 'f' && genero != 'M' && genero != 'm') {
                                    System.out.println("Ingrese un genero valido.");
                                } else {
                                    System.out.println("Ingresado Correctamente :D ");
                                    ListaAutores.add(new Autor(nombre, email, genero));
                                }
                            } else
                                System.out.println("El email debe contener @, digite un email valido.");
                            break;
                        case 2:
                            System.out.println("Digite nombre del libro: ");
                            nombre = scan.nextLine();

                            System.out.print("Digite el numero de paginas: ");
                            paginas = scan.nextInt(); scan.nextLine();
                            ListaLibros.add(new Libro(nombre, paginas));
                            break;
                        default:
                            System.out.println("Error, ingrese opcion valida.");
                            break;
                    }
                    break;
                case 2:
                    System.out.println("1) Eliminar un autor");
                    System.out.println("2) Eliminar un Libro");
                    opc3 = scan.nextInt(); scan.nextLine();
                    switch (opc3) {
                        case 1:
                            System.out.println("Digite el nombre o correo del autor a eliminar: ");
                            String deleteName = scan.nextLine();
                            ListaAutores.removeIf(s-> s.getNombre().equalsIgnoreCase(deleteName));
                            break;
                        case 2:
                            System.out.println("Digite el nombre del libro a eliminar: ");
                            String deleteLibro = scan.nextLine();
                            ListaLibros.removeIf(s-> s.getNombre().equalsIgnoreCase(deleteLibro));
                            break;
                        default:
                            System.out.println("Error, intente nuevamente");
                    }
                    break;
                case 3:
                    System.out.println("1)  Mostrar autores ");
                    System.out.println("2)  Mostrar libros ");
                    opc4 = scan.nextInt(); scan.nextLine();
                    switch (opc4){
                        case 1:
                            System.out.println("Mostrando Autores: ");
                            ListaAutores.forEach(s-> System.out.println(s.toString()));
                            break;
                        case 2:
                            System.out.println("Mostrando Libros: ");
                            ListaLibros.forEach(s-> System.out.println(s.toString()));
                            break;
                        default:
                            System.out.println("Error, intente nuevamente");
                    }
                    break;
                case 4:
                    System.out.println("Cerrando programa....");
                    opc = 1;
                    break;
                default:
                    System.out.println("Opcion Erronea!, intente nuevamente");
            }
        }while(opc != 1);

    }
}