package com.BECQx00205619;

public class Laptop {
    private String Color;
    private String SistemaOperativo;

    public Laptop(String ColorLap, String OperatingSystem){
        Color = ColorLap;
        SistemaOperativo = OperatingSystem;
    }

    public String GetterSistemaOperativo(){
        return SistemaOperativo;
    }
    public void SetterSistemaOperativo(String OperatingSystem){
        SistemaOperativo = OperatingSystem;
    }

    public String GetterColor(){
        return Color;
    }
    public void SetterColor(String ColorLap){
        Color = ColorLap;
    }

    public void TurnOn(){
        System.out.println("Sistema operativo: " + SistemaOperativo + "\nColor:  " + Color + " " + "\nEsta encendiendo...");
        System.out.println("Encendio :)");
    }
    public void Entrar(String user){
        System.out.println("Hola  " + user + " bienvenido a tu pc");
        System.out.println("Disfruta utilizando la pc");
    }
    public void TurnOff(){
        System.out.println("Sistema operativo: " + SistemaOperativo + "\nColor:  " + Color + " " + "\nSe va a apagar...");
        System.out.println("Se apago jeje");
    }


}
