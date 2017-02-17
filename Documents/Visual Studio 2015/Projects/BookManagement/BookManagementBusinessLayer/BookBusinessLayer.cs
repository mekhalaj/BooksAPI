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
        // Dependency injection...
        // It is bad to hardcode the dependency here by creating an object of type BookDataAccess
        // Now we do not have to change the controller if the implementation of BookDataAccess changes
        private IBookDataAccess _bookDataAccess;

        public BookBusinessLayer(IBookDataAccess bda)
        {
            this._bookDataAccess = bda;
        }

        public async Task<List<Book>> GetBooks()
        {
            return await _bookDataAccess.GetBooks();
        }
    }
}
