using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementBusinessObject;

namespace BookManagementBusinessLayer
{
    public interface IBookBusinessLayer
    {
        Task<List<Book>> GetBooks();

    }
}
