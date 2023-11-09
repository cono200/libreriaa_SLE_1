using libreriaa_SLE.Data.ViewModels;
using libreriaa_SLE.Data.Models;
using libreriaa_SLE.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace libreriaa_SLE.Data.Services
{
    public class BooksServicecs
    {
        private AppDbContext _context;
        public BooksServicecs(AppDbContext context)
        {

            _context = context;

        }


        //METODO QUE NOS PERMITE AGREGAR UN NUEVO LIBRO EN LA BD


        public void AddBook(BookVM book)
        {
            var _book = new Books()
            {
                Titulo = book.Titulo,
                Descripcion = book.Descripcion,
                IsRead = book.IsRead,
                DateRead = book.DateRead,
                Rate = book.Rate,
                Genero = book.Genero,
                Autor = book.Autor,
                CoverUrl = book.CoverUrl,
                DateAdded = DateTime.Now
            };

            _context.Books.Add(_book);
            _context.SaveChanges();
        }
        //METODO QUE NOS PERMITE OBTENER UNA LISTA DE TODOS LOS  LIBRO EN LA BD


        public List<Books> GetAllBks() => _context.Books.ToList();
        //METODO QUE NOS PERMITE OBTENER EL LIBRO QUE ESTAMOS PIDIDIENDO EN LA BASE DE DATOS
        public Books GetBooksById(int bookid) => _context.Books.FirstOrDefault(n => n.id == bookid);
        //METODO QUE NOS PERMITE  MODIFICAR UNA LIBRO QUE SE ENCUENTRA EN LA BASE DE DATOS


        public Books UpdateBookByID(int bookid, BookVM book)
        {
            var _book = _context.Books.FirstOrDefault(n =>n.id == bookid);
            if (_book != null)
            {
                _book.Titulo = book.Titulo;
                _book.Descripcion = book.Descripcion;
                _book.IsRead = book.IsRead;
                _book.DateRead = book.DateRead;
                _book.Rate = book.Rate;
                _book.Genero = book.Genero;
                _book.Autor = book.Autor;
                _book.CoverUrl = book.CoverUrl;


                _context.SaveChanges();
            }
            return _book;
        }


        public void DeleteBookById(int bookid)
        {
            var _book = _context.Books.FirstOrDefault(n => n.id == bookid);
            if (_book != null)
            {
                _context.Books.Remove(_book);
                _context.SaveChanges();
            }



        }



    }
}
