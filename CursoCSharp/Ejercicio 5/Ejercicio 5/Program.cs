using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Book> Books = Book.Books();
            List<Author> Authors = Author.Books();

            /*******Ejercicio 1******/

            Console.WriteLine("Libros con mas Ventas");
            var ejercicio1 = (from b in Books
                              orderby b.Sales descending
                              select new
                              {
                                  titulo = b.Title,
                                  autor = b.AuthorId,
                                  fechaP = b.PublicationDate,
                                  ventas = b.Sales
                              }
                                ).ToList().Take(3);

            foreach (var b in ejercicio1)
            {
                Console.WriteLine("Titulo: " + b.titulo + " Ventas: " + b.ventas);
            }

            Console.WriteLine("\n");
            /*******Ejercicio 2******/

            Console.WriteLine("Libros con menos Ventas");
            var ejercicio2 = (from b in Books
                              orderby b.Sales ascending
                              select new
                              {
                                  titulo = b.Title,
                                  autor = b.AuthorId,
                                  fechaP = b.PublicationDate,
                                  ventas = b.Sales
                              }
                                ).ToList().Take(3);

            foreach (var b in ejercicio2)
            {
                Console.WriteLine("Titulo: " + b.titulo + " Ventas: " + b.ventas);
            }

            Console.WriteLine("\n");
            /*******Ejercicio 3******/


            Console.WriteLine("Autor con mas libros publicados");
            var ejercicio3 = (from b in Books group b by b.AuthorId into grupo select grupo

                                ).ToList();

            int mayor = 0;
            int idNombreAutor = 0;
            foreach (var grupo in ejercicio3)
            {
  
                foreach (var objetoAgrupado in grupo)
                {

                    if (grupo.Count() > mayor)
                    {
                        mayor = grupo.Count();
                        idNombreAutor = objetoAgrupado.AuthorId;
                    }
                }
            }

            var nombreAuthor = from a in Authors where a.AuthorId == idNombreAutor select a;

            foreach (var name in nombreAuthor)   
                Console.WriteLine("El Autor con mas libros Publicados: {0}", name.Name);


            Console.WriteLine("\n");
            /*******Ejercicio 4******/

            Console.WriteLine("Autor con la cantidad de libros publicados");

            var ejercicio4 = (from b in Books group b by b.AuthorId into grupo select grupo

                                ).ToList();

            //int mayor4 = 0;
            int currentId = 0;
            foreach (var grupo in ejercicio4)
            {

                foreach (var objetoAgrupado in grupo)
                {

                    //Evitamos que los registros se dupliquen
                    if(currentId != objetoAgrupado.AuthorId)
                    {
                        currentId = objetoAgrupado.AuthorId;

                        var nombreAuthor_ = from a in Authors where a.AuthorId == currentId select a;

                        foreach (var name in nombreAuthor_)
                            Console.WriteLine("El Autor " + name.Name + ", Tiene " + grupo.Count() + " Libro(s) Publicado(s)");

                    }
                }
            }

            Console.WriteLine("\n");
            /*******Ejercicio 6******/
            Console.WriteLine("Libros publicados hace menos de 50 años");
            var ejercicio6 = from b in Books where b.PublicationDate > 1972 select b;

            foreach (var b in ejercicio6)
            {
                Console.WriteLine("Titulo: " + b.Title + " Fecha Publicacion: " + b.PublicationDate);
            }


            Console.WriteLine("\n");
            /*******Ejercicio 7******/
            Console.WriteLine("Libro mas Viejo");

            var ejercicio7 = (from b in Books
                              orderby b.PublicationDate ascending
                              select new
                              {
                                  titulo = b.Title,
                                  autor = b.AuthorId,
                                  fechaP = b.PublicationDate,
                                  ventas = b.Sales
                              }
                                ).ToList().Take(1);

            foreach (var b in ejercicio7)
            {
                Console.WriteLine("Titulo: " + b.titulo + " Año: " + b.fechaP);
            }

            Console.WriteLine("\n");
            /*******Ejercicio 8******/
            Console.WriteLine("Libro que comiencen con la palabra 'EL'");

            //Case Sensitive
            var ejercicio8 = (from b in Books where b.Title.StartsWith("El") select b).ToList();

            foreach (var b in ejercicio8)
            {   

                //Console.WriteLine(b.Title);

                var nombreA = from a in Authors where a.AuthorId == b.AuthorId select a;

                foreach (var name in nombreA)
                    Console.WriteLine(b.Title + " by " + name.Name);
            }

            Console.Read();
        }
    }
}
