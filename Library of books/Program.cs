using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_of_books.Presenter.Interface;
using Library_of_books.View.Interface;
using Library_of_books.Model;
using Library_of_books.View;

namespace Library_of_books
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
                       
            var presenter = new Presenter.MainPresenter( new fmMain(), new MainFormFunction (), new MagazineFunction(), new NewspaperFunction() ); 
            presenter.Run();
        }
    }
}
