using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_of_books.Model.Interface;

namespace Library_of_books.Model
{
    class Newspaper:Book
    {
        int release;
        int nextArticleID;
        List<Book> article;
        public int Release { get => release; set => release = value; }
        public List<Book> Article { get => article; set => article = value; }
        public int NextArticleID { get => nextArticleID; set => nextArticleID = value; }
        

        public Newspaper()
        {

        }

        public Newspaper(int newID, int newRelease, string newName, string newPublishYear, string newDescription, List<Book> newArticle)
        {
            id = newID;
            nameBook = newName;
            publishingYear = newPublishYear;
            Description = newDescription;
            release = newRelease;
            article = newArticle;
            nextArticleID = 0;
        }


    }
}
