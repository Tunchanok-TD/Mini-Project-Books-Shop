using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Shop1
{
    public partial class Form1 : Form
    {
        String connectionString = "server=localhost;uid=root;database=book_information_1";
        String mode = "view";
        public Form1()
        {
            InitializeComponent();
        }
        private void Frmloadbook(object sender, EventArgs e)
        {
            loadbook();
            viewMode();
        }
        private void loadbook()
        {
           Book1 Book1 = new Book1();
            List<Book1> lstperson = Book1.getAllBook1();

            Datapreson.DataSource = lstperson;

            selectFirstRow();
        }

        private void selectFirstRow()
        {
            if (Datapreson.Rows.Count > 0)
            {
                int selectRow;
                if (Datapreson.CurrentRow != null)
                {
                    selectRow = Datapreson.CurrentRow.Index;
                }
                else
                {
                    selectRow = 0;
                }
                DataGridViewRow row = this.Datapreson.Rows[selectRow];
                ID.Text = row.Cells["ColID"].Value.ToString();
                Title.Text = row.Cells["ColTitle"].Value.ToString();
                Author.Text = row.Cells["ColAuthor"].Value.ToString();
                Publisher.Text = row.Cells["ColPublisher"].Value.ToString();
                Genre.Text = row.Cells["ColDescription"].Value.ToString();
                NumberOfPages.Value = (int)row.Cells["ColNumberOfPages"].Value;
                Price.Value = (int)row.Cells["ColPrice"].Value;
                Description.Text = row.Cells["ColGenre"].Value.ToString();
            }
        }


        private void viewMode()
        {
            label1.Visible = true;
            label1.Visible = true;

            ID.Enabled = false;
            Title.Enabled = false;
            Author.Enabled = false;
            Publisher.Enabled = false;
            Genre.Enabled = false;
            NumberOfPages.Enabled = false;
            Price.Enabled = false;
            Description.Enabled = false;
         


            Add.Visible = true;
            Edit.Visible = true;
            Delete.Visible = true;

            Cancel.Visible = false;
            Save.Visible = false;

            mode = "view";
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (Datapreson.CurrentRow != null)
            {
                int selectRow = Datapreson.CurrentRow.Index;
                DataGridViewRow row = this.Datapreson.Rows[selectRow];
                ID.Text = row.Cells["ColID"].Value.ToString();
                Title.Text = row.Cells["ColTitle"].Value.ToString();
                Author.Text = row.Cells["ColAuthor"].Value.ToString();
                Publisher.Text = row.Cells["ColPublisher"].Value.ToString();
                Genre.Text = row.Cells["ColDescription"].Value.ToString();
                NumberOfPages.Value = (int)row.Cells["ColNumberOfPages"].Value;
                Price.Value = (int)row.Cells["ColPrice"].Value;
                Description.Text = row.Cells["ColGenre"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Visible = true;


            ID.Enabled = true;
            Title.Enabled = true;
            Author.Enabled = true;
            Publisher.Enabled = true;
            Genre.Enabled = true;
            Description.Enabled = true;
            NumberOfPages.Enabled = true;
            Price.Enabled = true;
            Description.Enabled = true;

            ID.Text = "";
            Title.Text = "";
            Author.Text = "";
            Publisher.Text = "";
            Genre.Text = "";
            NumberOfPages.Value = 0;
            Price.Value = 0;
            Description.Text = "";


            Add.Visible = false;
            Edit.Visible = false;
            Delete.Visible = false;

            Cancel.Visible = false;
            Save.Visible = false;

            mode = "add";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Visible = true;


            ID.Enabled = true;
            Title.Enabled = true;
            Author.Enabled = true;
            Publisher.Enabled = true;
            Genre.Enabled = true;
            Description.Enabled = true;
            NumberOfPages.Enabled = true;
            Price.Enabled = true;
            Description.Enabled = true;


            Add.Visible = false;
            Edit.Visible = false;
            Delete.Visible = false;

            Cancel.Visible = true;
            Save.Visible = true;

            mode = "edit";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this person?", "Confirm Delete?",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.OK)
            {
                Book1 Book1 = new Book1();
                Book1.deleteBook1(Int32.Parse(ID.Text));
                loadbook();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mode == "add")
            {
                Book1 Book1 = new Book1();
                Book1.addBook1(ID.Text, Title.Text, Author.Text, Publisher.Text, (int)NumberOfPages.Value, (int)Price.Value, Description.Text);
            }
            else if (mode == "edit")
            {
                Book1 Book1 = new Book1();
                Book1.updateBook1(Int32.Parse(label1.Text), ID.Text, Title.Text, Author.Text, Publisher.Text, (int)NumberOfPages.Value, (int)Price.Value, Description.Text);
            }
            loadbook();
            viewMode();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (mode == "add")
            {
                selectFirstRow();
            }
            loadbook();
            viewMode();
        }
       
    }
}
