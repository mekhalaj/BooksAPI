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
        private IBookBusinessLayer _bookBusinessLayer;

        public BookController()
        {
            _bookBusinessLayer = new BookBusinessLayer();
        }

        public async Task<List<Book>> GetBooks()
        {
            return await _bookBusinessLayer.GetBooks();
        }
    }
}
