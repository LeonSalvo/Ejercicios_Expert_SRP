using System;

namespace SRP
{
    public class ShelveBook
    {
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }
        public Book Libro { get ; set; }


        public ShelveBook(String sector, String shelve, Book libro)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
            this.Libro = libro;

        }
    }
}