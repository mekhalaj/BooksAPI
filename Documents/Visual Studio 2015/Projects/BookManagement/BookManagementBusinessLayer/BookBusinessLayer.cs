using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementBusinessObject;
using BookManagementDataAccess;

namespace BookManagementBusinessLayer
{
    public class BookBusinessLayer : IBookBusinessLayer
    {
        private IBookDataAccess _bookDataAccess;

        public BookBusinessLayer()
        {
            _bookDataAccess = new BookDataAccess();
        }

        public async Task<List<Book>> GetBooks()
        {
            return await _bookDataAccess.GetBooks();
        }
    }
}
