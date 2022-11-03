using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebApplication2.Repositories;
using WebApplication2.Entities;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly BookRepository BookRepository;
        public BookController()
        {
            BookRepository = new BookRepository();
        }

        [HttpGet]
        [Route("GetBookByName/{BookName}")]
        public IActionResult GetBookByName(String BookName)
        {
            try
            {
                return StatusCode(200, BookRepository.GetBookByName(BookName));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        //Endpoints
        [HttpGet]
        [Route("GetBookByPublisher/{Publisher}")]
        public IActionResult GetBookByPublisher(String Publisher)
        {
            try
            {
                return StatusCode(200, BookRepository.GetBookByPublisher(Publisher));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        //
        //Endpoints
        [HttpGet]
        [Route("GetBookByAuthor/{Author}")]
        public IActionResult GetBookByAuthor(String Author)
        {
            try
            {
               
                    return StatusCode(200, BookRepository.GetBookByAuthor(Author));
                
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        //
        [HttpDelete]
        [Route("Delete/{BookID}")]
        public IActionResult DeleteBook(int BookID)
        {
            try
            {
                BookRepository.DeleteBook(BookID);
                return StatusCode(200, "Record Deleted");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        //
        [HttpPost]
        [Route("AddBook")]
        public IActionResult AddBook(Book Book)
        {
            try
            {
                BookRepository.AddBook(Book);
                return StatusCode(200, "Record Added");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
        [HttpPut]
        [Route("EditBook")]
        public IActionResult EditBook(Book Book)
        {
            try
            {
                BookRepository.EditBook(Book);
                return StatusCode(200, "Record Updated");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        //

    }
}
