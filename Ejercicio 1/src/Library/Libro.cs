using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }


        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }


    }
}
/* 
No se cumple el principio SRP ya que se crea la estantería
de la libreria en un metodo de la clase book y no en una clase aparte.
*/
