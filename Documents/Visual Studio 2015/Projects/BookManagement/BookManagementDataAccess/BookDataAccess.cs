using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementBusinessObject;

namespace BookManagementDataAccess
{
    public class BookDataAccess : IBookDataAccess
    {
        public BookDataAccess()
        {

        }

        public async Task<List<Book>> GetBooks()
        {
            List<Book> list = new List<Book>();
            list.Add(new Book() { BookId = 1, Name = "book1", Edition = "edition1", Format = "format1", ISBN = "ISBN1", Pages = 111 });
            list.Add(new Book() { BookId = 2, Name = "book2", Edition = "edition2", Format = "format2", ISBN = "ISBN2", Pages = 222 });
            list.Add(new Book() { BookId = 3, Name = "book3", Edition = "edition3", Format = "format3", ISBN = "ISBN3", Pages = 333 });
            list.Add(new Book() { BookId = 4, Name = "book4", Edition = "edition4", Format = "format4", ISBN = "ISBN4", Pages = 444 });
            return list;
        }
    }
}
