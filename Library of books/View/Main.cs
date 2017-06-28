using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_of_books.View.Interface;
using Library_of_books.Model;
using Library_of_books.Presenter.Interface;


namespace Library_of_books
{
    partial class fmMain : Form, IMainForm
    {
        List<string> nameBooks;
        List<string> authorBooks;
        List<string> publishingHouse;
        List<string> publishingYear;

        IMainPrecenter presenter
        {
            get;
            set;
        }

        DataTable table;
        DataTable tableMagazine;

        public fmMain()
        {
            InitializeComponent();

            StartConfiguration();
        }

        private void StartConfiguration()
        {          

            nameBooks = new List<string>();
            authorBooks = new List<string>();
            publishingHouse = new List<string>();
            publishingYear = new List<string>();


            table = new DataTable();

            table.Columns.Add("Type publishing", typeof(string));
            table.Columns.Add("Name book",typeof(string)); 
            table.Columns.Add("Author", typeof(string));
            table.Columns.Add("Publishing house", typeof(string));
            table.Columns.Add("Publishing year", typeof(string));
            table.Columns.Add("Code", typeof(string));

            dgvShowingField.DataSource = table;                        
            dgvShowingField.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;



            tableMagazine = new DataTable();

            tableMagazine.Columns.Add("Name article", typeof(string));            
            tableMagazine.Columns.Add("Author", typeof(string));
            tableMagazine.Columns.Add("Code", typeof(string));

            dgvPublishArticle.DataSource = tableMagazine;
            dgvPublishArticle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        #region Buttons

        private void bnAddNewData_Click(object sender, EventArgs e)
        {
            Book newBook = new Book(tbNameBook.Text,
                                    tbAuthor.Text,
                                    tbPublishingHouse.Text,
                                    tbPublishingYear.Text,
                                    tbDescription.Text,
                                    0);
            var returnText =  presenter.CreateNewBook(newBook);
            MessageBox.Show(returnText);
        }

        private void bnChangeData_Click(object sender, EventArgs e)
        {
            Book newBook = new Book(tbNameBook.Text,
                                    tbAuthor.Text,
                                    tbPublishingHouse.Text,
                                    tbPublishingYear.Text,
                                    tbDescription.Text,
                                    Int32.Parse(lbID.Text));
            var returnText = presenter.ChangeBookInfo(newBook);
            MessageBox.Show(returnText);
        }
        
        private void bnDeleteData_Click(object sender, EventArgs e)
        {
            presenter.DeleteSelectedBook(Int32.Parse(lbID.Text));
            presenter.GetAllBooks();


            tbNameBook.Text = "";
            tbAuthor.Text = "";
            tbPublishingHouse.Text = "";
            tbPublishingYear.Text = "";
            tbDescription.Text = "";
        }

        private void bnShowAllBook_Click(object sender, EventArgs e)
        {
            presenter.GetAllBooks();
        }

        private void bnSearchMagazine_Click(object sender, EventArgs e)
        {
            presenter.GetAllMagazine();
        }

        private void bnSearchNewspaper_Click(object sender, EventArgs e)
        {
            presenter.GetAllNewspaper();
        }

        private void bnSearchAll_Click(object sender, EventArgs e)
        {
            presenter.GetAllPublish();
        }

        private void bnAdNewPublish_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Do you want to create Magazine?", "Warning", MessageBoxButtons.OKCancel,
                                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (answer == DialogResult.OK)
            {

                int release;
                bool shouldAdd = Int32.TryParse(tbRelease.Text.ToString(), out release);

                if (shouldAdd)
                {
                    Magazine newMagazine = new Magazine(0,
                                                release,
                                                tbNamePublish.Text,
                                                tbPublishYear.Text,
                                                tbPublishDescription.Text,
                                                new List<Book>());
                    var returnText = presenter.CreateNewPublish(newMagazine);
                    MessageBox.Show(returnText);
                }
                if (!shouldAdd)
                {
                    MessageBox.Show("You don`t input data or inter incorrect value");
                }
            }
            if (answer == DialogResult.Cancel)
            {

                int release;
                bool shouldAdd = Int32.TryParse(tbRelease.Text.ToString(), out release);

                if (shouldAdd)
                {
                    Newspaper newNewspaper = new Newspaper(0,
                                                release,
                                                tbNamePublish.Text,
                                                tbPublishYear.Text,
                                                tbPublishDescription.Text,
                                                new List<Book>());
                    var returnText = presenter.CreateNewPublish(newNewspaper);
                    MessageBox.Show(returnText);
                }
                if (!shouldAdd)
                {
                    MessageBox.Show("You don`t input data or inter incorrect value");
                }
            }


        }

