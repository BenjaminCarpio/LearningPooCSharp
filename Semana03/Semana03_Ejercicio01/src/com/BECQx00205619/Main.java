package com.BECQx00205619;

import java.util.ArrayList;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        String nombre, email, isbn;
        int paginas;
        char genero;
        Scanner scan = new Scanner(System.in);
        int opc = 0, opc1 = 0, opc2 = 0, opc3 = 0;
        ArrayList<Autor> ListaDeAutores = new ArrayList<>();
        ArrayList<Libro> ListaDeLibros = new ArrayList<>();

        do {
            System.out.println("\t\tMenu");
            System.out.println("1) Agregar Libro/Autor");
            System.out.println("2) Eliminar Libro/Autor");
            System.out.println("3) Mostrar Libros/Autores");
            System.out.println("4) Salir");
            opc = scan.nextInt();
            scan.nextLine();

            //Para reducir casos en el menu se usa un switch para dividir libros y autores al querrer mostrar, agregar o eliminar

            switch (opc) {
                case 1:
                    System.out.println("1)  Agregar autor ");
                    System.out.println("2)  Agregar libro ");
                    opc1 = scan.nextInt();
                    scan.nextLine();
                    switch (opc1) {
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
                                    System.out.println("Proceso exitoso");
                                    ListaDeAutores.add(new Autor(nombre, email, genero));
                                }
                            } else
                                System.out.println("El email debe contener @, digite un email valido.");
                            break;
                        case 2:
                            System.out.println("Digite nombre del libro: ");
                            nombre = scan.nextLine();
                            System.out.println("Digite el ISBN del libro: ");
                            isbn = scan.nextLine();
                            System.out.println("Digite paginas: ");
                            paginas = scan.nextInt();
                            ListaDeLibros.add(new Libro(isbn, nombre, paginas));
                            break;
                        default:
                            System.out.println("Numero invalido, intente nuevamente.");
                            break;
                    }
                    break;
                case 2:
                    System.out.println("1)  Eliminar autor ");
                    System.out.println("2)  Eliminar libro ");
                    opc2 = scan.nextInt();
                    scan.nextLine();
                    switch (opc2) {
                        case 1:
                            //Se puede eliminarpor email tambien
                            System.out.println("Eliminar autor: ");
                            System.out.println("Digite el nombre de quien desea eliminar: ");
                            //Se declara aqui para evitar error : java: local variables referenced from a lambda expresion must be final or eectively final
                            String deleteName = scan.nextLine();
                            ListaDeAutores.removeIf(s -> s.getNombre().equalsIgnoreCase(deleteName));
                            break;
                        case 2:
                            //Se puede eliminar por nombre tambien
                            System.out.println("Eliminar libro: ");
                            System.out.println("Digite ISBN del libro que desea eliminar: ");
                            //Se declara aqui para evitar error : java: local variables referenced from a lambda expresion must be final or eectively final
                            String deleteISBN = scan.nextLine();
                            ListaDeLibros.removeIf(s -> s.getISBN().equalsIgnoreCase(deleteISBN));
                            break;
                        default:
                            System.out.println("Numero invalido, intente nuevamente.");
                    }
                    break;
                case 3:
                    System.out.println("1)  Mostrar autores ");
                    System.out.println("2)  Mostrar libros ");
                    opc3 = scan.nextInt();
                    scan.nextLine();
                    switch (opc3) {
                        case 1:
                                ListaDeAutores.forEach(s -> System.out.println(s.toString()));
                            break;
                        case 2:
                                ListaDeLibros.forEach(s -> System.out.println(s.toString()));
                            break;
                        default:
                            System.out.println("Numero invalido, intente nuevamente.");
                    }
                    break;
                case 4:
                    System.out.println("Cerrando programa.......");
                    break;
                default:
                    System.out.println("Numero invalido, intente nuevamente.");
            }
        } while (opc != 4);

    }
}
