using libreriaa_SLE.Data.Models;
using libreriaa_SLE.Data.ViewModels;
using System;

namespace libreriaa_SLE.Data.Services
{
    public class AuthorService
    {
        private AppDbContext _context;
        public AuthorService(AppDbContext context)
        {

            _context = context;

        }

        //METODO QUE NOS PERMITE AGREGAR UN NUEVO AUTOR EN LA BD


        public void AddAuthor(AuthorVM author)
        {
            var _author = new Author()
            {
                FullName = author.FullName
            };

            _context.Authors .Add(_author);
            _context.SaveChanges();
        }

    }
}
