
//Interfaz

using clase2.Models;
using clase3.Models;

Biblioteca miBiblioteca = new Biblioteca();
do
{
    Console.WriteLine(
$@"###############################################################################################
#                             SISTEMA DE ANALISIS DE VENTAS                                   #
###############################################################################################
        1.Agregar un libro.
        2.Buscar libro.
        3.Eliminar un libro.
        4.Ver descripcion de los libros.
        5.Aplicar descuento a libro.
        6.Libros ultimos 5 años.
        7.Libros año de publicacion.
-----------------------------------------------------------------------------------------------
Selecciona una opcion --> ");
    try
    {
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.Clear();
                Libro libro0 = new Libro("Aventuras humedas", new DateOnly(1998, 03, 10), "Gabriel Garcia", "Aventura", 6000);
                Libro libro1 = new Libro("Cien años de soledad", new DateOnly(1967, 5, 30), "Gabriel Garcia Marquez", "Realismo mágico", 3500);
                Libro libro2 = new Libro("El principito", new DateOnly(1943, 4, 6), "Antoine de Saint-Exupéry", "Literatura infantil", 2800);
                Libro libro3 = new Libro("Harry Potter y la piedra filosofal", new DateOnly(1997, 6, 26), "J.K. Rowling", "Fantasía", 4200);
                Libro libro4 = new Libro("1984", new DateOnly(1949, 6, 8), "George Orwell", "Distopía", 3000);
                miBiblioteca.agregarLibro(libro0);
                miBiblioteca.agregarLibro(libro1);
                miBiblioteca.agregarLibro(libro2);
                miBiblioteca.agregarLibro(libro3);
                miBiblioteca.agregarLibro(libro4);
                break;
            case 2:
                Console.Clear();
                // miBiblioteca.MostrarLibros();
                break;
        }
    }
    catch (Exception)
    {
        Console.WriteLine("El valor esperado es un numero");
    }



} while (true);
