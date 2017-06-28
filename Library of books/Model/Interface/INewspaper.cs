using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_of_books.Model.Interface
{
    interface INewspaper
    {

        List<Newspaper> LoadNewspaper();
        List<Newspaper> SearchByName(string name);
        List<Newspaper> SearchByRelease(int release);
        List<Newspaper> SearchByPublishingYear(string publishingYear);
        Book GetSelectedArticle(int idNewspaper, int idArticle);
        Newspaper SetSelectedMagazine(int idNewspaper);
        void DeleteMagazine(int idNewspaper);
        void DeleteArticle(int idNewspaper, int idArticle);
        void CreateNewMagazine(Newspaper newspaper);
        void CreateNewArticle(int magazineID, Book newArticlce);
        void ChangeMagazinInfo(Newspaper newspaper);
        void ChangeArticleInfo(int newspaperID, Book article);


        void ChangeTXTfile();
    }
}
