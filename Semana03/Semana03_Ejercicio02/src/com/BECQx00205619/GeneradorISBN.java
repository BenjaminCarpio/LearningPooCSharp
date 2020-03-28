package com.BECQx00205619;

public final class GeneradorISBN{
    private static int contador = 0;

    private GeneradorISBN() {}

    public static int nuevoISBN(){
        contador++;
        return contador;
    }
}