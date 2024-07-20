
//Interfaz

using clase2.Models;
using clase3.Models;

Biblioteca miBiblioteca = new Biblioteca();
miBiblioteca.agregarLibro(new Libro("Aventuras humedas", new DateOnly(2018, 03, 10), "Gabriel Garcia", "Aventura", 6000));
miBiblioteca.agregarLibro(new Libro("Cien años de soledad", new DateOnly(2022, 5, 30), "Gabriel Garcia Marquez", "Realismo mágico", 3500));
miBiblioteca.agregarLibro(new Libro("Harry Potter y la piedra filosofal", new DateOnly(2022, 6, 26), "J.K. Rowling", "Fantasía", 4200));
miBiblioteca.agregarLibro(new Libro("El principito", new DateOnly(2022, 4, 6), "Antoine de Saint-Exupéry", "Literatura infantil", 2800));
miBiblioteca.agregarLibro(new Libro("1984", new DateOnly(2025, 6, 8), "George Orwell", "Distopía", 3000));


try
{
    Console.Clear();
    Console.Write(
    $@"###############################################################################################
#                             SISTEMA DE ANALISIS DE VENTAS                                   #
###############################################################################################
        0.Salir del programa
        1.Agregar un libro.
        2.Buscar libro.
        3.Eliminar un libro.
        4.Ver descripcion de los libros.
        5.Aplicar descuento a libro.
        6.Libros ultimos 5 años.
        7.Libros año de publicacion.
-----------------------------------------------------------------------------------------------
Selecciona una opcion --> ");
    int option = Convert.ToInt32(Console.ReadLine());


    do
    {


        switch (option)
        {
            case 0:
                mensaje("Hasta luego, presiona cualquier tecla para volver al menu principal");
                Console.ReadKey();
                break;
            case 1:
                mensaje("Libro agregado correctamente, presiona cualquier tecla para volver al menu principal");
                Console.ReadKey();
                break;
            case 2:
                mensaje("Ingresa el titulo del libro que deseas buscar:");
                string titulo = Console.ReadLine();
                miBiblioteca.buscarLibro(titulo);
                mensaje("Ingresa cualquier letra para salir");
                Console.ReadKey();
                break;
            case 3:
                mensaje("Ingresa el titulo del libro que deseas buscar:");
                titulo = Console.ReadLine();
                miBiblioteca.eliminarLibro(titulo);
                mensaje("Ingresa cualquier letra para salir");
                Console.ReadKey();
                break;
            case 4:
                foreach (var item in miBiblioteca.ListaDeLibros)
                {
                    item.DetalleDelLibro();
                }
                mensaje("Ingresa cualquier letra para salir");
                Console.ReadKey();
                break;
            case 5:
                miBiblioteca.DescuentoLibro();
                mensaje("Ingresa cualquier letra para salir");
                Console.ReadKey();
                break;
            case 6:
                miBiblioteca.ultimos5Años();
                mensaje("Ingresa cualquier letra para salir");
                Console.ReadKey();
                break;
            case 7:
                miBiblioteca.buscarPoraños();
                mensaje("Ingresa cualquier letra para salir");
                Console.ReadKey();
                break;

        }


    } while (option != 0);
}
catch (Exception ex)
{
    mensaje(ex.Message);
}


void mensaje(string m)
{
    Console.WriteLine(m);
}