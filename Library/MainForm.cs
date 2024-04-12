using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class MainForm : Form
    {
        private List<Book> books = new List<Book>();
        private bool visibleContexMenu = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitTestBookData()
        {
            books.Add(new Book("Война и мир", "Лев Николаевич Толстой", DateTime.Parse("1867-01-01")));
            books.Add(new Book("Анна Каренина", "Лев Николаевич Толстой", DateTime.Parse("1877-01-01")));
            books.Add(new Book("После бала", "Лев Николаевич Толстой", DateTime.Parse("1911-01-01")));
            books.Add(new Book("Юность", "Лев Николаевич Толстой", DateTime.Parse("1857-01-01")));
            books.Add(new Book("Кавказский пленник", "Лев Николаевич Толстой", DateTime.Parse("1872-01-01")));
            books.Add(new Book("Пиковая дама", "Александр Сергеевич Пушкин", DateTime.Parse("1834-01-01")));
            books.Add(new Book("Евгений Онегин", "Александр Сергеевич Пушкин", DateTime.Parse("1833-01-01")));
            books.Add(new Book("Мёртвые души", "Николай Васильевич Гоголь", DateTime.Parse("1842-01-01")));
            books.Add(new Book("Нос", "Николай Васильевич Гоголь", DateTime.Parse("1836-01-01")));
            books.Add(new Book("Тарас Бульба", "Николай Васильевич Гоголь", DateTime.Parse("1835-01-01")));
        }

        private List<Book> GetFilteredBooks()
        { 
            List<Book> result = new List<Book>();
            string SearchBook = SearchTextBox.Text;
            
            if (SearchBook.Length == 0 )
            {
                return books;
            }

            SearchBook = SearchBook.ToLower();

            foreach (Book book in books)
            {
                if(book.Title.Length>0 && book.Title.ToLower().Contains(SearchBook) ||
                    book.Author.Length > 0 && book.Author.ToLower().Contains(SearchBook) ||
                    book.YearPublished.Length > 0 && book.YearPublished.Contains(SearchBook))
                {
                    result.Add(book);
                }
            }

            return result;
        }

        private void RefreshDataGridView()
        {
            dataGridViewBooks.DataSource = null;
            dataGridViewBooks.DataSource = GetFilteredBooks();

            dataGridViewBooks.Columns["Title"].HeaderText = "Название";
            dataGridViewBooks.Columns["Title"].Width = 150;

            dataGridViewBooks.Columns["Author"].HeaderText = "Автор";
            dataGridViewBooks.Columns["Author"].Width = 200;

            dataGridViewBooks.Columns["DatePublished"].HeaderText = "Дата извания";
            dataGridViewBooks.Columns["DatePublished"].Width = 200;
            dataGridViewBooks.Columns["DatePublished"].Visible = false;

            dataGridViewBooks.Columns["YearPublished"].HeaderText = "Год публикации";
            dataGridViewBooks.Columns["YearPublished"].Width = 200;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitTestBookData();
            RefreshDataGridView();
            UpdateBooks();
        }

        private void UpdateBooks()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Books: [\r\n");
            foreach (Book book in books)
            {
                sb.Append(book.ToString());
                sb.Append("\r\n");
            }
            sb.Append("]");

            BooksTextBox.Text = sb.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //RefreshDataGridView();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = DatePublishedDateTimePicker.Value;
            DateTime dateDate = DateTime.Parse(selectedDate.ToString("dd.MM.yyyy"));

            Book newBook = new Book(TitleTextBox.Text, AuthorTextBox.Text, dateDate);
            
            books.Add(newBook);

            RefreshDataGridView(); 
            UpdateBooks();

            TitleTextBox.Text = "";
            AuthorTextBox.Text = "";
            DatePublishedDateTimePicker.Value = DateTime.Now;

            TitleTextBox.Focus();
        }

        private void dataGridViewBooks_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;

            DataGridViewCell cell = dataGridViewBooks[col, row];

            object cellValue = cell.Value;

            Book book = books[row];
            switch (col)
            {
                case 0:
                    book.Title = (string)cellValue;
                    break;
                case 1:
                    book.Author = (string)cellValue;
                    break;
                case 2:
                    book.DatePublished = (DateTime)cellValue;
                    break;

            }
            RefreshDataGridView();
        }

        private void dataGridViewBooks_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                var testInfo = dataGridViewBooks.HitTest(e.X, e.Y);
                if (testInfo.RowIndex >= 0 && testInfo.ColumnIndex >= 0)
                {
                    dataGridViewBooks.ClearSelection();
                    dataGridViewBooks.Rows[testInfo.RowIndex].Selected = true;
                    visibleContexMenu = false;
                }
                else
                {
                    visibleContexMenu = true;
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(visibleContexMenu)
            {
                e.Cancel = true;
            }
        }

        private void StripMenuItemEditBook_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridViewBooks.SelectedRows;

            foreach(DataGridViewRow selectedRow in selectedRows)
            {
                int rowIndex = selectedRow.Index;

                Book book = books[rowIndex];

                EditForm form = new EditForm();
                form.EditBook = book;
                form.BookUpdateEvent += EditForm_BookUpdateEvent;
                form.ShowDialog();
            }
        }

        private void EditForm_BookUpdateEvent(Book updateBook)
        {
            RefreshDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void StripMenuItemDeleteBook_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridViewBooks.SelectedRows;

            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                int rowIndex = selectedRow.Index;

                Book book = books[rowIndex];

                DialogResult dlg = MessageBox.Show("Удалить книгу:\r\n\rАвтор: " + book.Author + 
                        "\r\nНазвание: " + book.Title + "\r\nГод публикации: " + book.YearPublished, 
                        "Подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlg == DialogResult.Yes)
                {
                    books.RemoveAt(rowIndex);
                }
                
                RefreshDataGridView();
            }
        }
    }
}
