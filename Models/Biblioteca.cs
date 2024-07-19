using clase2.Models;
namespace clase3.Models;
public class Biblioteca{
    
    //Atributos
    List<Libro> ListaDeLibros;
    //Constructor
    public Biblioteca( ){
        ListaDeLibros = new List<Libro>();
    }

    //Metodo
    public void agregarLibro(Libro librito){
        var libroBuscado = ListaDeLibros.Where(item => item.Titulo.Equals(librito.Titulo,StringComparison.OrdinalIgnoreCase)).ToList();
        if( libroBuscado == null){
            mensaje("Se agrega el libro exitosamente");
            ListaDeLibros.Add(librito);
        }else{
            mensaje("Lo sentimos pero ya hay un libro con el mismo titulo, ingresa otro diferente. :D");
        }
    }

    public void eliminarLibro(Libro librito){
        
        var libroBuscado = ListaDeLibros.Where(item => item.Titulo.Equals(librito.Titulo,StringComparison.OrdinalIgnoreCase)).ToList();
        if( libroBuscado != null){
            mensaje("El libro ha sido eliminado exitosamente");
            ListaDeLibros.Remove(librito);
        }else{
            mensaje("El libro que deseas eliminar no ha sido encontrado");
        }

    }

    public void buscarLibro(Libro librito){

        var libroBuscado = ListaDeLibros.Where(item => item.Titulo.Equals(librito.Titulo,StringComparison.OrdinalIgnoreCase));
        if( libroBuscado != null){
            mensaje($"El libro {librito.Titulo} se encuentra dentro de la biblioteca");
        }else{
            mensaje("El li");
        }
    }

    public void DescuentoLibro(Libro librito){
        Console.WriteLine("Ingresa el descuento:");
        double descuento = Convert.ToDouble(Console.ReadLine());
        foreach (var item in ListaDeLibros)
        {
            if(item.Titulo.Equals(librito.Titulo,StringComparison.OrdinalIgnoreCase)){
                item.Precio = item.Precio - (item.Precio * descuento);
                Console.WriteLine($"El nuevo precio de el libro {item.Titulo} es: "+ item.Precio);
            }
        }

    }

    public void mensaje(string mensajito){
        Console.WriteLine(mensajito);
    }
}