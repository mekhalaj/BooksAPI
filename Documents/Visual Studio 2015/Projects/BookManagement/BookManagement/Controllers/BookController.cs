using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BookManagementBusinessLayer;
using BookManagementBusinessObject;
using System.Threading.Tasks;

namespace BookManagement.Controllers
{
    public class BookController : ApiController
    {
        // Dependency injection...
        // It is bad to hardcode the dependency here by creating an object of type BookBusinessLayer
        // Now we do not have to change the controller if the implementation of BookBusinessLayer changes
        private IBookBusinessLayer _bookBusinessLayer;

        public BookController(IBookBusinessLayer bbl)
        {
            this._bookBusinessLayer = bbl;
        }

        public async Task<List<Book>> GetBooks()
        {
            return await _bookBusinessLayer.GetBooks();
        }
    }
}
