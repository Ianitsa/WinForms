using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void btnExitNC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult res = MessageBox.Show("Сигурни ли сте,че искате да затворите?", "Изход?", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSaveNC_Click(object sender, EventArgs e)
        {
            SqlConnection connection = SearchCustomer.CreateConection();
            using (connection)
            {
                SqlCommand mycommand = new SqlCommand("sp_isert_Customer", connection);
                mycommand.CommandType = CommandType.StoredProcedure;
                mycommand.CommandText = "sp_isert_Customer";

//   @Fname nvarchar(20)=null,
//@Lname nvarchar(20)=null,
//@address nvarchar(max)=null,
//@City nvarchar(50)=null,
//@Country nvarchar(50)=null

                //SqlParameter CustomerID = new SqlParameter("@C_id", SqlDbType.Int);
                //if (txtCNo.Text != "")
                //{
                //    CustomerID.Value = Convert.ToInt32(txtCNo.Text);
                //}
                //mycommand.Parameters.Add(CustomerID);

                SqlParameter Name = new SqlParameter("@Fname", SqlDbType.NVarChar);
                if (txtCName.Text != "")
                {
                    Name.Value = txtCName.Text;
                }
                mycommand.Parameters.Add(Name);

                SqlParameter LName = new SqlParameter("@Lname", SqlDbType.NVarChar);
                if (txtCLName.Text != "")
                {
                    LName.Value = txtCLName.Text;
                }
                mycommand.Parameters.Add(LName);

                SqlParameter address = new SqlParameter("@address", SqlDbType.NVarChar);
                if (txtCAddress.Text != "")
                {
                    address.Value = txtCAddress.Text;
                }
                mycommand.Parameters.Add(address);

                SqlParameter City = new SqlParameter("@City", SqlDbType.NVarChar);
                if (txtCCity.Text != "")
                {
                    City.Value = txtCCity.Text;
                }
                mycommand.Parameters.Add(City);

                SqlParameter Country = new SqlParameter("@Country", SqlDbType.NVarChar);
                if (txtCCountry.Text != "")
                {
                    Country.Value = txtCCountry.Text;
                }
                mycommand.Parameters.Add(Country);


                try
                {
                    connection.Open();
                    mycommand.ExecuteNonQuery();
                    MessageBox.Show("Kлиента беше добавен успешно!");
                }
                catch (SqlException ol)
                {

                    MessageBox.Show(ol.Message.ToString());
                }

                txtCName.Clear();
                txtCLName.Clear();
                txtCCountry.Clear();
                txtCCity.Clear();
                txtCAddress.Clear();
            }
        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {
            

        }

        private void txtCName_Validating(object sender, CancelEventArgs e)
        {
            if (txtCName.Text == "")
            {
                errorProvider1.SetError(txtCName, "Моля, попълнете стойност!");
                e.Cancel = true;
            }
        }

        private void txtCName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCName, "");
        }

        private void txtCLName_Validating(object sender, CancelEventArgs e)
        {
            if (txtCLName.Text == "")
            {
                errorProvider1.SetError(txtCLName, "Моля, попълнете стойност!");
                e.Cancel = true;
            }
        }

        private void txtCLName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCLName, "");
        }

        private void txtCCountry_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCCountry, "");
        }

        private void txtCCountry_Validating(object sender, CancelEventArgs e)
        {
            if (txtCCountry.Text == "")
            {
                errorProvider1.SetError(txtCCountry, "Моля, попълнете стойност!");
                e.Cancel = true;
            }
        }

        private void txtCCity_Validating(object sender, CancelEventArgs e)
        {
            if (txtCCity.Text == "")
            {
                errorProvider1.SetError(txtCCity, "Моля, попълнете стойност!");
                e.Cancel = true;
            }
        }

        private void txtCCity_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCCity, "");
        }

        private void txtCAddress_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCAddress, "");
        }

        private void txtCAddress_Validating(object sender, CancelEventArgs e)
        {
            if (txtCAddress.Text == "")
            {
                errorProvider1.SetError(txtCAddress, "Моля, попълнете стойност!");
                e.Cancel = true;
            }
        }
    }
}
