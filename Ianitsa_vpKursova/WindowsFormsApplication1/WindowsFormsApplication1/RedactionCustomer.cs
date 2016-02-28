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
    public partial class RedactionCustomer : Form
    {
        public RedactionCustomer()
        {
            InitializeComponent();
        }
       //!!!!!!!!!!!
        Customer cust;
        public RedactionCustomer(Customer cu)
        {
            InitializeComponent();
            this.cust = cu;
        }



        private void btnExitLC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RedactionCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Сигурни ли сте,че искате да затворите?", "Изход?", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void RedactionCustomer_Load(object sender, EventArgs e)
        {
            //Customer CUST = new Customer();

            //taka li e???????
            txtCNo.Text = cust.Cust_Id;
            txtCName.Text = cust.Name;
            txtCLName.Text = cust.LName;
            txtCAddress.Text = cust.Address;
            txtCCity.Text = cust.City;
            txtCCountry.Text = cust.Country;

            
            //todo
        }

        private void BtnUpdateLC_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Сигурни ли сте да редактирате? ");
            if (msg==DialogResult.Yes)
            {
                SqlConnection connection = SearchCustomer.CreateConection();

                using (connection)
                {
                    //да проверя дали работи!!!!!!!!!!!!

                    SqlCommand mycommand = new SqlCommand("sp_updateCustomers", connection);
                    mycommand.CommandType = CommandType.StoredProcedure;
                    mycommand.CommandText = "sp_updateCustomers";

                    SqlParameter CustomerID = new SqlParameter("@C_id", SqlDbType.Int);
                    if (txtCNo.Text != "")
                    {
                        CustomerID.Value = Convert.ToInt32(txtCNo.Text);
                    }
                    mycommand.Parameters.Add(CustomerID);

                    SqlParameter Name = new SqlParameter("@FName", SqlDbType.NVarChar);
                    if (txtCName.Text != "")
                    {
                        Name.Value = txtCName.Text;
                    }
                    mycommand.Parameters.Add(Name);

                    SqlParameter LName = new SqlParameter("@LName", SqlDbType.NVarChar);
                    if (txtCLName.Text != "")
                    {
                        LName.Value = txtCLName.Text;
                    }
                    mycommand.Parameters.Add(LName);


                    //TODO
                    SqlParameter address = new SqlParameter("@Address", SqlDbType.NVarChar);
                    if (txtCAddress.Text != "")
                    {
                        address.Value = txtCAddress.Text;
                    }
                    mycommand.Parameters.Add(address);

                    SqlParameter city = new SqlParameter("@City", SqlDbType.NVarChar);
                    if (txtCCity.Text != "")
                    {
                        city.Value = txtCCity.Text;
                    }
                    mycommand.Parameters.Add(city);

                    SqlParameter country = new SqlParameter("@Country", SqlDbType.NVarChar);
                    if (txtCCountry.Text != "")
                    {
                        country.Value = txtCCountry.Text;
                    }
                    mycommand.Parameters.Add(country);



                    try
                    {
                        connection.Open();
                        mycommand.ExecuteNonQuery();
                        MessageBox.Show("Kлиента беше променен успешно!");
                    }
                    catch (SqlException ol)
                    {

                        MessageBox.Show(ol.Message.ToString());
                    }

                } 
            }
            
        }

        private void btnDelC_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Сигурни ли сте, че искате да изтриете? ");
            if (msg == DialogResult.Yes)
            {
                SqlConnection connection = SearchCustomer.CreateConection();

                using (connection)
                {
                    

                    SqlCommand mycommand = new SqlCommand("sp_del_Customer", connection);
                    mycommand.CommandType = CommandType.StoredProcedure;
                    mycommand.CommandText = "sp_del_Customer";

                    SqlParameter CustomerID = new SqlParameter("@C_id", SqlDbType.Int);
                    if (txtCNo.Text != "")
                    {
                        CustomerID.Value = Convert.ToInt32(txtCNo.Text);
                    }
                    mycommand.Parameters.Add(CustomerID);

                    //TODO

                    try
                    {
                        connection.Open();
                        mycommand.ExecuteNonQuery();
                        MessageBox.Show("Kлиента беше изтрит успешно!");
                    }
                    catch (SqlException ol)
                    {

                        MessageBox.Show(ol.Message.ToString());
                    }
            }

           
            }
        }
    }
}
