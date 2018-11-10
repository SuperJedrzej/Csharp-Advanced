using System.Collections.Generic;

namespace Lambda
{
    public class BookRepository
    { 

        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "TItle 1", Price = 5},
                new Book() {Title = "TItle 2", Price = 7},
                new Book() {Title = "TItle 3", Price = 12}
            };
        }
    }
}
