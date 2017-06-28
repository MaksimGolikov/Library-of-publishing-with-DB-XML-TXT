using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_of_books.Model.Interface;
using System.IO;
using System.Xml.Serialization;


namespace Library_of_books.Model
{
    class MagazineFunction: IMagazine
    {

        List<Magazine> magazines;
        int nextID = 1;
        int nextRelease = 1;



        public MagazineFunction()
        {
            magazines = new List<Magazine>();

            StartConfiguraton();
        }


        


         public void CreateNewArticle(int magazineID, Book newArticlce)
        {
            for (int i = 0; i < magazines.Count; i++)
            {
                if (magazines[i].ID == magazineID)
                {
                    newArticlce.ID = magazines[i].NextArticleID;
                    magazines[i].Article.Add(newArticlce);
                    magazines[i].NextArticleID++;
                    break;
                }
            }
        }
         void IMagazine.ChangeArticleInfo(int magazineID, Book article)
        {
            for (int i = 0; i < magazines.Count; i++)
            {
                if (magazines[i].ID == magazineID)
                {
                    for (int j = 0; j < magazines[i].Article.Count; j++)
                    {
                        if (magazines[i].Article[j].ID == article.ID)
                        {
                            magazines[i].Article[j] = article;
                            break;
                        }
                    }
                    break;
                }
            }
        }

         void IMagazine.ChangeMagazinInfo(Magazine magazine)
        {
            for (int i = 0; i < magazines.Count; i++)
            {
                if (magazines[i].ID == magazine.ID)
                {                 
                    magazine.Article = magazines[i].Article;
                    magazines[i] = magazine;
                    break;
                }
            }
        }
                
         void IMagazine.CreateNewMagazine(Magazine magazine)
        {
            magazine.ID = nextID;         
            nextID++;

            magazines.Add(magazine);          
        }

         void IMagazine.DeleteArticle(int idMagazine, int idArticle)
        {
            for (int i = 0; i < magazines.Count; i++)
            {
                if (magazines[i].ID == idMagazine)
                {
                    for(int j=0;j< magazines[i].Article.Count;j++)
                    {
                        if (magazines[i].Article[j].ID == idArticle)
                        {
                            magazines[i].Article.RemoveAt(j);
                            break;
                        }                       
                    }                   
                    break;
                }
            }                        
        }

         void IMagazine.DeleteMagazine(int idMagazine)
        {
            for (int i=0;i<magazines.Count;i++)
            {
                if (magazines[i].ID == idMagazine)
                {
                    magazines.RemoveAt(i);
                    break;
                }
            }
        }

         Book IMagazine.GetSelectedArticle(int idMagazine, int idArticle)
        {
            var returnedBook = new Book();
            for (int i = 0; i < magazines.Count; i++)
            {
                if (magazines[i].ID == idMagazine)
                {
                    for (int j = 0; j < magazines[i].Article.Count; j++)
                    {
                        if (magazines[i].Article[j].ID == idArticle)
                        {
                            returnedBook =  magazines[i].Article[j];
                            break;
                        }
                    }
                    break;
                }
            }
            return returnedBook;
        }

         List<Magazine> IMagazine.LoadMagazines()
        {
            return magazines;
        }

         List<Magazine> IMagazine.SearchByName(string name)
        {
            var returnedValue = magazines.FindAll(m => m.NameBook == name);
            return returnedValue;
        }

         List<Magazine> IMagazine.SearchByPublishingYear(string publishingYear)
        {
            var returnedValue = magazines.FindAll(m => m.PublishingYear == publishingYear);
            return returnedValue;
        }

         List<Magazine> IMagazine.SearchByRelease(int release)
        {
            var returnedValue = magazines.FindAll(m => m.Release == release);
            return returnedValue;
        }

         Magazine IMagazine.SetSelectedMagazine(int idMagazine)
        {
            var returnedValue = magazines.Find(m => m.ID == idMagazine);
            return returnedValue;
        }
        



         void IMagazine.ChangeXMLFile()
        {
            Stream stream = File.OpenWrite("Magazine.xml");

            XmlSerializer serializer = new XmlSerializer(typeof(List<Magazine>));
            serializer.Serialize(stream,magazines);

            stream.Close();
        }        

        private void ReadXMLFile()
        {            
            Stream stream = File.OpenRead("Magazine.xml");

            XmlSerializer serializer = new XmlSerializer(typeof(List<Magazine>));
            var read = serializer.Deserialize(stream);
            stream.Close();

            magazines = read as List<Magazine>;
            
        }

        private void StartConfiguraton()
        {
            bool existXMLfile = File.Exists("Magazine.xml");
            if (existXMLfile)
            {
                ReadXMLFile();
            }
           
        }
    }
}
