package com.BECQx00205619;

public class Libro {
    private int ISBN;
    private String nombre;
    private int paginas;

    public Libro(String nombre, int paginas) {
        this.nombre = nombre;
        this.paginas = paginas;
        this.ISBN = GeneradorISBN.nuevoISBN();
    }

    public int getISBN() {
        return ISBN;
    }

    public String getNombre() {
        return nombre;
    }

    public int getPaginas() {
        return paginas;
    }

    @Override
    public String toString() {
        return "Libro{" +
                "ISBN:'" + ISBN + '\'' +
                ", nombre: '" + nombre + '\'' +
                ", paginas: " + paginas +
                '}';
    }

}