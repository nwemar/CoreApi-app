using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpGet]
        [ActionName("GetBookList")]
        public IEnumerable<Book> GetBookList()
        {
            List<Book> book_Lst = new List<Book>();

            for (int i = 0; i < 3; i++)
            {
                Book obj = new Book();
                obj.id = i + 1;
                if (i == 0)
                    obj.Title = "C#";
                if (i == 1)
                    obj.Title = "PHP";
                if (i == 2)
                    obj.Title = "Ruby";
                obj.Price = 500;
                obj.Description = obj.Title + " BOOK";
                book_Lst.Add(obj);
            }
            return book_Lst.ToList();
        }
    }
}
