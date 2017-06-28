using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_of_books.Model.Interface;
using System.IO;

namespace Library_of_books.Model
{
    class NewspaperFunction: INewspaper
    {
        List<Newspaper> newspapers;
        int nextID = 1;
        int nextRelease = 1;



        public NewspaperFunction()
        {
            newspapers = new List<Newspaper>();

            StartConfiguraton();
        }





        public void CreateNewArticle(int magazineID, Book newArticlce)
        {
            for (int i = 0; i < newspapers.Count; i++)
            {
                if (newspapers[i].ID == magazineID)
                {
                    newArticlce.ID = newspapers[i].NextArticleID;
                    newspapers[i].Article.Add(newArticlce);
                    newspapers[i].NextArticleID++;
                    break;
                }
            }
        }
        void INewspaper.ChangeArticleInfo(int magazineID, Book article)
        {
            for (int i = 0; i < newspapers.Count; i++)
            {
                if (newspapers[i].ID == magazineID)
                {
                    for (int j = 0; j < newspapers[i].Article.Count; j++)
                    {
                        if (newspapers[i].Article[j].ID == article.ID)
                        {
                            newspapers[i].Article[j] = article;
                            break;
                        }
                    }
                    break;
                }
            }
        }

        void INewspaper.ChangeMagazinInfo(Newspaper magazine)
        {
            for (int i = 0; i < newspapers.Count; i++)
            {
                if (newspapers[i].ID == magazine.ID)
                {
                    magazine.Article = newspapers[i].Article;
                    newspapers[i] = magazine;
                    break;
                }
            }
        }

        void INewspaper.CreateNewMagazine(Newspaper newspaper)
        {
            newspaper.ID = nextID;
            nextID++;

            newspapers.Add(newspaper);
        }

        void INewspaper.DeleteArticle(int idNewspaper, int idArticle)
        {
            for (int i = 0; i < newspapers.Count; i++)
            {
                if (newspapers[i].ID == idNewspaper)
                {
                    for (int j = 0; j < newspapers[i].Article.Count; j++)
                    {
                        if (newspapers[i].Article[j].ID == idArticle)
                        {
                            newspapers[i].Article.RemoveAt(j);
                            break;
                        }
                    }
                    break;
                }
            }
        }

        void INewspaper.DeleteMagazine(int idNewspaper)
        {
            for (int i = 0; i < newspapers.Count; i++)
            {
                if (newspapers[i].ID == idNewspaper)
                {
                    newspapers.RemoveAt(i);
                    break;
                }
            }
        }

        Book INewspaper.GetSelectedArticle(int idNawspaper, int idArticle)
        {
            var returnedBook = new Book();
            for (int i = 0; i < newspapers.Count; i++)
            {
                if (newspapers[i].ID == idNawspaper)
                {
                    for (int j = 0; j < newspapers[i].Article.Count; j++)
                    {
                        if (newspapers[i].Article[j].ID == idArticle)
                        {
                            returnedBook = newspapers[i].Article[j];
                            break;
                        }
                    }
                    break;
                }
            }
            return returnedBook;
        }

        List<Newspaper> INewspaper.LoadNewspaper()
        {
            return newspapers;
        }

        List<Newspaper> INewspaper.SearchByName(string name)
        {
            var returnedValue = newspapers.FindAll(m => m.NameBook == name);
            return returnedValue;
        }

        List<Newspaper> INewspaper.SearchByPublishingYear(string publishingYear)
        {
            var returnedValue = newspapers.FindAll(m => m.PublishingYear == publishingYear);
            return returnedValue;
        }

        List<Newspaper> INewspaper.SearchByRelease(int release)
        {
            var returnedValue = newspapers.FindAll(m => m.Release == release);
            return returnedValue;
        }

        Newspaper INewspaper.SetSelectedMagazine(int idNewspaper)
        {
            var returnedValue = newspapers.Find(m => m.ID == idNewspaper);
            return returnedValue;
        }




