
namespace CMPG223_Assignment
{
    partial class BookForm
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
            this.DGWBook = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchBookID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtEnterBookTitle = new System.Windows.Forms.TextBox();
            this.txtEnterBookId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sbPrice = new System.Windows.Forms.HScrollBar();
            this.cbBookId = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnInsertBook = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGenre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGWBook)).BeginInit();
            this.SuspendLayout();
            // 
            // DGWBook
            // 
            this.DGWBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWBook.Location = new System.Drawing.Point(11, 12);
            this.DGWBook.Name = "DGWBook";
            this.DGWBook.RowHeadersWidth = 51;
            this.DGWBook.RowTemplate.Height = 24;
            this.DGWBook.Size = new System.Drawing.Size(639, 360);
            this.DGWBook.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(698, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by book ID:";
            // 
            // txtSearchBookID
            // 
            this.txtSearchBookID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearchBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBookID.Location = new System.Drawing.Point(888, 12);
            this.txtSearchBookID.Name = "txtSearchBookID";
            this.txtSearchBookID.Size = new System.Drawing.Size(100, 26);
            this.txtSearchBookID.TabIndex = 0;
            this.txtSearchBookID.TextChanged += new System.EventHandler(this.txtSearchBookID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(688, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search by book Title";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(888, 55);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 26);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtEnterBookTitle
            // 
            this.txtEnterBookTitle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEnterBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterBookTitle.Location = new System.Drawing.Point(888, 210);
            this.txtEnterBookTitle.Name = "txtEnterBookTitle";
            this.txtEnterBookTitle.Size = new System.Drawing.Size(100, 26);
            this.txtEnterBookTitle.TabIndex = 4;
            // 
            // txtEnterBookId
            // 
            this.txtEnterBookId.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEnterBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterBookId.Location = new System.Drawing.Point(888, 329);
            this.txtEnterBookId.Name = "txtEnterBookId";
            this.txtEnterBookId.Size = new System.Drawing.Size(100, 26);
            this.txtEnterBookId.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(656, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter book ID to Update:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(722, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter Genre ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(718, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Enter book Title:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(716, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Search by Price:";
            // 
            // sbPrice
            // 
            this.sbPrice.Location = new System.Drawing.Point(888, 98);
            this.sbPrice.Maximum = 500;
            this.sbPrice.Name = "sbPrice";
            this.sbPrice.Size = new System.Drawing.Size(100, 21);
            this.sbPrice.TabIndex = 2;
            this.sbPrice.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbPrice_Scroll);
            // 
            // cbBookId
            // 
            this.cbBookId.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBookId.FormattingEnabled = true;
            this.cbBookId.Location = new System.Drawing.Point(238, 434);
            this.cbBookId.Name = "cbBookId";
            this.cbBookId.Size = new System.Drawing.Size(121, 28);
            this.cbBookId.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(255, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Book ID:";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(238, 468);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(109, 30);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove Book";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnUpdateBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBook.Location = new System.Drawing.Point(997, 325);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(109, 35);
            this.btnUpdateBook.TabIndex = 8;
            this.btnUpdateBook.Text = "Update Book";
            this.btnUpdateBook.UseVisualStyleBackColor = false;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(935, 169);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 20);
            this.lblPrice.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 500);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 63);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back to Acces Form ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbSelect
            // 
            this.cbSelect.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Location = new System.Drawing.Point(572, 511);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(121, 28);
            this.cbSelect.TabIndex = 23;
            this.cbSelect.SelectedIndexChanged += new System.EventHandler(this.cbSelect_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(589, 478);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Select Book:";
            // 
            // btnInsertBook
            // 
            this.btnInsertBook.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnInsertBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertBook.Location = new System.Drawing.Point(994, 252);
            this.btnInsertBook.Name = "btnInsertBook";
            this.btnInsertBook.Size = new System.Drawing.Size(109, 35);
            this.btnInsertBook.TabIndex = 6;
            this.btnInsertBook.Text = "Insert Book";
            this.btnInsertBook.UseVisualStyleBackColor = false;
            this.btnInsertBook.Click += new System.EventHandler(this.btnInsertBook_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(720, 500);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(147, 63);
            this.btnSelect.TabIndex = 25;
            this.btnSelect.Text = "Select Book for order";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(888, 253);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 26);
            this.txtPrice.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(751, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Enter Price:";
            // 
            // btnGenre
            // 
            this.btnGenre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnGenre.Location = new System.Drawing.Point(888, 169);
            this.btnGenre.Name = "btnGenre";
            this.btnGenre.Size = new System.Drawing.Size(100, 25);
            this.btnGenre.TabIndex = 4;
            this.btnGenre.Text = "Genre";
            this.btnGenre.UseVisualStyleBackColor = false;
            this.btnGenre.Click += new System.EventHandler(this.btnGenre_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CMPG223_Assignment.Properties.Resources.Bible_726x400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1118, 575);
            this.Controls.Add(this.btnGenre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbSelect);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbBookId);
            this.Controls.Add(this.sbPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnInsertBook);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEnterBookId);
            this.Controls.Add(this.txtEnterBookTitle);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchBookID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGWBook);
            this.Name = "BookForm";
            this.Text = "Book Form";
            this.Load += new System.EventHandler(this.BookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGWBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGWBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchBookID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtEnterBookTitle;
        private System.Windows.Forms.TextBox txtEnterBookId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInsertBook;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.HScrollBar sbPrice;
        private System.Windows.Forms.ComboBox cbBookId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGenre;
    }
}