package com.BECQx00205619;

public class Libro {
    private String ISBN;
    private String nombre;
    private int paginas;

    public Libro(String ISBN, String nombre, int paginas) {
        this.ISBN = ISBN;
        this.nombre = nombre;
        this.paginas = paginas;
    }

    public String getISBN() {
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
                "ISBN='" + ISBN + '\'' +
                ", nombre='" + nombre + '\'' +
                ", paginas=" + paginas +
                '}';
    }
}
