using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Core.Interfaces;

namespace RepositoryPattern.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public BooksController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var book = unitOfWork.Books.GetById(id);
            return Ok(book);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var books = unitOfWork.Books.GetAll();
            return Ok(books);
        }
    }
}
