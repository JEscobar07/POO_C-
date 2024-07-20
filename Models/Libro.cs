using clase1.Models;
namespace clase2.Models;
public class Libro : Publicacion{
    
    //Atributos
    public Guid ISBN;
    public string Autor;
    public string Genero;
    public double Precio;
    
    //Constructor
    public Libro(string _titulo,DateOnly _AñoDePublicacion, string _autor, string _genero, double _precio){
        ISBN = Guid.NewGuid();
        Titulo = _titulo;
        AñoDePublicacion = _AñoDePublicacion;
        Autor = _autor;
        Genero = _genero;
        Precio = _precio;
    }

    //Metodos
    public void DetalleDelLibro(){
        Console.WriteLine($"\nDatos del libro:\nID: {ISBN}\nTitulo: {Titulo}\nAño de publicacion: {AñoDePublicacion}\nAutor: {Autor}\nISBN: {ISBN}\nGenero: {Genero}\nPrecio: {Precio}\n");
    }
}