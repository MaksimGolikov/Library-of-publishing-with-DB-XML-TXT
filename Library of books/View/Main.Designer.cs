namespace Library_of_books
{
    partial class fmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bnChangeData = new System.Windows.Forms.Button();
            this.dgvShowingField = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bnAddNewData = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bnDeleteData = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbPublishingYear = new System.Windows.Forms.TextBox();
            this.tbPublishingHouse = new System.Windows.Forms.TextBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.tbNameBook = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearchRelease = new System.Windows.Forms.TextBox();
            this.bnSearchAll = new System.Windows.Forms.Button();
            this.bnSearchNewspaper = new System.Windows.Forms.Button();
            this.bnSearchMagazine = new System.Windows.Forms.Button();
            this.cbSearchAuthor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSearchPublishingYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSearchPublishingHouse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.bnSearchBook = new System.Windows.Forms.Button();
            this.tbSearchAutor = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbTypePublish = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.bnChangeArticleInformation = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbRelease = new System.Windows.Forms.TextBox();
            this.lbCode = new System.Windows.Forms.Label();
            this.bnDeletePublish = new System.Windows.Forms.Button();
            this.bnAdNewPublish = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tbNamePublish = new System.Windows.Forms.TextBox();
            this.lbRelease = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvPublishArticle = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.bnAddNewArticle = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.bnDeleteArticle = new System.Windows.Forms.Button();
            this.tbPublishDescription = new System.Windows.Forms.TextBox();
            this.tbPublishYear = new System.Windows.Forms.TextBox();
            this.bnChangePublishInformation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowingField)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublishArticle)).BeginInit();
            this.SuspendLayout();
            // 
            // bnChangeData
            // 
            this.bnChangeData.Location = new System.Drawing.Point(185, 205);
            this.bnChangeData.Name = "bnChangeData";
            this.bnChangeData.Size = new System.Drawing.Size(167, 25);
            this.bnChangeData.TabIndex = 2;
            this.bnChangeData.Text = "Change book information";
            this.bnChangeData.UseVisualStyleBackColor = true;
            this.bnChangeData.Click += new System.EventHandler(this.bnChangeData_Click);
            // 
            // dgvShowingField
            // 
            this.dgvShowingField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowingField.Location = new System.Drawing.Point(562, 93);
            this.dgvShowingField.Name = "dgvShowingField";
            this.dgvShowingField.RowHeadersVisible = false;
            this.dgvShowingField.Size = new System.Drawing.Size(560, 518);
            this.dgvShowingField.TabIndex = 3;
            this.dgvShowingField.DoubleClick += new System.EventHandler(this.dgvShowingField_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.bnAddNewData);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.bnDeleteData);
            this.groupBox1.Controls.Add(this.tbDescription);
            this.groupBox1.Controls.Add(this.tbPublishingYear);
            this.groupBox1.Controls.Add(this.bnChangeData);
            this.groupBox1.Controls.Add(this.tbPublishingHouse);
            this.groupBox1.Controls.Add(this.tbAuthor);
            this.groupBox1.Controls.Add(this.tbNameBook);
            this.groupBox1.Location = new System.Drawing.Point(12, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 239);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected book";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(118, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Code";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(156, 23);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(13, 13);
            this.lbID.TabIndex = 21;
            this.lbID.Text = "_";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(222, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Description";
            // 
            // bnAddNewData
            // 
            this.bnAddNewData.Location = new System.Drawing.Point(14, 205);
            this.bnAddNewData.Name = "bnAddNewData";
            this.bnAddNewData.Size = new System.Drawing.Size(155, 26);
            this.bnAddNewData.TabIndex = 19;
            this.bnAddNewData.Text = "Add new book";
            this.bnAddNewData.UseVisualStyleBackColor = true;
            this.bnAddNewData.Click += new System.EventHandler(this.bnAddNewData_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Publishing year";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Publishing house";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Author";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Name of the book";
            // 
            // bnDeleteData
            // 
            this.bnDeleteData.Location = new System.Drawing.Point(363, 205);
            this.bnDeleteData.Name = "bnDeleteData";
            this.bnDeleteData.Size = new System.Drawing.Size(175, 22);
            this.bnDeleteData.TabIndex = 11;
            this.bnDeleteData.Text = "Delete book";
            this.bnDeleteData.UseVisualStyleBackColor = true;
            this.bnDeleteData.Click += new System.EventHandler(this.bnDeleteData_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(225, 39);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(313, 151);
            this.tbDescription.TabIndex = 6;
            // 
            // tbPublishingYear
            // 
            this.tbPublishingYear.Location = new System.Drawing.Point(8, 170);
            this.tbPublishingYear.Name = "tbPublishingYear";
            this.tbPublishingYear.Size = new System.Drawing.Size(194, 20);
            this.tbPublishingYear.TabIndex = 10;
            // 
            // tbPublishingHouse
            // 
            this.tbPublishingHouse.Location = new System.Drawing.Point(8, 128);
            this.tbPublishingHouse.Name = "tbPublishingHouse";
            this.tbPublishingHouse.Size = new System.Drawing.Size(193, 20);
            this.tbPublishingHouse.TabIndex = 9;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(8, 84);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(193, 20);
            this.tbAuthor.TabIndex = 8;
            // 
            // tbNameBook
            // 
            this.tbNameBook.Location = new System.Drawing.Point(6, 39);
            this.tbNameBook.Name = "tbNameBook";
            this.tbNameBook.Size = new System.Drawing.Size(195, 20);
            this.tbNameBook.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Author";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbSearchRelease);
            this.groupBox2.Controls.Add(this.bnSearchAll);
            this.groupBox2.Controls.Add(this.bnSearchNewspaper);
            this.groupBox2.Controls.Add(this.bnSearchMagazine);
            this.groupBox2.Controls.Add(this.cbSearchAuthor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbSearchPublishingYear);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbSearchPublishingHouse);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbSearchName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.bnSearchBook);
            this.groupBox2.Controls.Add(this.tbSearchAutor);
            this.groupBox2.Location = new System.Drawing.Point(11, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1111, 76);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search parametrs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(626, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Release";
            // 
            // tbSearchRelease
            // 
            this.tbSearchRelease.Location = new System.Drawing.Point(629, 42);
            this.tbSearchRelease.Name = "tbSearchRelease";
            this.tbSearchRelease.Size = new System.Drawing.Size(104, 20);
            this.tbSearchRelease.TabIndex = 22;
            this.tbSearchRelease.TextChanged += new System.EventHandler(this.tbSearchRelease_TextChanged);
            // 
            // bnSearchAll
            // 
            this.bnSearchAll.Location = new System.Drawing.Point(763, 42);
            this.bnSearchAll.Name = "bnSearchAll";
            this.bnSearchAll.Size = new System.Drawing.Size(342, 21);
            this.bnSearchAll.TabIndex = 20;
            this.bnSearchAll.Text = "All";
            this.bnSearchAll.UseVisualStyleBackColor = true;
            this.bnSearchAll.Click += new System.EventHandler(this.bnSearchAll_Click);
            // 
            // bnSearchNewspaper
            // 
            this.bnSearchNewspaper.Location = new System.Drawing.Point(995, 15);
            this.bnSearchNewspaper.Name = "bnSearchNewspaper";
            this.bnSearchNewspaper.Size = new System.Drawing.Size(110, 21);
            this.bnSearchNewspaper.TabIndex = 19;
            this.bnSearchNewspaper.Text = "Newspaper";
            this.bnSearchNewspaper.UseVisualStyleBackColor = true;
            this.bnSearchNewspaper.Click += new System.EventHandler(this.bnSearchNewspaper_Click);
            // 
            // bnSearchMagazine
            // 
            this.bnSearchMagazine.Location = new System.Drawing.Point(763, 15);
            this.bnSearchMagazine.Name = "bnSearchMagazine";
            this.bnSearchMagazine.Size = new System.Drawing.Size(110, 21);
            this.bnSearchMagazine.TabIndex = 18;
            this.bnSearchMagazine.Text = "Magazines";
            this.bnSearchMagazine.UseVisualStyleBackColor = true;
            this.bnSearchMagazine.Click += new System.EventHandler(this.bnSearchMagazine_Click);
            // 
            // cbSearchAuthor
            // 
            this.cbSearchAuthor.FormattingEnabled = true;
            this.cbSearchAuthor.Location = new System.Drawing.Point(101, 41);
            this.cbSearchAuthor.Name = "cbSearchAuthor";
            this.cbSearchAuthor.Size = new System.Drawing.Size(102, 21);
            this.cbSearchAuthor.TabIndex = 17;
            this.cbSearchAuthor.DropDownClosed += new System.EventHandler(this.cbSearchAuthor_DropDownClosed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Publishing year";
            // 
            // tbSearchPublishingYear
            // 
            this.tbSearchPublishingYear.Location = new System.Drawing.Point(519, 41);
            this.tbSearchPublishingYear.Name = "tbSearchPublishingYear";
            this.tbSearchPublishingYear.Size = new System.Drawing.Size(104, 20);
            this.tbSearchPublishingYear.TabIndex = 16;
            this.tbSearchPublishingYear.TextChanged += new System.EventHandler(this.tbSearchPublishingYear_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Publishing house";
            // 
            // tbSearchPublishingHouse
            // 
            this.tbSearchPublishingHouse.Location = new System.Drawing.Point(364, 41);
            this.tbSearchPublishingHouse.Name = "tbSearchPublishingHouse";
            this.tbSearchPublishingHouse.Size = new System.Drawing.Size(130, 20);
            this.tbSearchPublishingHouse.TabIndex = 14;
            this.tbSearchPublishingHouse.TextChanged += new System.EventHandler(this.tbSearchPublishingHouse_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name of the book";
            // 
            // tbSearchName
            // 
            this.tbSearchName.Location = new System.Drawing.Point(226, 42);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(114, 20);
            this.tbSearchName.TabIndex = 12;
            this.tbSearchName.TextChanged += new System.EventHandler(this.tbSearchName_TextChanged);
            // 
            // bnSearchBook
            // 
            this.bnSearchBook.Location = new System.Drawing.Point(879, 15);
            this.bnSearchBook.Name = "bnSearchBook";
            this.bnSearchBook.Size = new System.Drawing.Size(110, 21);
            this.bnSearchBook.TabIndex = 2;
            this.bnSearchBook.Text = "Books";
            this.bnSearchBook.UseVisualStyleBackColor = true;
            this.bnSearchBook.Click += new System.EventHandler(this.bnShowAllBook_Click);
            // 
            // tbSearchAutor
            // 
            this.tbSearchAutor.Location = new System.Drawing.Point(7, 42);
            this.tbSearchAutor.Name = "tbSearchAutor";
            this.tbSearchAutor.Size = new System.Drawing.Size(88, 20);
            this.tbSearchAutor.TabIndex = 8;
            this.tbSearchAutor.TextChanged += new System.EventHandler(this.tbSearchAutor_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbTypePublish);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.bnChangeArticleInformation);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.tbRelease);
            this.groupBox3.Controls.Add(this.lbCode);
            this.groupBox3.Controls.Add(this.bnDeletePublish);
            this.groupBox3.Controls.Add(this.bnAdNewPublish);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.tbNamePublish);
            this.groupBox3.Controls.Add(this.lbRelease);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.dgvPublishArticle);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.bnAddNewArticle);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.bnDeleteArticle);
            this.groupBox3.Controls.Add(this.tbPublishDescription);
            this.groupBox3.Controls.Add(this.tbPublishYear);
            this.groupBox3.Controls.Add(this.bnChangePublishInformation);
            this.groupBox3.Location = new System.Drawing.Point(12, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(544, 273);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selected publish";
            // 
            // lbTypePublish
            // 
            this.lbTypePublish.AutoSize = true;
            this.lbTypePublish.Location = new System.Drawing.Point(472, 26);
            this.lbTypePublish.Name = "lbTypePublish";
            this.lbTypePublish.Size = new System.Drawing.Size(13, 13);
            this.lbTypePublish.TabIndex = 32;
            this.lbTypePublish.Text = "_";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(451, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Is";
            // 
            // bnChangeArticleInformation
            // 
            this.bnChangeArticleInformation.Location = new System.Drawing.Point(386, 205);
            this.bnChangeArticleInformation.Name = "bnChangeArticleInformation";
            this.bnChangeArticleInformation.Size = new System.Drawing.Size(155, 25);
            this.bnChangeArticleInformation.TabIndex = 30;
            this.bnChangeArticleInformation.Text = "Change article information";
            this.bnChangeArticleInformation.UseVisualStyleBackColor = true;
            this.bnChangeArticleInformation.Click += new System.EventHandler(this.bnChangeArticleInformation_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(360, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Code ";
            // 
            // tbRelease
            // 
            this.tbRelease.Location = new System.Drawing.Point(278, 19);
            this.tbRelease.Name = "tbRelease";
            this.tbRelease.Size = new System.Drawing.Size(48, 20);
            this.tbRelease.TabIndex = 23;
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(401, 23);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(13, 13);
            this.lbCode.TabIndex = 28;
            this.lbCode.Text = "_";
            // 
            // bnDeletePublish
            // 
            this.bnDeletePublish.Location = new System.Drawing.Point(225, 236);
            this.bnDeletePublish.Name = "bnDeletePublish";
            this.bnDeletePublish.Size = new System.Drawing.Size(155, 26);
            this.bnDeletePublish.TabIndex = 27;
            this.bnDeletePublish.Text = "Delete publish";
            this.bnDeletePublish.UseVisualStyleBackColor = true;
            this.bnDeletePublish.Click += new System.EventHandler(this.bnDeletePublish_Click);
            // 
            // bnAdNewPublish
            // 
            this.bnAdNewPublish.Location = new System.Drawing.Point(225, 175);
            this.bnAdNewPublish.Name = "bnAdNewPublish";
            this.bnAdNewPublish.Size = new System.Drawing.Size(155, 24);
            this.bnAdNewPublish.TabIndex = 26;
            this.bnAdNewPublish.Text = "Add new publish";
            this.bnAdNewPublish.UseVisualStyleBackColor = true;
            this.bnAdNewPublish.Click += new System.EventHandler(this.bnAdNewPublish_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Name publish";
            // 
            // tbNamePublish
            // 
            this.tbNamePublish.Location = new System.Drawing.Point(6, 39);
            this.tbNamePublish.Name = "tbNamePublish";
            this.tbNamePublish.Size = new System.Drawing.Size(195, 20);
            this.tbNamePublish.TabIndex = 24;
            // 
            // lbRelease
            // 
            this.lbRelease.AutoSize = true;
            this.lbRelease.Location = new System.Drawing.Point(222, 23);
            this.lbRelease.Name = "lbRelease";
            this.lbRelease.Size = new System.Drawing.Size(46, 13);
            this.lbRelease.TabIndex = 23;
            this.lbRelease.Text = "Release";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Articles inside";
            // 
            // dgvPublishArticle
            // 
            this.dgvPublishArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPublishArticle.EnableHeadersVisualStyles = false;
            this.dgvPublishArticle.Location = new System.Drawing.Point(5, 136);
            this.dgvPublishArticle.Name = "dgvPublishArticle";
            this.dgvPublishArticle.RowHeadersVisible = false;
            this.dgvPublishArticle.Size = new System.Drawing.Size(196, 131);
            this.dgvPublishArticle.TabIndex = 13;
            this.dgvPublishArticle.DoubleClick += new System.EventHandler(this.dgvPublishArticle_DoubleClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(222, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Description";
            // 
            // bnAddNewArticle
            // 
            this.bnAddNewArticle.Location = new System.Drawing.Point(386, 177);
            this.bnAddNewArticle.Name = "bnAddNewArticle";
            this.bnAddNewArticle.Size = new System.Drawing.Size(155, 22);
            this.bnAddNewArticle.TabIndex = 19;
            this.bnAddNewArticle.Text = "Add new article";
            this.bnAddNewArticle.UseVisualStyleBackColor = true;
            this.bnAddNewArticle.Click += new System.EventHandler(this.bnAddNewArticle_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Publishing year";
            // 
            // bnDeleteArticle
            // 
            this.bnDeleteArticle.Location = new System.Drawing.Point(386, 236);
            this.bnDeleteArticle.Name = "bnDeleteArticle";
            this.bnDeleteArticle.Size = new System.Drawing.Size(155, 26);
            this.bnDeleteArticle.TabIndex = 11;
            this.bnDeleteArticle.Text = "Delete article";
            this.bnDeleteArticle.UseVisualStyleBackColor = true;
            this.bnDeleteArticle.Click += new System.EventHandler(this.bnDeleteArticle_Click);
            // 
            // tbPublishDescription
            // 
            this.tbPublishDescription.Location = new System.Drawing.Point(225, 69);
            this.tbPublishDescription.Multiline = true;
            this.tbPublishDescription.Name = "tbPublishDescription";
            this.tbPublishDescription.Size = new System.Drawing.Size(316, 100);
            this.tbPublishDescription.TabIndex = 6;
            // 
            // tbPublishYear
            // 
            this.tbPublishYear.Location = new System.Drawing.Point(5, 85);
            this.tbPublishYear.Name = "tbPublishYear";
            this.tbPublishYear.Size = new System.Drawing.Size(197, 20);
            this.tbPublishYear.TabIndex = 10;
            // 
            // bnChangePublishInformation
            // 
            this.bnChangePublishInformation.Location = new System.Drawing.Point(225, 205);
            this.bnChangePublishInformation.Name = "bnChangePublishInformation";
            this.bnChangePublishInformation.Size = new System.Drawing.Size(155, 25);
            this.bnChangePublishInformation.TabIndex = 2;
            this.bnChangePublishInformation.Text = "Change publish information";
            this.bnChangePublishInformation.UseVisualStyleBackColor = true;
            this.bnChangePublishInformation.Click += new System.EventHandler(this.bnChangePublishInformation_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 621);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvShowingField);
            this.MaximumSize = new System.Drawing.Size(1150, 660);
            this.MinimumSize = new System.Drawing.Size(1150, 660);
            this.Name = "fmMain";
            this.Text = "Library";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowingField)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublishArticle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bnChangeData;
        private System.Windows.Forms.DataGridView dgvShowingField;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bnDeleteData;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbPublishingYear;
        private System.Windows.Forms.TextBox tbPublishingHouse;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.TextBox tbNameBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbSearchAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bnSearchBook;
        private System.Windows.Forms.TextBox tbSearchPublishingYear;
        private System.Windows.Forms.TextBox tbSearchPublishingHouse;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.TextBox tbSearchAutor;
        private System.Windows.Forms.Button bnAddNewData;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bnDeletePublish;
        private System.Windows.Forms.Button bnAdNewPublish;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbNamePublish;
        private System.Windows.Forms.Label lbRelease;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvPublishArticle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button bnAddNewArticle;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button bnDeleteArticle;
        private System.Windows.Forms.TextBox tbPublishDescription;
        private System.Windows.Forms.TextBox tbPublishYear;
        private System.Windows.Forms.Button bnChangePublishInformation;
        private System.Windows.Forms.Button bnSearchMagazine;
        private System.Windows.Forms.Button bnSearchAll;
        private System.Windows.Forms.Button bnSearchNewspaper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchRelease;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbRelease;
        private System.Windows.Forms.Button bnChangeArticleInformation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbTypePublish;
        private System.Windows.Forms.Label label15;
    }
}

