using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Controller
{
    
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("Get")]
        public string GetAll()
        {
            return "Hello";
        }
        [Route("GetAuthor")]
        public string GetAllAuthors()
        {
            return "Hello author";
        }
        [Route("book/{id}")]
        public string GetBookId(int id)
        {
            return "Hello"+ id;
        }
        [Route("book/{id}/author/{name}")]
        public string GetBookByAuthorId(int id,int name)
        {
            return "Hello" + id+" Author"+name;
        }
        [Route("search")]
        public string search(int id, string name,float price)
        {
            return "Hello from search "+id+name+price;
        }

    }
}
