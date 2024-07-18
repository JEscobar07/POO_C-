using clase1.Models;
namespace clase2.Models;
public class Libro : Publicacion{
    
    //Atributos
    public string Autor;
    public string ISBN;
    public char Genero;
    public double Precio;
    
    //Constructor
    public Libro(string _titulo,DateOnly _AñoDePublicacion, string _autor, string _isbn, char _genero, double _precio){
        Id += 1;
        Titulo = _titulo;
        AñoDePublicacion = _AñoDePublicacion;
        Autor = _autor;
        ISBN = _isbn;
        Genero = _genero;
        Precio = _precio;
    }

    //Metodos
    public void DetalleDelLibro(){
        Console.WriteLine($"Datos del libro:\nID: {Id}\nTitulo: {Titulo}\nAño de publicacion: {AñoDePublicacion}\nAutor: {Autor}\nISBN: {ISBN}\nGenero: {Genero}\nPrecio: {Precio}");
    }
}