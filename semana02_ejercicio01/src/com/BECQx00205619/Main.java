package com.BECQx00205619;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        System.out.println("Seleccione que mostrar en pantalla: \n1) Laptop \n2) Perrito" );
        System.out.print("Opcion elegida: ");
        byte n = scan.nextByte(); scan.nextLine();

        switch (n) {
            case 1:
                Laptop Lenovo = new Laptop("Gris", "Windows");

                Lenovo.TurnOn();
                Lenovo.Entrar("TeemoExplorador");
                Lenovo.TurnOff();

                System.out.println("Ejecutando nuevamente,cambiando los atributos.......");

                Lenovo.SetterColor("Negra con RGB");
                Lenovo.SetterSistemaOperativo("MAC");

                Lenovo.TurnOn();
                Lenovo.Entrar("CapitanTeemo");
                Lenovo.TurnOff();
                break;

            case (2):

                Perrito MiChucho = new Perrito("Firulais", "7");

                MiChucho.SaltaElChucho();
                MiChucho.ComeElChucho("GoldenRetriever");
                MiChucho.AMimirDijoElChucho();

                System.out.println("Ejecutando nuevamente, cambiando los atributos.......");

                MiChucho.SetterNombreChucho("Osito");
                MiChucho.SetterEdadChucho("3");

                MiChucho.SaltaElChucho();
                MiChucho.ComeElChucho("Pastor Aleman");
                MiChucho.AMimirDijoElChucho();
                break;

        }

    }
}
