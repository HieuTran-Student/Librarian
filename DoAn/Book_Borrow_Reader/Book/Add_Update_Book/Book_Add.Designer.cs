namespace DoAn.MANAGER.Book
{
    partial class frmBook_Add
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.numBookAdd_NumberOfBooks = new Guna.UI.WinForms.GunaNumeric();
            this.lblBook_IDs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBook_NewCategory = new Guna.UI.WinForms.GunaGradientButton();
            this.lblBook_Category = new System.Windows.Forms.Label();
            this.comBook_Category = new Guna.UI.WinForms.GunaComboBox();
            this.lblBook_SeriesOfBook = new System.Windows.Forms.Label();
            this.txtBookAdd_Prices = new Guna.UI.WinForms.GunaTextBox();
            this.txtBookAdd_PublicDate = new Guna.UI.WinForms.GunaTextBox();
            this.txtBookAdd_Publisher = new Guna.UI.WinForms.GunaTextBox();
            this.txtBookAdd_Author = new Guna.UI.WinForms.GunaTextBox();
            this.txtBookAdd_TitleOfBook = new Guna.UI.WinForms.GunaTextBox();
            this.lblBook_Prices = new System.Windows.Forms.Label();
            this.lblBook_PublicDate = new System.Windows.Forms.Label();
            this.lblBook_Publisher = new System.Windows.Forms.Label();
            this.lblBook_Author = new System.Windows.Forms.Label();
            this.lblBookD_SeriesOfBook = new System.Windows.Forms.Label();
            this.lblBook_Title = new System.Windows.Forms.Label();
            this.lblBook_ID = new System.Windows.Forms.Label();
            this.btnBookAdd_Add = new Guna.UI.WinForms.GunaGradientButton();
            this.btnBookAdd_Cancel = new Guna.UI.WinForms.GunaGradientButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.numBookAdd_NumberOfBooks);
            this.panel1.Controls.Add(this.lblBook_IDs);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBook_NewCategory);
            this.panel1.Controls.Add(this.lblBook_Category);
            this.panel1.Controls.Add(this.comBook_Category);
            this.panel1.Controls.Add(this.lblBook_SeriesOfBook);
            this.panel1.Controls.Add(this.txtBookAdd_Prices);
            this.panel1.Controls.Add(this.txtBookAdd_PublicDate);
            this.panel1.Controls.Add(this.txtBookAdd_Publisher);
            this.panel1.Controls.Add(this.txtBookAdd_Author);
            this.panel1.Controls.Add(this.txtBookAdd_TitleOfBook);
            this.panel1.Controls.Add(this.lblBook_Prices);
            this.panel1.Controls.Add(this.lblBook_PublicDate);
            this.panel1.Controls.Add(this.lblBook_Publisher);
            this.panel1.Controls.Add(this.lblBook_Author);
            this.panel1.Controls.Add(this.lblBookD_SeriesOfBook);
            this.panel1.Controls.Add(this.lblBook_Title);
            this.panel1.Controls.Add(this.lblBook_ID);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1310, 414);
            this.panel1.TabIndex = 41;
            // 
            // numBookAdd_NumberOfBooks
            // 
            this.numBookAdd_NumberOfBooks.BackColor = System.Drawing.Color.Transparent;
            this.numBookAdd_NumberOfBooks.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.numBookAdd_NumberOfBooks.BorderColor = System.Drawing.Color.Silver;
            this.numBookAdd_NumberOfBooks.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.numBookAdd_NumberOfBooks.ButtonForeColor = System.Drawing.Color.White;
            this.numBookAdd_NumberOfBooks.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBookAdd_NumberOfBooks.ForeColor = System.Drawing.Color.Black;
            this.numBookAdd_NumberOfBooks.Location = new System.Drawing.Point(311, 289);
            this.numBookAdd_NumberOfBooks.Maximum = ((long)(9999999));
            this.numBookAdd_NumberOfBooks.Minimum = ((long)(1));
            this.numBookAdd_NumberOfBooks.Name = "numBookAdd_NumberOfBooks";
            this.numBookAdd_NumberOfBooks.Radius = 3;
            this.numBookAdd_NumberOfBooks.Size = new System.Drawing.Size(350, 30);
            this.numBookAdd_NumberOfBooks.TabIndex = 4;
            this.numBookAdd_NumberOfBooks.Value = ((long)(1));
            // 
            // lblBook_IDs
            // 
            this.lblBook_IDs.AutoSize = true;
            this.lblBook_IDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook_IDs.Location = new System.Drawing.Point(20, 9);
            this.lblBook_IDs.Name = "lblBook_IDs";
            this.lblBook_IDs.Size = new System.Drawing.Size(87, 25);
            this.lblBook_IDs.TabIndex = 60;
            this.lblBook_IDs.Text = "Book ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "Number of Books";
            // 
            // btnBook_NewCategory
            // 
            this.btnBook_NewCategory.AnimationHoverSpeed = 0.07F;
            this.btnBook_NewCategory.AnimationSpeed = 0.03F;
            this.btnBook_NewCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnBook_NewCategory.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.btnBook_NewCategory.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.btnBook_NewCategory.BorderColor = System.Drawing.Color.Black;
            this.btnBook_NewCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBook_NewCategory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBook_NewCategory.FocusedColor = System.Drawing.Color.Empty;
            this.btnBook_NewCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook_NewCategory.ForeColor = System.Drawing.Color.White;
            this.btnBook_NewCategory.Image = null;
            this.btnBook_NewCategory.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBook_NewCategory.Location = new System.Drawing.Point(971, 370);
            this.btnBook_NewCategory.Name = "btnBook_NewCategory";
            this.btnBook_NewCategory.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnBook_NewCategory.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnBook_NewCategory.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBook_NewCategory.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBook_NewCategory.OnHoverImage = null;
            this.btnBook_NewCategory.OnPressedColor = System.Drawing.Color.Black;
            this.btnBook_NewCategory.Radius = 3;
            this.btnBook_NewCategory.Size = new System.Drawing.Size(137, 41);
            this.btnBook_NewCategory.TabIndex = 8;
            this.btnBook_NewCategory.Text = "New Category";
            this.btnBook_NewCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBook_NewCategory.Click += new System.EventHandler(this.btnBook_NewCategory_Click);
            // 
            // lblBook_Category
            // 
            this.lblBook_Category.AutoSize = true;
            this.lblBook_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook_Category.Location = new System.Drawing.Point(982, 331);
            this.lblBook_Category.Name = "lblBook_Category";
            this.lblBook_Category.Size = new System.Drawing.Size(92, 25);
            this.lblBook_Category.TabIndex = 57;
            this.lblBook_Category.Text = "Category";
            // 
            // comBook_Category
            // 
            this.comBook_Category.BackColor = System.Drawing.Color.Transparent;
            this.comBook_Category.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.comBook_Category.BorderColor = System.Drawing.Color.Silver;
            this.comBook_Category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comBook_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBook_Category.FocusedColor = System.Drawing.Color.Empty;
            this.comBook_Category.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBook_Category.ForeColor = System.Drawing.Color.Black;
            this.comBook_Category.FormattingEnabled = true;
            this.comBook_Category.Location = new System.Drawing.Point(851, 282);
            this.comBook_Category.Name = "comBook_Category";
            this.comBook_Category.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comBook_Category.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comBook_Category.Radius = 3;
            this.comBook_Category.Size = new System.Drawing.Size(350, 37);
            this.comBook_Category.TabIndex = 7;
            // 
            // lblBook_SeriesOfBook
            // 
            this.lblBook_SeriesOfBook.AutoSize = true;
            this.lblBook_SeriesOfBook.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblBook_SeriesOfBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook_SeriesOfBook.Location = new System.Drawing.Point(846, 191);
            this.lblBook_SeriesOfBook.Margin = new System.Windows.Forms.Padding(3);
            this.lblBook_SeriesOfBook.Name = "lblBook_SeriesOfBook";
            this.lblBook_SeriesOfBook.Padding = new System.Windows.Forms.Padding(5);
            this.lblBook_SeriesOfBook.Size = new System.Drawing.Size(138, 35);
            this.lblBook_SeriesOfBook.TabIndex = 55;
            this.lblBook_SeriesOfBook.Text = "DS00000009";
            // 
            // txtBookAdd_Prices
            // 
            this.txtBookAdd_Prices.BackColor = System.Drawing.Color.Transparent;
            this.txtBookAdd_Prices.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtBookAdd_Prices.BorderColor = System.Drawing.Color.Silver;
            this.txtBookAdd_Prices.BorderSize = 0;
            this.txtBookAdd_Prices.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookAdd_Prices.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBookAdd_Prices.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBookAdd_Prices.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBookAdd_Prices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookAdd_Prices.Location = new System.Drawing.Point(1051, 189);
            this.txtBookAdd_Prices.Name = "txtBookAdd_Prices";
            this.txtBookAdd_Prices.PasswordChar = '\0';
            this.txtBookAdd_Prices.Radius = 3;
            this.txtBookAdd_Prices.SelectedText = "";
            this.txtBookAdd_Prices.Size = new System.Drawing.Size(150, 37);
            this.txtBookAdd_Prices.TabIndex = 6;
            this.txtBookAdd_Prices.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookAdd_Prices_KeyPress);
            // 
            // txtBookAdd_PublicDate
            // 
            this.txtBookAdd_PublicDate.BackColor = System.Drawing.Color.Transparent;
            this.txtBookAdd_PublicDate.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtBookAdd_PublicDate.BorderColor = System.Drawing.Color.Silver;
            this.txtBookAdd_PublicDate.BorderSize = 0;
            this.txtBookAdd_PublicDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookAdd_PublicDate.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBookAdd_PublicDate.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBookAdd_PublicDate.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBookAdd_PublicDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookAdd_PublicDate.Location = new System.Drawing.Point(311, 189);
            this.txtBookAdd_PublicDate.Name = "txtBookAdd_PublicDate";
            this.txtBookAdd_PublicDate.PasswordChar = '\0';
            this.txtBookAdd_PublicDate.Radius = 3;
            this.txtBookAdd_PublicDate.SelectedText = "";
            this.txtBookAdd_PublicDate.Size = new System.Drawing.Size(350, 37);
            this.txtBookAdd_PublicDate.TabIndex = 3;
            this.txtBookAdd_PublicDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookAdd_PublicDate_KeyPress);
            // 
            // txtBookAdd_Publisher
            // 
            this.txtBookAdd_Publisher.BackColor = System.Drawing.Color.Transparent;
            this.txtBookAdd_Publisher.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtBookAdd_Publisher.BorderColor = System.Drawing.Color.Silver;
            this.txtBookAdd_Publisher.BorderSize = 0;
            this.txtBookAdd_Publisher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookAdd_Publisher.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBookAdd_Publisher.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBookAdd_Publisher.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBookAdd_Publisher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookAdd_Publisher.Location = new System.Drawing.Point(311, 99);
            this.txtBookAdd_Publisher.Name = "txtBookAdd_Publisher";
            this.txtBookAdd_Publisher.PasswordChar = '\0';
            this.txtBookAdd_Publisher.Radius = 3;
            this.txtBookAdd_Publisher.SelectedText = "";
            this.txtBookAdd_Publisher.Size = new System.Drawing.Size(350, 37);
            this.txtBookAdd_Publisher.TabIndex = 2;
            // 
            // txtBookAdd_Author
            // 
            this.txtBookAdd_Author.BackColor = System.Drawing.Color.Transparent;
            this.txtBookAdd_Author.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtBookAdd_Author.BorderColor = System.Drawing.Color.Silver;
            this.txtBookAdd_Author.BorderSize = 0;
            this.txtBookAdd_Author.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookAdd_Author.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBookAdd_Author.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBookAdd_Author.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBookAdd_Author.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookAdd_Author.Location = new System.Drawing.Point(851, 99);
            this.txtBookAdd_Author.Name = "txtBookAdd_Author";
            this.txtBookAdd_Author.PasswordChar = '\0';
            this.txtBookAdd_Author.Radius = 3;
            this.txtBookAdd_Author.SelectedText = "";
            this.txtBookAdd_Author.Size = new System.Drawing.Size(350, 37);
            this.txtBookAdd_Author.TabIndex = 5;
            // 
            // txtBookAdd_TitleOfBook
            // 
            this.txtBookAdd_TitleOfBook.BackColor = System.Drawing.Color.Transparent;
            this.txtBookAdd_TitleOfBook.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtBookAdd_TitleOfBook.BorderColor = System.Drawing.Color.White;
            this.txtBookAdd_TitleOfBook.BorderSize = 0;
            this.txtBookAdd_TitleOfBook.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookAdd_TitleOfBook.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBookAdd_TitleOfBook.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBookAdd_TitleOfBook.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBookAdd_TitleOfBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookAdd_TitleOfBook.Location = new System.Drawing.Point(311, 9);
            this.txtBookAdd_TitleOfBook.Name = "txtBookAdd_TitleOfBook";
            this.txtBookAdd_TitleOfBook.PasswordChar = '\0';
            this.txtBookAdd_TitleOfBook.Radius = 3;
            this.txtBookAdd_TitleOfBook.SelectedText = "";
            this.txtBookAdd_TitleOfBook.Size = new System.Drawing.Size(890, 37);
            this.txtBookAdd_TitleOfBook.TabIndex = 1;
            // 
            // lblBook_Prices
            // 
            this.lblBook_Prices.AutoSize = true;
            this.lblBook_Prices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook_Prices.Location = new System.Drawing.Point(1099, 234);
            this.lblBook_Prices.Name = "lblBook_Prices";
            this.lblBook_Prices.Size = new System.Drawing.Size(66, 25);
            this.lblBook_Prices.TabIndex = 47;
            this.lblBook_Prices.Text = "Prices";
            // 
            // lblBook_PublicDate
            // 
            this.lblBook_PublicDate.AutoSize = true;
            this.lblBook_PublicDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook_PublicDate.Location = new System.Drawing.Point(424, 234);
            this.lblBook_PublicDate.Name = "lblBook_PublicDate";
            this.lblBook_PublicDate.Size = new System.Drawing.Size(111, 25);
            this.lblBook_PublicDate.TabIndex = 46;
            this.lblBook_PublicDate.Text = "Public Date";
            // 
            // lblBook_Publisher
            // 
            this.lblBook_Publisher.AutoSize = true;
            this.lblBook_Publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook_Publisher.Location = new System.Drawing.Point(442, 149);
            this.lblBook_Publisher.Name = "lblBook_Publisher";
            this.lblBook_Publisher.Size = new System.Drawing.Size(93, 25);
            this.lblBook_Publisher.TabIndex = 45;
            this.lblBook_Publisher.Text = "Publisher";
            // 
            // lblBook_Author
            // 
            this.lblBook_Author.AutoSize = true;
            this.lblBook_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook_Author.Location = new System.Drawing.Point(992, 149);
            this.lblBook_Author.Name = "lblBook_Author";
            this.lblBook_Author.Size = new System.Drawing.Size(70, 25);
            this.lblBook_Author.TabIndex = 44;
            this.lblBook_Author.Text = "Author";
            // 
            // lblBookD_SeriesOfBook
            // 
            this.lblBookD_SeriesOfBook.AutoSize = true;
            this.lblBookD_SeriesOfBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookD_SeriesOfBook.Location = new System.Drawing.Point(846, 234);
            this.lblBookD_SeriesOfBook.Name = "lblBookD_SeriesOfBook";
            this.lblBookD_SeriesOfBook.Size = new System.Drawing.Size(142, 25);
            this.lblBookD_SeriesOfBook.TabIndex = 43;
            this.lblBookD_SeriesOfBook.Text = "Series Number";
            // 
            // lblBook_Title
            // 
            this.lblBook_Title.AutoSize = true;
            this.lblBook_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook_Title.Location = new System.Drawing.Point(699, 59);
            this.lblBook_Title.Name = "lblBook_Title";
            this.lblBook_Title.Size = new System.Drawing.Size(118, 25);
            this.lblBook_Title.TabIndex = 42;
            this.lblBook_Title.Text = "Title of book";
            // 
            // lblBook_ID
            // 
            this.lblBook_ID.AutoSize = true;
            this.lblBook_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook_ID.Location = new System.Drawing.Point(128, 9);
            this.lblBook_ID.Name = "lblBook_ID";
            this.lblBook_ID.Size = new System.Drawing.Size(97, 25);
            this.lblBook_ID.TabIndex = 41;
            this.lblBook_ID.Text = "000000ID";
            // 
            // btnBookAdd_Add
            // 
            this.btnBookAdd_Add.AnimationHoverSpeed = 0.07F;
            this.btnBookAdd_Add.AnimationSpeed = 0.03F;
            this.btnBookAdd_Add.BackColor = System.Drawing.Color.Transparent;
            this.btnBookAdd_Add.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.btnBookAdd_Add.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.btnBookAdd_Add.BorderColor = System.Drawing.Color.Black;
            this.btnBookAdd_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookAdd_Add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBookAdd_Add.FocusedColor = System.Drawing.Color.Empty;
            this.btnBookAdd_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookAdd_Add.ForeColor = System.Drawing.Color.White;
            this.btnBookAdd_Add.Image = null;
            this.btnBookAdd_Add.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBookAdd_Add.Location = new System.Drawing.Point(954, 626);
            this.btnBookAdd_Add.Name = "btnBookAdd_Add";
            this.btnBookAdd_Add.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnBookAdd_Add.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnBookAdd_Add.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBookAdd_Add.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBookAdd_Add.OnHoverImage = null;
            this.btnBookAdd_Add.OnPressedColor = System.Drawing.Color.Black;
            this.btnBookAdd_Add.Radius = 3;
            this.btnBookAdd_Add.Size = new System.Drawing.Size(370, 57);
            this.btnBookAdd_Add.TabIndex = 9;
            this.btnBookAdd_Add.Text = "Add New Book";
            this.btnBookAdd_Add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBookAdd_Add.Click += new System.EventHandler(this.btnBookAdd_Add_Click);
            // 
            // btnBookAdd_Cancel
            // 
            this.btnBookAdd_Cancel.AnimationHoverSpeed = 0.07F;
            this.btnBookAdd_Cancel.AnimationSpeed = 0.03F;
            this.btnBookAdd_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.btnBookAdd_Cancel.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.btnBookAdd_Cancel.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.btnBookAdd_Cancel.BorderColor = System.Drawing.Color.Black;
            this.btnBookAdd_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookAdd_Cancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBookAdd_Cancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnBookAdd_Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBookAdd_Cancel.ForeColor = System.Drawing.Color.White;
            this.btnBookAdd_Cancel.Image = null;
            this.btnBookAdd_Cancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBookAdd_Cancel.Location = new System.Drawing.Point(578, 626);
            this.btnBookAdd_Cancel.Name = "btnBookAdd_Cancel";
            this.btnBookAdd_Cancel.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnBookAdd_Cancel.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnBookAdd_Cancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBookAdd_Cancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBookAdd_Cancel.OnHoverImage = null;
            this.btnBookAdd_Cancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnBookAdd_Cancel.Radius = 3;
            this.btnBookAdd_Cancel.Size = new System.Drawing.Size(370, 57);
            this.btnBookAdd_Cancel.TabIndex = 10;
            this.btnBookAdd_Cancel.Text = "Cancel";
            this.btnBookAdd_Cancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBookAdd_Cancel.Click += new System.EventHandler(this.btnBookAdd_Cancel_Click);
            // 
            // frmBook_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1336, 695);
            this.Controls.Add(this.btnBookAdd_Cancel);
            this.Controls.Add(this.btnBookAdd_Add);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(325, 170);
            this.Name = "frmBook_Add";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmBook_Add_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaGradientButton btnBookAdd_Add;
        private Guna.UI.WinForms.GunaGradientButton btnBookAdd_Cancel;
        private Guna.UI.WinForms.GunaTextBox txtBookAdd_Prices;
        private Guna.UI.WinForms.GunaTextBox txtBookAdd_PublicDate;
        private Guna.UI.WinForms.GunaTextBox txtBookAdd_Publisher;
        private Guna.UI.WinForms.GunaTextBox txtBookAdd_Author;
        private Guna.UI.WinForms.GunaTextBox txtBookAdd_TitleOfBook;
        private System.Windows.Forms.Label lblBook_Prices;
        private System.Windows.Forms.Label lblBook_PublicDate;
        private System.Windows.Forms.Label lblBook_Publisher;
        private System.Windows.Forms.Label lblBook_Author;
        private System.Windows.Forms.Label lblBookD_SeriesOfBook;
        private System.Windows.Forms.Label lblBook_Title;
        private System.Windows.Forms.Label lblBook_ID;
        private System.Windows.Forms.Label lblBook_SeriesOfBook;
        private System.Windows.Forms.Label lblBook_Category;
        private Guna.UI.WinForms.GunaComboBox comBook_Category;
        private Guna.UI.WinForms.GunaGradientButton btnBook_NewCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBook_IDs;
        private Guna.UI.WinForms.GunaNumeric numBookAdd_NumberOfBooks;
    }
}