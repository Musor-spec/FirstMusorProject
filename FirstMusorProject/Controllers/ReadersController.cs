using FirstMusorProject.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstMusorProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadersController : ControllerBase
    {
        private readonly LibraryDbContext _context;

        public ReadersController(LibraryDbContext context)
        {
            _context = context;
        }


    }
}
