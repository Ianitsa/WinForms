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
    public partial class SearchSales : Form
    {
        public SearchSales()
        {
            InitializeComponent();
        }

        private void btnExitLS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListOfSales_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult res = MessageBox.Show("Сигурни ли сте,че искате да затворите?", "Изход?", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSearchS_Click(object sender, EventArgs e)
        {
            SqlConnection connection = SearchCustomer.CreateConection();
            using (connection)
            {
                SqlCommand mycommand = new SqlCommand("sp_SearchSales", connection);
                mycommand.CommandType = CommandType.StoredProcedure;
                mycommand.CommandText = "sp_SearchSales";

               

                SqlParameter OrderID = new SqlParameter("@Order_id", SqlDbType.Int);
                if (txtOrderNo.Text != "")
                {
                    OrderID.Value = Convert.ToInt32(txtOrderNo.Text);
                }
                mycommand.Parameters.Add(OrderID);

                SqlParameter Name = new SqlParameter("@C_Fname", SqlDbType.NVarChar);
                if (txtName.Text != "")
                {
                    Name.Value = txtName.Text;
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
                        dgv_SearchS.DataSource = dt;

                         dt.Columns["C_id"].ColumnName = "Клиент номер";
                        dt.Columns["Order_id"].ColumnName = "Поръчка №";
                        dt.Columns["C_Fname"].ColumnName = "Име";
                        dt.Columns["C_Lname"].ColumnName = "Фамилия";
                        //dt.Columns["EMAIL"].ColumnName = "Емайл";
                        //dt.Columns["TELEPHONE"].ColumnName = "Телефон";
                        //dt.Columns["ADRESS_TEXT"].ColumnName = "Адрес";
                        //dt.Columns["CLIENT_NOTE"].ColumnName = "Заележка";
                        //dt.Columns["MODIF_DATE"].ColumnName = "модифицирам на :";


                    }
                    else
                    {
                        MessageBox.Show("Няма намеренa продажба!");

                    }
                    reader.Close();
                }
                catch (SqlException ol)
                {

                    MessageBox.Show(ol.Message.ToString());
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //this.Hide();
           // saleBindingSource.AddNew();

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Customer cu = new Customer();
            Orders ord = new Orders();

            ord.OrderNo = Convert.ToString(dgv_SearchS.CurrentRow.Cells[0].Value);
            cu.Cust_Id = Convert.ToString(dgv_SearchS.CurrentRow.Cells[1].Value);
            cu.Name = Convert.ToString(dgv_SearchS.CurrentRow.Cells[2].Value);
            cu.LName = Convert.ToString(dgv_SearchS.CurrentRow.Cells[3].Value);
           // cu.Address = Convert.ToString(dgv_SearchS.CurrentRow.Cells[3].Value);
            cu.City = Convert.ToString(dgv_SearchS.CurrentRow.Cells[5].Value);
            cu.Country = Convert.ToString(dgv_SearchS.CurrentRow.Cells[4].Value);
            ord.Product = Convert.ToString(dgv_SearchS.CurrentRow.Cells[6].Value);
            ord.Price = Convert.ToString(dgv_SearchS.CurrentRow.Cells[7].Value);
            ord.Quantity = Convert.ToString(dgv_SearchS.CurrentRow.Cells[8].Value);
            ord.OrderDate = Convert.ToString(dgv_SearchS.CurrentRow.Cells[9].Value);
            ord.SheepedDate = Convert.ToString(dgv_SearchS.CurrentRow.Cells[10].Value);



            RedactionSales frm = new RedactionSales(cu,ord);
            frm.MdiParent = this.MdiParent;
            frm.Show();


        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();


            Customer cu = new Customer();
            Orders ord = new Orders();

            ord.OrderNo = Convert.ToString(dgv_SearchS.CurrentRow.Cells[0].Value);
            cu.Cust_Id = Convert.ToString(dgv_SearchS.CurrentRow.Cells[1].Value);
            cu.Name = Convert.ToString(dgv_SearchS.CurrentRow.Cells[2].Value);
            cu.LName = Convert.ToString(dgv_SearchS.CurrentRow.Cells[3].Value);
            // cu.Address = Convert.ToString(dgv_SearchS.CurrentRow.Cells[3].Value);
            cu.City = Convert.ToString(dgv_SearchS.CurrentRow.Cells[5].Value);
            cu.Country = Convert.ToString(dgv_SearchS.CurrentRow.Cells[4].Value);
            ord.Product = Convert.ToString(dgv_SearchS.CurrentRow.Cells[6].Value);
            ord.Price = Convert.ToString(dgv_SearchS.CurrentRow.Cells[7].Value);
            ord.Quantity = Convert.ToString(dgv_SearchS.CurrentRow.Cells[8].Value);
            ord.OrderDate = Convert.ToString(dgv_SearchS.CurrentRow.Cells[9].Value);
            ord.SheepedDate = Convert.ToString(dgv_SearchS.CurrentRow.Cells[10].Value);

            RedactionSales frm = new RedactionSales(cu,ord);
            frm.MdiParent = this.MdiParent;
            frm.Show();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            NewSales frm = new NewSales();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void redactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();



            Customer cu = new Customer();
            Orders ord = new Orders();

            ord.OrderNo = Convert.ToString(dgv_SearchS.CurrentRow.Cells[0].Value);
            cu.Cust_Id = Convert.ToString(dgv_SearchS.CurrentRow.Cells[1].Value);
            cu.Name = Convert.ToString(dgv_SearchS.CurrentRow.Cells[2].Value);
            cu.LName = Convert.ToString(dgv_SearchS.CurrentRow.Cells[3].Value);
            // cu.Address = Convert.ToString(dgv_SearchS.CurrentRow.Cells[3].Value);
            cu.City = Convert.ToString(dgv_SearchS.CurrentRow.Cells[5].Value);
            cu.Country = Convert.ToString(dgv_SearchS.CurrentRow.Cells[4].Value);
            ord.Product = Convert.ToString(dgv_SearchS.CurrentRow.Cells[6].Value);
            ord.Price = Convert.ToString(dgv_SearchS.CurrentRow.Cells[7].Value);
            ord.Quantity = Convert.ToString(dgv_SearchS.CurrentRow.Cells[8].Value);
            ord.OrderDate = Convert.ToString(dgv_SearchS.CurrentRow.Cells[9].Value);
            ord.SheepedDate = Convert.ToString(dgv_SearchS.CurrentRow.Cells[10].Value);

            RedactionSales frm = new RedactionSales(cu,ord);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();


            Customer cu = new Customer();
            Orders ord = new Orders();

            ord.OrderNo = Convert.ToString(dgv_SearchS.CurrentRow.Cells[0].Value);
            cu.Cust_Id = Convert.ToString(dgv_SearchS.CurrentRow.Cells[1].Value);
            cu.Name = Convert.ToString(dgv_SearchS.CurrentRow.Cells[2].Value);
            cu.LName = Convert.ToString(dgv_SearchS.CurrentRow.Cells[3].Value);
            // cu.Address = Convert.ToString(dgv_SearchS.CurrentRow.Cells[3].Value);
            cu.City = Convert.ToString(dgv_SearchS.CurrentRow.Cells[5].Value);
            cu.Country = Convert.ToString(dgv_SearchS.CurrentRow.Cells[4].Value);
            ord.Product = Convert.ToString(dgv_SearchS.CurrentRow.Cells[6].Value);
            ord.Price = Convert.ToString(dgv_SearchS.CurrentRow.Cells[7].Value);
            ord.Quantity = Convert.ToString(dgv_SearchS.CurrentRow.Cells[8].Value);
            ord.OrderDate = Convert.ToString(dgv_SearchS.CurrentRow.Cells[9].Value);
            ord.SheepedDate = Convert.ToString(dgv_SearchS.CurrentRow.Cells[10].Value);

            RedactionSales frm = new RedactionSales(cu,ord);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            NewSales frm = new NewSales();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

    }
}
