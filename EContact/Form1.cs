using EContact.econtactClasses;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EContact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        contactClass c = new contactClass();

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.FirstName = txtboxFirstName.Text;
            c.LastName = txtboxLastName.Text;
            c.ContactNo = txtboxContactNo.Text;
            c.Address = txtboxAddress.Text;
            c.Gender = cmbGender.Text;

            //Insert data in the database
            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("New Contact has been successfully added!");
                //Clear method
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to add a new Contact.Try Again!");
            }
            //Previews data on the grid view

            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Ppreviews data on the grid view

            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;

        }

        //Method to clear the field the user typed on.

        public void Clear()
        {
            txtboxFirstName.Text = "";
            txtboxLastName.Text = "";
            txtboxContactNo.Text = "";
            txtboxAddress.Text = "";
            cmbGender.Text = "";
            txtboxContactID.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get data from text box
            c.ContactID = int.Parse(txtboxContactID.Text);
            c.FirstName = txtboxFirstName.Text;
            c.LastName = txtboxLastName.Text;
            c.ContactNo = txtboxContactNo.Text;
            c.Address = txtboxAddress.Text;
            c.Gender = cmbGender.Text;

            //Updates the data 

            bool success = c.Update(c);
            if (success == true)
            {
                MessageBox.Show("Contact has been Updated!");

                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;

                //Clear method 
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to update Contact.Try again!");
            }
        }

        private void dgvContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Gets the data from grid and puts it on the text fields ,reverses the process of adding it.

            int rowIndex = e.RowIndex;
            txtboxContactID.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            txtboxFirstName.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            txtboxLastName.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            txtboxContactNo.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
            txtboxAddress.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
            cmbGender.Text = dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Get contact id from app

            c.ContactID = Convert.ToInt32(txtboxContactID.Text);
            bool success = c.Delete(c);
            if (success == true)
            {
                MessageBox.Show("Contact has been succesfully deleted!");
                //Refresh grid view
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                //Clear the fields
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to delete the selected contact.Try Again!");
            }
        }

        //Connect database to search event
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            //Gets the value from the textbox
            string keyword = txtboxSearch.Text;
            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_contact WHERE FirstName LIKE '%" + keyword + "%' OR LastName LIKE '&" + keyword + "&' OR Address LIKE '&" + keyword + "&'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvContactList.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
