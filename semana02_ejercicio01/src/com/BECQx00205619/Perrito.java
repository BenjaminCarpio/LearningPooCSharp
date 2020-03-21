package com.BECQx00205619;

public class Perrito {
    private String Nombre;
    private String Edad;

    public Perrito(String NombrePerrito, String EdadPerrito){
        Nombre = NombrePerrito;
        Edad = EdadPerrito;
    }

    public String GetterNombreChucho(){
        return Nombre;
    }
    public void SetterNombreChucho(String NombrePerrito){
        Nombre = NombrePerrito;
    }

    public String GetterEdadChucho(){
        return Edad;
    }
    public void SetterEdadChucho(String EdadPerrito){
        Edad = EdadPerrito;
    }

    public void SaltaElChucho(){
        System.out.println(Nombre + "Está saltando felizmente y no le importa tener " + Edad + " anios de edad sigue alegre! :) ");
        System.out.println(Nombre + "se cansó de tanto saltar :C");
    }
    public void ComeElChucho(String RazaPerrito){
        System.out.println("Ya es hora que " + Nombre + " vaya a comer");
        System.out.println("Los perros de raza " + RazaPerrito + " comen mucho");
    }
    public void AMimirDijoElChucho(){
        System.out.println(Nombre + " está cansado por su alta edad (" + Edad + ") ya es hora de mimir.");
        System.out.println("A mimir JEJE");
    }


}
