using Library_of_books.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_of_books.Presenter.Interface
{
    interface IMainPrecenter
    {
      void GetAllBooks();
      void GetAllPublish();
      void GetAllMagazine();
      void GetAllNewspaper();
      void GetSelectedBook(int idPublish, string typePublish);
      void GetSelectedArticle(int idPublish, int idArticle, string typePublish);
      void SearchByName(string name);
      void SearchByAuthor(string author);
      void SearchByPublishingHouse(string publishingHouse);
      void SearchByPublishingYear(string publishingYear);
      void SearchByRelease(int release);
      

      void DeleteSelectedBook(int idBook);
      void DeleteSelectedArticle(int idPublish, int idArticle);
      void DeleteSelectedPublish(int idPublish, string typePublish);

      string ChangeBookInfo(Book book);
      string ChangeArticleInfo(int idMagazine, Book book, string typePublish);
      string ChangePublisheInfo(Magazine magazine);

      string CreateNewBook(Book book);
      string CreateNewArticle(int idMagazine, Book book, string typePublish);
      string CreateNewPublish(Magazine magazine);
      string CreateNewPublish(Newspaper magazine);
      string ChangePublisheInfo(Newspaper magazine);
    }
}
