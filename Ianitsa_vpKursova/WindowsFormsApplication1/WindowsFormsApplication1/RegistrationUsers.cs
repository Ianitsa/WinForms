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
    public partial class RegistrationUsers : Form
    {
        public RegistrationUsers()
        {
            InitializeComponent();
        }

        Customer cust;
        //public RegistrationUsers(Customer customer)
        //{
        //    InitializeComponent();
        //    this.cust = customer;
        //}
       

        private void RegistrationUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Сигурни ли сте,че искате да затворите?", "Изход?", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPass.Clear();

            this.Hide();
            Login log = new Login();
            log.Show();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection connection = SearchCustomer.CreateConection();

            using (connection)
            {
                SqlCommand mycommand = new SqlCommand("sp_User", connection);
                mycommand.CommandType = CommandType.StoredProcedure;
                mycommand.CommandText = "sp_User";



                SqlParameter user = new SqlParameter("@Name", SqlDbType.NVarChar);
                if (txtUsername.Text != "")
                {
                    user.Value = txtUsername.Text;
                }
                mycommand.Parameters.Add(user);

                SqlParameter pass = new SqlParameter("@Pass", SqlDbType.NVarChar);
                if (txtPass.Text != "")
                {
                    pass.Value = txtPass.Text;
                }
                mycommand.Parameters.Add(pass);

                try
                {
                    connection.Open();
                    mycommand.ExecuteNonQuery();
                    MessageBox.Show("Потребителя беше добавен успешно!");
                    

                    Customer cus=new Customer();
                    cus.UserName = txtUsername.Text;
                    cus.Pass = txtPass.Text;

                    Login menu = new Login(cus);
                    menu.Show();
                    this.Hide();

                }
                catch (SqlException ol)
                {

                    MessageBox.Show(ol.Message.ToString());
                }

                this.Refresh();
            }
        }
    }
}
