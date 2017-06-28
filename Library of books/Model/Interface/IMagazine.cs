using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_of_books.Model.Interface
{
    interface IMagazine
    {

        List<Magazine> LoadMagazines();
        List<Magazine> SearchByName(string name);
        List<Magazine> SearchByRelease(int release);
        List<Magazine> SearchByPublishingYear(string publishingYear);
        Book GetSelectedArticle(int idMagazine, int idArticle);
        Magazine SetSelectedMagazine(int idMagazine);
        void DeleteMagazine(int idMagazine);
        void DeleteArticle(int idMagazine,int idArticle);
        void CreateNewMagazine(Magazine magazine);
        void CreateNewArticle(int magazineID, Book newArticlce);
        void ChangeMagazinInfo(Magazine magazine);
        void ChangeArticleInfo(int magazineID, Book article);


        void ChangeXMLFile();
    }
}
