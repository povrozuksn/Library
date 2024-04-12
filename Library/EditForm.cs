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
    public partial class EditForm : Form
    {
        public delegate void DelegateUpdateBook(Book updateBook);
        public event DelegateUpdateBook BookUpdateEvent;
        public Book EditBook { get; set; }

        public EditForm()
        {
            InitializeComponent();

        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            bookBindingSource.Add(EditBook);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Book bookUpdatede = (Book)bookBindingSource.Current;

            if (BookUpdateEvent != null)
            {
                BookUpdateEvent(bookUpdatede);
            }
            Close();
        }
    }
}
