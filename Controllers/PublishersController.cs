using libreriaa_SLE.Data.Services;
using libreriaa_SLE.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace libreriaa_SLE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private PublishersService _publishersServices;

        public PublishersController(PublishersService publishersServices)
        {
            _publishersServices = publishersServices;
        }


        [HttpPost("add-publisher")]
        public IActionResult AddPublisher([FromBody] PublisherVM  publisher)
        {
            _publishersServices.AddPublisher(publisher);
            return Ok();
        }
    }
}
