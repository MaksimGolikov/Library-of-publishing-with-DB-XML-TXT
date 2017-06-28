using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_of_books.Model.Interface;

using System.Data;
using System.Data.SqlClient;


namespace Library_of_books.Model
{
    class MainFormFunction:IMainFormFunction
    {
        List<Book> Books;
        int nextID = 1;

        SqlConnection connect;
        SqlCommand command;
        SqlDataReader reader;


        public MainFormFunction()
        {
            connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MaGol\\Documents\\TEST.mdf;Integrated Security=True;Connect Timeout=30");
            command = new SqlCommand();
            command = connect.CreateCommand();


            Books = new List<Book>();           
            
            ReadDB();
          
        }


        List<Book> IMainFormFunction.LoadBooks()
        {
            ReadDB();
            return Books;
        }

        List<Book> IMainFormFunction.SearchByName(string name)
        {           
            Books.Clear();
            try
            {
                command.CommandText = "SELECT * From  Book INNER JOIN Author ON Book.IdAuthor=Author.IdAuthor WHERE NameBook LIKE '" + name + "'";
                command.CommandType = CommandType.Text;
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Book newBook = new Book();

                    newBook.AuthorID = Convert.ToInt32(reader["IdAuthor"]);
                    newBook.Author = reader["NameAuthor"].ToString();
                    newBook.NameBook = reader["NameBook"].ToString();
                    newBook.PublishingHouse = reader["PublishingHouse"].ToString();
                    newBook.PublishingYear = reader["PublishingYear"].ToString();
                    newBook.Description = reader["Description"].ToString();
                    newBook.ID = Convert.ToInt32(reader["IdBook"]);

                    Books.Add(newBook);
                }

            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
            return Books;
        }
        List<Book> IMainFormFunction.SearchByAuthor(string author)
        {
            Books.Clear();
            try
            {
                command.CommandText = "SELECT * From  Author INNER JOIN Book ON Author.IdAuthor=Book.IdAuthor WHERE NameAuthor LIKE '" + author + "'";
                command.CommandType = CommandType.Text;
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Book newBook = new Book();

                    newBook.AuthorID = Convert.ToInt32(reader["IdAuthor"]);
                    newBook.Author = reader["NameAuthor"].ToString();
                    newBook.NameBook = reader["NameBook"].ToString();
                    newBook.PublishingHouse = reader["PublishingHouse"].ToString();
                    newBook.PublishingYear = reader["PublishingYear"].ToString();
                    newBook.Description = reader["Description"].ToString();
                    newBook.ID = Convert.ToInt32(reader["IdBook"]);

                    Books.Add(newBook);
                }

            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
            return Books;
        }
        List<Book> IMainFormFunction.SearchByPublishingHouse(string publishingHouse)
        {
            Books.Clear();
            try
            {
                command.CommandText = "SELECT * From  Book INNER JOIN Author ON Book.IdAuthor=Author.IdAuthor WHERE PublishingHouse LIKE '" + publishingHouse + "'";
                command.CommandType = CommandType.Text;
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Book newBook = new Book();

                    newBook.AuthorID = Convert.ToInt32(reader["IdAuthor"]);
                    newBook.Author = reader["NameAuthor"].ToString();
                    newBook.NameBook = reader["NameBook"].ToString();
                    newBook.PublishingHouse = reader["PublishingHouse"].ToString();
                    newBook.PublishingYear = reader["PublishingYear"].ToString();
                    newBook.Description = reader["Description"].ToString();
                    newBook.ID = Convert.ToInt32(reader["IdBook"]);

                    Books.Add(newBook);
                }

            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
            return Books;
        }
        List<Book> IMainFormFunction.SearchByPublishingYear(string publishingYear)
        {
            Books.Clear();
            try
            {
                command.CommandText = "SELECT * From  Book INNER JOIN Author ON Book.IdAuthor=Author.IdAuthor WHERE PublishingYear LIKE '" + publishingYear + "'";
                command.CommandType = CommandType.Text;
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Book newBook = new Book();

                    newBook.AuthorID = Convert.ToInt32(reader["IdAuthor"]);
                    newBook.Author = reader["NameAuthor"].ToString();
                    newBook.NameBook = reader["NameBook"].ToString();
                    newBook.PublishingHouse = reader["PublishingHouse"].ToString();
                    newBook.PublishingYear = reader["PublishingYear"].ToString();
                    newBook.Description = reader["Description"].ToString();
                    newBook.ID = Convert.ToInt32(reader["IdBook"]);

                    Books.Add(newBook);
                }

            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
            return Books;
        }

