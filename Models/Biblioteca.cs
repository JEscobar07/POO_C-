using clase2.Models;
namespace clase3.Models;
public class Biblioteca
{

    //Atributos
    public List<Libro> ListaDeLibros;
    //Constructor
    public Biblioteca()
    {
        ListaDeLibros = new List<Libro>();
    }

    //Metodo
    public void agregarLibro(Libro librito)
    {
        var libroBuscado = ListaDeLibros.Where(item => item.Titulo.Equals(librito.Titulo, StringComparison.OrdinalIgnoreCase)).ToList();
        if (libroBuscado == null)
        {
            mensaje("Lo sentimos pero ya hay un libro con el mismo titulo, ingresa otro diferente. :D");
           
        }
        else
        {
            ListaDeLibros.Add(librito);
            mensaje("Se agrega el libro exitosamente");
        }
    }

    public void eliminarLibro(string titulo)
    {

        var libroBuscado = ListaDeLibros.First(item => item.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        if (libroBuscado != null)
        {
            mensaje("\nEl libro ha sido eliminado exitosamente");
            ListaDeLibros.Remove(libroBuscado);
        }
        else
        {
            mensaje("\nEl libro que deseas eliminar no ha sido encontrado");
        }

    }

    public void buscarLibro(string titulo)
    {
        try
        {
            var libroBuscado = ListaDeLibros.FirstOrDefault(item => item.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (libroBuscado != null)
            {
                mensaje($"\nEl libro {titulo} se encuentra dentro de la biblioteca.\n");
                libroBuscado.DetalleDelLibro();
            }
            else
            {
                mensaje("\nEl libro con el titulo: " + titulo + " NO se encuentra en nuestra biblioteca");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }

    public void DescuentoLibro()
    {
        mensaje("Ingresa el titulo del libro que deseas buscar:");
        string titulo = Console.ReadLine();
        Console.WriteLine($"Ingresa el descuento que quiere aplicar al libro {titulo}:");
        double descuento = Convert.ToDouble(Console.ReadLine());
        bool flag = false;
        foreach (var item in ListaDeLibros)
        {
            if (item.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase))
            {
                item.Precio = item.Precio - (item.Precio * descuento);
                Console.WriteLine($"El nuevo precio de el libro {item.Titulo} es: " + item.Precio);
                flag = true;
            }
        }
        if(flag == false){
            Console.WriteLine($"El libro {titulo} NO existe, ingresa un nombre que exista en nuestra biblioteca.");
        }

    }

    public void ultimos5Años(){
        var milista = ListaDeLibros.Where(parametro => (parametro.AñoDePublicacion.Year >= DateOnly.FromDateTime(DateTime.Now).Year - 5) && (parametro.AñoDePublicacion.Year <= DateOnly.FromDateTime(DateTime.Now).Year)).ToList();
        foreach( var item in milista){
            item.DetalleDelLibro();
        }
    }

    public void buscarPoraños(){
        Console.WriteLine("Ingrese el año:");
        int ano = Convert.ToInt32(Console.ReadLine());
        var lista = ListaDeLibros.Where(item => item.AñoDePublicacion.Year == ano);
        foreach (var item in lista)
        {
            item.DetalleDelLibro();
        }
    }

    public void mensaje(string mensajito)
    {
        Console.WriteLine(mensajito);
    }
}