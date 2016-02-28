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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Customer cu;
        public Login(Customer c)
        {
            InitializeComponent();
            this.cu = c;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            SqlConnection connection = SearchCustomer.CreateConection();

            using (connection)
            {
                SqlCommand mycommand = new SqlCommand("sp_User", connection);
                mycommand.CommandType = CommandType.StoredProcedure;
                mycommand.CommandText = "sp_User";

               

                SqlParameter user = new SqlParameter("@Name", SqlDbType.NVarChar);
                if (txtUsename.Text != "")
                {
                    user.Value = txtUsename.Text;
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
                    //connection.Open();
                    //mycommand.ExecuteNonQuery();
                    //MessageBox.Show("Потребителя влезна успешно!");

                    connection.Open();

                    object res = mycommand.ExecuteScalar();
                    if (res == null)
                    {
                        MessageBox.Show("Грешен потребител/парола!");
                    }
                    else
                    {
                       
                            MessageBox.Show("Успешен вход!");
                            Menu menu = new Menu();
                            menu.Show();
                            this.Hide();
                    }
                }
                catch (SqlException ol)
                {

                    MessageBox.Show(ol.Message.ToString());
                }

                this.Refresh();

            }


           // this.Hide();

        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationUsers reg = new RegistrationUsers();
            reg.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

            //???? zashto ne mi se prehavarlqt parametrite m/u formite
            Customer CUST = new Customer();
            txtPass.Text = CUST.Pass;
            txtUsename.Text = CUST.UserName;

        }
    }
}
