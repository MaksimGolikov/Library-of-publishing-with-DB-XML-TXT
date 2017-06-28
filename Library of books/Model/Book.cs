using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_of_books.Model
{
     public class Book
    {
       protected int id;
       protected string nameBook;
       private string author;
       private int authorID;
       private string publishingHouse;
       protected string publishingYear;
       private string description;

        public int ID { get => id; set => id =value; }
        public string NameBook { get => nameBook; set => nameBook = value; }
        public string Author { get => author; set => author = value; }
        public string PublishingHouse { get => publishingHouse; set => publishingHouse = value; }
        public string PublishingYear { get => publishingYear; set => publishingYear = value; }
        public string Description { get => description; set => description = value; }
        public int AuthorID { get => authorID; set => authorID = value; }

        public Book()
        {

        }
        public Book(int newID, string newName, string newAuthor)
        {
            id = newID;
            nameBook = newName;
            author = newAuthor;
        }

        public Book(string newName,string newAuthor, string newPublishingHouse,
                    string newPublishingYear, string newDescription, int newId)
        {
            id = newId;
            nameBook = newName;
            author = newAuthor;
            publishingHouse = newPublishingHouse;
            publishingYear = newPublishingYear;
            description = newDescription;
        }

    }
}