        Book IMainFormFunction.SetSelectedBook(int idBook)
        {
            var newBook = new Book();
            try
            {
                command.CommandText = "SELECT * From  Book INNER JOIN Author ON Book.IdAuthor=Author.IdAuthor WHERE IdBook LIKE '" + idBook + "'";
                command.CommandType = CommandType.Text;
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    newBook.AuthorID = Convert.ToInt32(reader["IdAuthor"]);
                    newBook.Author = reader["NameAuthor"].ToString();
                    newBook.NameBook = reader["NameBook"].ToString();
                    newBook.PublishingHouse = reader["PublishingHouse"].ToString();
                    newBook.PublishingYear = reader["PublishingYear"].ToString();
                    newBook.Description = reader["Description"].ToString();
                    newBook.ID = Convert.ToInt32(reader["IdBook"]);
                }

            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
            return newBook; ;
        }
        
        void IMainFormFunction.DeleteBook(int idBook)
        {
            try
            {
                command.CommandText = "DELETE FROM Book WHERE IdBook ='" + idBook + "'";
                command.CommandType = CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

        void IMainFormFunction.ChangeBookInfo(Book book)
        {            
            ChangeData(book);           
        }
        void IMainFormFunction.CreateNewBook(Book book)
        {
            CreateBook(book);
        }


        void ReadDB()
        {
            Books.Clear();
            try
            {
                command.CommandText = "SELECT * From  Book INNER JOIN Author ON Book.IdAuthor=Author.IdAuthor";
                command.CommandType = CommandType.Text;
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();                

                while (reader.Read())
                {
                    Book newBook = new Book();

                    newBook.AuthorID = Convert.ToInt32(reader["IdAuthor"]);
                    newBook.Author = reader["NameAuthor"].ToString();
                    newBook.NameBook = reader["NameBook"].ToString();
                    newBook.PublishingHouse = reader["PublishingHouse"].ToString();
                    newBook.PublishingYear = reader["PublishingYear"].ToString();
                    newBook.Description = reader["Description"].ToString();
                    newBook.ID = Convert.ToInt32(reader["IdBook"]);
                    
                    Books.Add(newBook);
                }

            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }

        }

        void CreateBook(Book book)
        {
            var idAuthor = GetAuthorIdByName(book.Author);

            try
            {
                connect.Open();                                
                if(idAuthor == 0)
                {
                    command.CommandText = "INSERT INTO Author (NameAuthor) " +
                                          "VALUES('" + book.Author + "')";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();

                    command.CommandText = "SELECT * From  Author WHERE NameAuthor LIKE '" + book.Author + "'";
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        idAuthor = Convert.ToInt32(reader["IdAuthor"]);
                    }                   
                }
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }

            try
            {
                connect.Open();
                command.Connection = connect;
                command.CommandText = "INSERT INTO Book (NameBook, IdAuthor, PublishingHouse, PublishingYear, Description) " +
                                      "VALUES('" + book.NameBook + "','" + idAuthor + "','" + book.PublishingHouse + "'," +
                                      "'" + book.PublishingYear + "','" + book.Description + "')";
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

        int GetAuthorIdByName(string nameAuthor)
        {
            int returnedName = 0;

            try
            {
                command.CommandText = "SELECT * From  Author WHERE NameAuthor LIKE '" + nameAuthor+"'";
                command.CommandType = CommandType.Text;
                connect.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    returnedName = Convert.ToInt32(reader["IdAuthor"]);
                }
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
            return returnedName;

        }
        string GetAuthorNameById(int idAuthor)
        {
            var returnedName = "";

            try
            {
                command.CommandText = "SELECT * From  Author WHERE IdAuthor LIKE '" + idAuthor + "'";
                command.CommandType = CommandType.Text;
                connect.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    returnedName = reader["NameAuthor"].ToString();
                }
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
            return returnedName;

        }
        void ChangeData(Book book)
        {
            var oldBook = Books.Find(b => b.ID == book.ID);
            var idAuthor = GetAuthorIdByName(book.Author);
            
            if (idAuthor == 0)
            {
                command.CommandText = "INSERT INTO Author (NameAuthor) " +
                                         "VALUES('" + book.Author + "')";
                command.CommandType = CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
                idAuthor = GetAuthorIdByName(book.Author);               
            }
            book.AuthorID = idAuthor;


            try
            {                
                command.CommandText = "UPDATE Book SET NameBook= '" + book.NameBook + "', PublishingHouse= '" + book.PublishingHouse + "', " +
                                                      "PublishingYear= '" + book.PublishingYear + "', Description= '" + book.Description + "', " +
                                                      "IdAuthor= '" + book.AuthorID +"' WHERE IdBook ='" + book.ID + "'";
                command.CommandType = CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();              
               
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

    }
}
