using clase2.Models;
namespace clase3.Models;
public class Biblioteca{
    
    //Atributos
    List<Libro> ListaDeLibros;
    //Constructor
    public Biblioteca( List<Libro> _ListaDeLibros){
        ListaDeLibros = _ListaDeLibros;
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

    public void DescuentoLibro(){
        var libroBuscado = ListaDeLibros.
    }

    public void mensaje(string mensajito){
        Console.WriteLine(mensajito);
    }
}