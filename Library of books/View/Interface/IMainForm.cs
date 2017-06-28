using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_of_books.Model;
using Library_of_books.Presenter.Interface;

namespace Library_of_books.View.Interface
{
    interface IMainForm
    {       
        void SetSelectedPublish(Book book);       
        void SetLoadedPublish(List<Book> books);

        void Show(IMainPrecenter newPresenter);
        

    }
}
