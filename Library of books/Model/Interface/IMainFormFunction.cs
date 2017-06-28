using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_of_books.Model.Interface
{
    interface IMainFormFunction
    {
         List<Book> LoadBooks();
         List<Book> SearchByName(string name);
         List<Book> SearchByAuthor(string author);
         List<Book> SearchByPublishingHouse(string publishingHouse);
         List<Book> SearchByPublishingYear(string publishingYear);
         Book SetSelectedBook(int idBook);

         void DeleteBook(int idBook);

         void ChangeBookInfo(Book book);
         void CreateNewBook(Book book);        
    }


}
