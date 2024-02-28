using System;

class Lenguaje
{
    private string nombre;
    private int anio;
    public Lenguaje(string nombre, int anio)
    {
        this.nombre = nombre;
        this.anio = anio;
    }


    public void descripcion()
    {
        Console.WriteLine("{0} fiue creado en el año {1}", this.nombre, this.anio);

    }
}