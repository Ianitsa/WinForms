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
    public partial class SearchCustomer : Form
    {
        public SearchCustomer()
        {
            InitializeComponent();
        }

        


        private void btnExitLC_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ListCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Сигурни ли сте,че искате да затворите?", "Изход?", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        public static SqlConnection CreateConection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=XXX-PC\SQLEXPRESS;Initial Catalog=kursovaSQL;Integrated Security=True";
            return conn;
        }

        private void BtnSearchC_Click(object sender, EventArgs e)
        {
            SqlConnection connection = SearchCustomer.CreateConection();
             using (connection)
             {
                 SqlCommand mycommand = new SqlCommand("sp_SearchCustomer", connection);
                 mycommand.CommandType = CommandType.StoredProcedure;
                 mycommand.CommandText = "sp_SearchCustomer";



                 SqlParameter CustomerID = new SqlParameter("@C_id", SqlDbType.Int);
                 if (txtCNo.Text != "")
                 {
                     CustomerID.Value = Convert.ToInt32(txtCNo.Text);
                 }
                 mycommand.Parameters.Add(CustomerID);

                 SqlParameter Name = new SqlParameter("@C_Fname", SqlDbType.NVarChar);
                 if (txtCName.Text != "")
                 {
                     Name.Value = txtCName.Text;
                 }
                 mycommand.Parameters.Add(Name);

                 SqlParameter LName = new SqlParameter("@C_Lname", SqlDbType.NVarChar);
                 if (txtCLName.Text != "")
                 {
                     LName.Value = txtCLName.Text;
                 }
                 mycommand.Parameters.Add(LName);

                 try
                 {
                     connection.Open();
                     SqlDataReader reader = mycommand.ExecuteReader();
                     if (reader.HasRows)
                     {
                         DataTable dt = new DataTable();
                         dt.Load(reader);
                         dgv_SearchCustomer.DataSource = dt;

                        dt.Columns["C_id"].ColumnName = "Клиент номер";
                       dt.Columns["C_Fname"].ColumnName = "Име";
                       dt.Columns["C_Lname"].ColumnName = "Фамилия";
                         //dt.Columns["CLIENT_TYPE"].ColumnName = "Тип клиент";
                         //dt.Columns["CLIENT_EGN_BULSTAT"].ColumnName = "ЕГН/БУЛСТАТ";
                         //dt.Columns["CLIENT_FULLNAME"].ColumnName = "Име/Фирма";
                         //dt.Columns["EMAIL"].ColumnName = "Емайл";
                         //dt.Columns["TELEPHONE"].ColumnName = "Телефон";
                         //dt.Columns["ADRESS_TEXT"].ColumnName = "Адрес";
                         //dt.Columns["CLIENT_NOTE"].ColumnName = "Заележка";
                         //dt.Columns["MODIF_DATE"].ColumnName = "модифицирам на :";


                     }
                     else
                     {
                         MessageBox.Show("Няма намерен клиент!");

                     }
                     reader.Close();
                 }
                 catch (SqlException ol)
                 {

                     MessageBox.Show(ol.Message.ToString());
                 }

             }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            NewCustomer frm = new NewCustomer();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer cu = new Customer();

            
            cu.Cust_Id = Convert.ToString(dgv_SearchCustomer.CurrentRow.Cells[0].Value);
            cu.Name = Convert.ToString(dgv_SearchCustomer.CurrentRow.Cells[1].Value);
            cu.LName = Convert.ToString(dgv_SearchCustomer.CurrentRow.Cells[2].Value);
            cu.Address = Convert.ToString(dgv_SearchCustomer.CurrentRow.Cells[3].Value);
            cu.City=Convert.ToString(dgv_SearchCustomer.CurrentRow.Cells[4].Value);
            cu.Country = Convert.ToString(dgv_SearchCustomer.CurrentRow.Cells[5].Value);
            //todo

            RedactionCustomer frm = new RedactionCustomer(cu);
            frm.MdiParent = this.MdiParent;
            frm.Show();


        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Customer cu = new Customer();
            cu.Cust_Id = Convert.ToString(dgv_SearchCustomer.CurrentRow.Cells[0].Value);
            cu.Name = Convert.ToString(dgv_SearchCustomer.CurrentRow.Cells[1].Value);
            cu.LName = Convert.ToString(dgv_SearchCustomer.CurrentRow.Cells[2].Value);
            cu.Address = Convert.ToString(dgv_SearchCustomer.CurrentRow.Cells[3].Value);
            cu.City = Convert.ToString(dgv_SearchCustomer.CurrentRow.Cells[4].Value);
            cu.Country = Convert.ToString(dgv_SearchCustomer.CurrentRow.Cells[5].Value);
            //todo

            RedactionCustomer frm = new RedactionCustomer(cu);
            frm.MdiParent = this.MdiParent;
            frm.Show();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            // saleBindingSource.AddNew();
        }

        private void redactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Customer cu = new Customer();
            cu.Cust_Id = Convert.ToString(dgv_SearchCustomer.CurrentRow.Cells[0].Value);
            cu.Name = Convert.ToString(dgv_SearchCustomer.CurrentRow.Cells[1].Value);
            cu.LName = Convert.ToString(dgv_SearchCustomer.CurrentRow.Cells[2].Value);
            cu.Address = Convert.ToString(dgv_SearchCustomer.CurrentRow.Cells[3].Value);
            cu.City = Convert.ToString(dgv_SearchCustomer.CurrentRow.Cells[4].Value);
            cu.Country = Convert.ToString(dgv_SearchCustomer.CurrentRow.Cells[5].Value);
            

            RedactionCustomer frm = new RedactionCustomer(cu);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            

            Customer cu = new Customer();
            cu.Cust_Id = Convert.ToString(dgv_SearchCustomer.CurrentRow.Cells[0].Value);
            cu.Name = Convert.ToString(dgv_SearchCustomer.CurrentRow.Cells[1].Value);
            cu.LName = Convert.ToString(dgv_SearchCustomer.CurrentRow.Cells[2].Value);
            cu.Address = Convert.ToString(dgv_SearchCustomer.CurrentRow.Cells[3].Value);
            cu.City = Convert.ToString(dgv_SearchCustomer.CurrentRow.Cells[4].Value);
            cu.Country = Convert.ToString(dgv_SearchCustomer.CurrentRow.Cells[5].Value);
            
          

            RedactionCustomer frm = new RedactionCustomer(cu);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            NewCustomer frm = new NewCustomer();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        
    }
}
