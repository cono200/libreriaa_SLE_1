using libreriaa_SLE.Data.Models;
using libreriaa_SLE.Data.ViewModels;
using System;

namespace libreriaa_SLE.Data.Services
{
    public class PublishersService
    {
        private AppDbContext _context;
        public PublishersService(AppDbContext context)
        {

            _context = context;

        }

        //METODO QUE NOS PERMITE AGREGAR UNA NUEVA EDITORA EN LA BD


        public void AddPublisher(PublisherVM publisher)
        {
            var _publisher = new Publisher()
            {
                Name = publisher.Name
            };

            _context.Publisher.Add(_publisher);
            _context.SaveChanges();
        }

    }
}
