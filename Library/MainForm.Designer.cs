namespace Library
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StripMenuItemDeleteBook = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItemEditBook = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.BooksTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.DatePublishedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuItemDeleteBook,
            this.StripMenuItemEditBook});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(223, 80);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // StripMenuItemDeleteBook
            // 
            this.StripMenuItemDeleteBook.Name = "StripMenuItemDeleteBook";
            this.StripMenuItemDeleteBook.Size = new System.Drawing.Size(222, 24);
            this.StripMenuItemDeleteBook.Text = "Удалить книгу";
            this.StripMenuItemDeleteBook.Click += new System.EventHandler(this.StripMenuItemDeleteBook_Click);
            // 
            // StripMenuItemEditBook
            // 
            this.StripMenuItemEditBook.Name = "StripMenuItemEditBook";
            this.StripMenuItemEditBook.Size = new System.Drawing.Size(222, 24);
            this.StripMenuItemEditBook.Text = "Редактировать книгу";
            this.StripMenuItemEditBook.Click += new System.EventHandler(this.StripMenuItemEditBook_Click);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewBooks.Location = new System.Drawing.Point(12, 40);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBooks.RowHeadersWidth = 51;
            this.dataGridViewBooks.RowTemplate.Height = 24;
            this.dataGridViewBooks.Size = new System.Drawing.Size(770, 446);
            this.dataGridViewBooks.TabIndex = 1;
            this.dataGridViewBooks.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellEndEdit);
            this.dataGridViewBooks.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewBooks_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(62, 10);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(581, 22);
            this.SearchTextBox.TabIndex = 3;
            // 
            // BooksTextBox
            // 
            this.BooksTextBox.Location = new System.Drawing.Point(788, 40);
            this.BooksTextBox.Multiline = true;
            this.BooksTextBox.Name = "BooksTextBox";
            this.BooksTextBox.ReadOnly = true;
            this.BooksTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BooksTextBox.Size = new System.Drawing.Size(423, 444);
            this.BooksTextBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddBookButton);
            this.groupBox1.Controls.Add(this.DatePublishedDateTimePicker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AuthorTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TitleTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 501);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1185, 71);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить новую книгу:";
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(871, 30);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(173, 24);
            this.AddBookButton.TabIndex = 6;
            this.AddBookButton.Text = "Добавить книгу";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // DatePublishedDateTimePicker
            // 
            this.DatePublishedDateTimePicker.CustomFormat = "yyyy";
            this.DatePublishedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePublishedDateTimePicker.Location = new System.Drawing.Point(794, 30);
            this.DatePublishedDateTimePicker.Name = "DatePublishedDateTimePicker";
            this.DatePublishedDateTimePicker.Size = new System.Drawing.Size(71, 22);
            this.DatePublishedDateTimePicker.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(673, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Год публикации:";
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(391, 30);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(276, 22);
            this.AuthorTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Автор:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(88, 30);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(241, 22);
            this.TitleTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Название:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 583);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BooksTextBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewBooks);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Моя библиотека";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItemDeleteBook;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItemEditBook;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.TextBox BooksTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.DateTimePicker DatePublishedDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