        private void bnAddNewArticle_Click(object sender, EventArgs e)
        {

            var answer = MessageBox.Show("Do you want to addd article to Magazine?", "Warning", MessageBoxButtons.OKCancel,
                                       MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            Book newBook = new Book(tbNameBook.Text,
                                  tbAuthor.Text,
                                  "  ",
                                  tbPublishYear.Text,
                                  tbDescription.Text,
                                  0);
           

            if (answer == DialogResult.OK)
            {              

                if (lbCode.Text == "_")
                {
                    MessageBox.Show("You don`t select any publish");
                }
                if (lbCode.Text != "_")
                {
                    var returnText = presenter.CreateNewArticle(Convert.ToInt32(lbCode.Text), newBook, "Magazine");
                    MessageBox.Show(returnText);
                }
            }
            if (answer == DialogResult.Cancel)
            {

                var returnText = presenter.CreateNewArticle(Convert.ToInt32(lbCode.Text), newBook, "Newspaper");
                MessageBox.Show(returnText);

                if (lbCode.Text == "_")
                {
                    MessageBox.Show("You don`t select any publish");
                }
            }
            
               
        }

        private void bnChangePublishInformation_Click(object sender, EventArgs e)
        {
            if (lbTypePublish.Text == "Magazine")
            {
                var magazine = new Magazine(Convert.ToInt32(lbCode.Text),
                                        Convert.ToInt32(tbRelease.Text),
                                        tbNamePublish.Text,
                                        tbPublishYear.Text,
                                        tbPublishDescription.Text,
                                        new List<Book>());
                var text = presenter.ChangePublisheInfo(magazine);
                MessageBox.Show(text);
            }
            if (lbTypePublish.Text != "Magazine")
            {
                var newspaper = new Newspaper(Convert.ToInt32(lbCode.Text),
                                        Convert.ToInt32(tbRelease.Text),
                                        tbNamePublish.Text,
                                        tbPublishYear.Text,
                                        tbPublishDescription.Text,
                                        new List<Book>());
                var text = presenter.ChangePublisheInfo(newspaper);
                MessageBox.Show(text);
            }


            
        }
        private void bnChangeArticleInformation_Click(object sender, EventArgs e)
        {
            Book newBook = new Book(tbNameBook.Text,
                                    tbAuthor.Text,
                                    "  ",
                                    tbPublishYear.Text,
                                    tbDescription.Text,
                                    0);
            var returnText = presenter.ChangeArticleInfo(Convert.ToInt32(lbCode.Text),newBook, lbTypePublish.Text);
            MessageBox.Show(returnText);
        }

        private void bnDeletePublish_Click(object sender, EventArgs e)
        {
           
            if (lbCode.Text == "_")
            {
                MessageBox.Show("You don`t select any publish");
            }
            if (lbCode.Text != "_")
            {
                presenter.DeleteSelectedPublish(Convert.ToInt32(lbCode.Text), lbTypePublish.Text);

                if (lbTypePublish.Text == "Magazine")
                {
                    presenter.GetAllMagazine();
                    tableMagazine.Clear();
                    dgvPublishArticle.DataSource = tableMagazine;

                }
                if (lbTypePublish.Text != "Magazine")
                {
                    presenter.GetAllNewspaper();
                    tableMagazine.Clear();
                    dgvPublishArticle.DataSource = tableMagazine;
                }

                tbPublishDescription.Text = "";
                tbPublishingHouse.Text = "";
                tbPublishingYear.Text = "";
                tbPublishYear.Text = "";
                tbNamePublish.Text = "";
                lbTypePublish.Text = "_";

                tbRelease.Text = "";
                lbCode.Text = "_";

                tbNameBook.Text = "";
                tbAuthor.Text = "";
                tbPublishingHouse.Text = "";
                tbPublishingYear.Text = "";
                tbDescription.Text = "";
            }

        }

        private void bnDeleteArticle_Click(object sender, EventArgs e)
        {

            if (lbID.Text == "_")
            {
                MessageBox.Show("You don`t selected any  article");
            }
            if (lbID.Text != "_")
            {
                presenter.DeleteSelectedArticle(Convert.ToInt32(lbCode.Text),
                                                Convert.ToInt32(lbID.Text));
              
                tbNameBook.Text = "";
                tbAuthor.Text = "";
                tbPublishingHouse.Text = "";
                tbPublishingYear.Text = "";
                tbDescription.Text = "";
                lbID.Text = "_";
            }
        }

        #endregion

        #region Search

        private void tbSearchAutor_TextChanged(object sender, EventArgs e)
        {
            presenter.SearchByAuthor(tbSearchAutor.Text);
        }

        private void tbSearchName_TextChanged(object sender, EventArgs e)
        {
            presenter.SearchByName(tbSearchName.Text);
        }

        private void tbSearchPublishingHouse_TextChanged(object sender, EventArgs e)
        {
            if (tbSearchPublishingHouse.Text != "")
            {
                presenter.SearchByPublishingHouse(tbSearchPublishingHouse.Text);
            }
            if (tbSearchPublishingHouse.Text == "")
            {
                MessageBox.Show("You don`t enter any name of publishing house");
            }
        }

        private void tbSearchPublishingYear_TextChanged(object sender, EventArgs e)
        {
            presenter.SearchByPublishingYear(tbSearchPublishingYear.Text);
        }

        private void cbSearchAuthor_DropDownClosed(object sender, EventArgs e)
        {
            if (cbSearchAuthor.SelectedIndex != -1)
            {
                tbSearchAutor.Text = cbSearchAuthor.SelectedItem.ToString();
            }
        }
        private void tbSearchRelease_TextChanged(object sender, EventArgs e)
        {
            int release;
            bool shoudFinde = Int32.TryParse(tbSearchRelease.Text, out release);

            if (shoudFinde)
            {
                presenter.SearchByRelease( release );
            }
           
        }

        private void dgvShowingField_DoubleClick(object sender, EventArgs e)
        {           
            string type= dgvShowingField.CurrentRow.Cells[0].Value.ToString();
            presenter.GetSelectedBook(Int32.Parse( dgvShowingField.CurrentRow.Cells[5].Value.ToString()), type );
        }

        private void dgvPublishArticle_DoubleClick(object sender, EventArgs e)
        {            
            presenter.GetSelectedArticle(Convert.ToInt32(lbCode.Text), Int32.Parse(dgvPublishArticle.CurrentRow.Cells[2].Value.ToString()), lbTypePublish.Text);
        }
        #endregion


        void IMainForm.SetLoadedPublish(List<Book> books)
        {
            authorBooks.Clear();
            cbSearchAuthor.DataSource = null;
            table.Rows.Clear();

            bool publishUsed = false;

            for (int i=0;i<books.Count;i++)
            {
                publishUsed = false;

                if (books[i] is Magazine)
                {
                    var book = (Magazine)books[i];
                    table.Rows.Add("Magazine",book.NameBook, "", "", book.PublishingYear, book.ID);
                    publishUsed = true;
                }
                if (books[i] is Newspaper)
                {
                    var book = (Newspaper)books[i];
                    table.Rows.Add("Newspaper",book.NameBook, "", "", book.PublishingYear, book.ID);
                    publishUsed = true;
                }
                if (!publishUsed && books[i] is Book)
                {
                    var book = (Book)books[i];
                    table.Rows.Add("Book",book.NameBook, book.Author, book.PublishingHouse, book.PublishingYear, book.ID);

                    nameBooks.Add(book.NameBook);
                    publishingHouse.Add(book.PublishingHouse);
                    publishingYear.Add(book.PublishingYear);

                    if (!authorBooks.Cast<string>().Any(cbi => cbi.Equals(book.Author)))
                    {
                        authorBooks.Add(book.Author);
                    }
                    publishUsed = true;
                }               
            }

            dgvShowingField.DataSource = table;

            cbSearchAuthor.DataSource = authorBooks;
            cbSearchAuthor.SelectedIndex = -1;
        }

        void IMainForm.SetSelectedPublish(Book book)
        {
            bool used = false;

            if(book is Magazine)
            {
                var publish = (Magazine)book;
                tbNamePublish.Text = publish.NameBook;
                tbPublishYear.Text = publish.PublishingYear;

                tbRelease.Text = publish.Release.ToString();
                lbCode.Text = publish.ID.ToString();
                tbPublishDescription.Text = publish.Description;
                lbTypePublish.Text = "Magazine";

                tableMagazine.Clear();
                foreach (Book b in publish.Article)
                {
                    tableMagazine.Rows.Add(b.NameBook, b.Author,b.ID);
                }
                used = true;
            }
            if (book is Newspaper)
            {
                var publish = (Newspaper)book;
                tbNamePublish.Text = publish.NameBook;
                tbPublishYear.Text = publish.PublishingYear;

                tbRelease.Text = publish.Release.ToString();
                lbCode.Text = publish.ID.ToString();
                tbPublishDescription.Text = publish.Description;
                lbTypePublish.Text = "Newspaper";

                tableMagazine.Clear();
                foreach (Book b in publish.Article)
                {
                    tableMagazine.Rows.Add(b.NameBook, b.Author, b.ID);
                }
                used = true;
            }
            if ( !used && (book is Book) )
            {
                tbNameBook.Text = book.NameBook;
                tbAuthor.Text = book.Author;
                tbPublishingHouse.Text = book.PublishingHouse;
                tbPublishingYear.Text = book.PublishingYear;
                tbDescription.Text = book.Description;
                lbID.Text = book.ID.ToString();
            }

        }               

        public new void Show(IMainPrecenter newPresenter)
        {
            presenter = newPresenter;
            Application.Run(this);
        }

       


    }
}