        void INewspaper.ChangeTXTfile()
        {
            
            StreamWriter writer = new StreamWriter("Newspaper.txt");

            foreach (Newspaper n in newspapers)
            {
                writer.WriteLine(FormatingNewspaperToString(n));
                writer.WriteLine("<");
                foreach (Book b in n.Article)
                {
                    writer.WriteLine(FormatingBookToString(b));
                }
                writer.WriteLine(">");
            }
            writer.Close();
        }

        string FormatingNewspaperToString(Newspaper newspaper)
        {
            var returnedLine = newspaper.ID + "|" +
                                newspaper.NameBook + "|" +
                                newspaper.PublishingHouse + "|" +
                                newspaper.PublishingYear + "|" +
                                newspaper.Release;
            return returnedLine;
        }
        string FormatingBookToString(Book book)
        {
            var returnedLine =  book.ID + "|" +
                                book.NameBook + "|" +
                                book.Author + "|" +
                                book.PublishingHouse + "|" +
                                book.PublishingYear + "|" +
                                book.Description;
            return returnedLine;
        }

        private void ReadTXTfile()
        {
            StreamReader reader = new StreamReader("Newspaper.txt");
          
            var newArticle = false;
            string readData = "";

            while ( (readData = reader.ReadLine()) !=null)
            {
                if(readData == "<" || readData == ">")
                {
                    newArticle = !newArticle;
                    continue;
                }

                if (!newArticle)
                {
                    newspapers.Add(FormatingStringToNewspaper(readData));
                }
                if (newArticle)
                {
                    newspapers[newspapers.Count - 1].Article.Add(FormatingStringToBook(readData));
                }
            }           

            reader.Close();
            
        }
        Book FormatingStringToBook(string book)
        {
            var line = book.Split('|');

            var returdedBook = new Book();
            returdedBook.ID = Int32.Parse( line[0]);
            returdedBook.NameBook = line[1];
            returdedBook.Author = line[2];
            returdedBook.PublishingHouse = line[3];
            returdedBook.PublishingYear = line[4];
            returdedBook.Description = line[5]; 
            
            return returdedBook;
        }
        Newspaper FormatingStringToNewspaper(string str)
        {
            var line = str.Split('|');

            var returdedBook = new Newspaper();
            returdedBook.ID = Int32.Parse(line[0]);
            returdedBook.NameBook = line[1];
            returdedBook.PublishingHouse = line[2];
            returdedBook.PublishingYear = line[3];
            returdedBook.Release = Int32.Parse(line[4]);
            returdedBook.Article = new List<Book>();

            return returdedBook;
        }

        private void StartConfiguraton()
        {
            bool existXMLfile = File.Exists("Newspaper.txt");
            if (existXMLfile)
            {
                ReadTXTfile();
            }
            if (!existXMLfile)
            {
                newspapers.Add(new Newspaper(nextID, nextRelease, "NewspaperName 1", "2012", "Description Newspaper 1", new List<Book>()));
                CreateNewArticle(1, new Book("Newspaper Artic 1", "Artic author 1", "", newspapers[0].PublishingYear, "Descropt ", newspapers[0].NextArticleID));
                CreateNewArticle(1, new Book("Newspaper Artic 2", "Artic author 2", "", newspapers[0].PublishingYear, "Descropt ", newspapers[0].NextArticleID));
                nextID++;
                nextRelease++;

                newspapers.Add(new Newspaper(nextID, nextRelease, "NewspaperName 2", "2017", "Description Newspaper 2", new List<Book>()));
                CreateNewArticle(2, new Book("Newspaper Artic 3", "Artic author 3", "", newspapers[1].PublishingYear, "Descropt ", newspapers[1].NextArticleID));
                CreateNewArticle(2, new Book("Newspaper Artic 4", "Artic author 4", "", newspapers[1].PublishingYear, "Descropt ", newspapers[1].NextArticleID));
                CreateNewArticle(2, new Book("Newspaper Artic 5", "Artic author 5", "", newspapers[1].PublishingYear, "Descropt ", newspapers[1].NextArticleID));
                nextID++;
                nextRelease++;
            }


        }



    }
}
