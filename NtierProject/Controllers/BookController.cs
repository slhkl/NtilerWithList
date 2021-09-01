using Microsoft.AspNetCore.Mvc;
using Data.Models;
using Business;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        BookBusiness bookBusiness = new BookBusiness();

        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(bookBusiness.GetAllCheck());
        }

        [HttpGet("{index}")]
        public JsonResult Get(int index)
        {
            return new JsonResult(bookBusiness.GetCheck(index));
        }

        [HttpPost]
        public JsonResult AddList(Book book)
        {
            return new JsonResult(bookBusiness.AddListCheck(book));
        }

        [HttpDelete("RemoveList/{index}")]

        public JsonResult RemoveList(int index)
        {
            return new JsonResult(bookBusiness.RemoveListCheck(index));
        }

        [HttpDelete("RemoveFromYazarName/{name}")]

        public JsonResult RemoveFromYazarName(string name)
        {

            return new JsonResult(bookBusiness.RemoveFromName(name));
        }

        [HttpDelete("RemoveFromYazarId/{yazarId}")] 

        public JsonResult RemoveFromYazarId (int yazarID)
        {
            return new JsonResult(bookBusiness.RemoveFromYazarId(yazarID));
        }
        [HttpDelete("RemoveFromBookShelf/{bookShelf}")]

        public JsonResult RemoveFromBookShelf(string bookShelf)
        {
            return new JsonResult(bookBusiness.RemoveFromBookShelf(bookShelf));
        }



    }
}
