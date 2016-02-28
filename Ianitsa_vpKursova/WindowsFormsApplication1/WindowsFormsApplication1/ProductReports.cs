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
    public partial class ProductReports : Form
    {
        public ProductReports()
        {
            InitializeComponent();
        }

        private void ProductReports_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult res = MessageBox.Show("Сигурни ли сте,че искате да затворите?", "Изход?", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ProductReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kursovaSQLDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.kursovaSQLDataSet.Product);

        }

        private void btnSearchP_Click(object sender, EventArgs e)
        {
             SqlConnection connection = SearchCustomer.CreateConection();
             using (connection)
             {
                 
                 SqlCommand mycommand = new SqlCommand("sp_ReportQtyProduct", connection);
                 mycommand.CommandType = CommandType.StoredProcedure;
                 mycommand.CommandText = "sp_ReportQtyProduct";

                 SqlParameter Prod = new SqlParameter("@Product_name", SqlDbType.NVarChar);
                 if (cbProd.Text != "")
                 {
                     Prod.Value = cbProd.Text;
                 }
                 mycommand.Parameters.Add(Prod);


                 //da smenq imeto na @parametara!!!
                 //SqlParameter Product = new SqlParameter("@C_Fname", SqlDbType.NVarChar);
                 //if (cbProd.Text != "")
                 //{
                 //    Product.Value = cbProd.Text;
                 //}
                 //mycommand.Parameters.Add(Product);

                 try
                 {
                     connection.Open();
                     SqlDataReader reader = mycommand.ExecuteReader();
                     if (reader.HasRows)
                     {
                         DataTable dt = new DataTable();
                         dt.Load(reader);
                         dgv_ReportP.DataSource = dt;

                         //dt.Columns["C_id"].ColumnName = "Клиент номер";
                         //dt.Columns["Order_id"].ColumnName = "Поръчка №";
                         //dt.Columns["C_Fname"].ColumnName = "Име";
                         //dt.Columns["C_Lname"].ColumnName = "Фамилия";
                         


                     }
                     else
                     {
                         MessageBox.Show("Няма намерен продукт!");

                     }
                     reader.Close();
                 }
                 catch (SqlException ol)
                 {

                     MessageBox.Show(ol.Message.ToString());
                 }
             }
        }
    }
}
