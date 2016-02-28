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
    public partial class NewSales : Form
    {
        public NewSales()
        {
            InitializeComponent();
        }

        private void btnExitNS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewSales_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult res = MessageBox.Show("Сигурни ли сте,че искате да затворите?", "Изход?", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        int price;
        int qty;
        int sum;
        private void NewSales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kursovaSQLDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.kursovaSQLDataSet.Product);

            //???
            dateTimePicker1.Enabled = false;
            txtPrice.ReadOnly = true;
            txtSum.ReadOnly = true;
            txtCNo.ReadOnly = true;
            txtOrderID.ReadOnly = true;

             qty = Convert.ToInt32(txtQuantity.Text);

            if (cbProduct.Text=="divan Ara")
            {
                price =350;
                sum = qty * price;

            }
            else if (cbProduct.Text == "stol Miki")
	            {
                    price = 200;
                    sum = qty * price;                
	            }
            else
            {
                price = 100;
                sum = qty * price;  
            }
            txtPrice.Text = price.ToString();
            txtSum.Text = sum.ToString();
            txtQuantity.Text = qty.ToString();
        }

        private void cbProduct_Validating(object sender, CancelEventArgs e)
        {
            if (cbProduct.Text == "")
            {
                errorProvider1.SetError(cbProduct, "Моля, изберете стойност!");
                e.Cancel = true;
            }
        }

        private void cbProduct_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbProduct, "");
        }

        private void txtQuantity_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtQuantity, "");
        }

        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (txtQuantity.Text == "")
            {
                errorProvider1.SetError(txtQuantity, "Моля, попълнете стойност!");
                e.Cancel = true;
            }
        }

        private void btnNS_Click(object sender, EventArgs e)
        {
            //insert

            SqlConnection connection = SearchCustomer.CreateConection();
            using (connection)
            {
                

                SqlCommand mycommand = new SqlCommand("sp_isert_Customer", connection);
                mycommand.CommandType = CommandType.StoredProcedure;
                mycommand.CommandText = "sp_isert_Customer";

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
                    MessageBox.Show("Продажбата беше добавена успешно!");
                }
                catch (SqlException ol)
                {

                    MessageBox.Show(ol.Message.ToString());
                }
            }

             SqlConnection conn = SearchCustomer.CreateConection();
             using (conn)
             {


                 SqlCommand mycommand1 = new SqlCommand("sp_insertOrders", conn);
                 mycommand1.CommandType = CommandType.StoredProcedure;
                 mycommand1.CommandText = "sp_insertOrders";

                 SqlParameter CustomerID = new SqlParameter("@C_id", SqlDbType.Int);
                 if (txtCNo.Text != "")
                 {
                     CustomerID.Value = Convert.ToInt32(txtCNo.Text);
                 }
                 mycommand1.Parameters.Add(CustomerID);


                 SqlParameter ord = new SqlParameter("@Order_date", SqlDbType.DateTime);
                 if (txtCName.Text != "")
                 {
                     ord.Value = dateTimePicker1.Value;
                 }
                 mycommand1.Parameters.Add(ord);

                 SqlParameter shd = new SqlParameter("@Sheeped_date", SqlDbType.DateTime);
                 if (txtCLName.Text != "")
                 {
                     shd.Value = dateTimePicker2.Value;
                 }
                 mycommand1.Parameters.Add(shd);

                 try
                 {
                     conn.Open();
                     mycommand1.ExecuteNonQuery();
                     MessageBox.Show("Продажбата беше добавена успешно!");
                 }
                 catch (SqlException ol)
                 {

                     MessageBox.Show(ol.Message.ToString());
                 }

             }


            SqlConnection con = SearchCustomer.CreateConection();
             using (con)
             {
//  sp_insertOrderDetail
//@Product_id int=null,
//@Order_id int=null,
//@Quantity int=null,
//@Price money=null

                 SqlCommand mycommand = new SqlCommand("sp_insertOrderDetail", con);
                 mycommand.CommandType = CommandType.StoredProcedure;
                 mycommand.CommandText = "sp_insertOrderDetail";


                 //!!!!!!!!!!!!!
                 SqlParameter ProdID = new SqlParameter("@Product_id", SqlDbType.Int);
                 //if (txtCNo.Text != "")
                 //{
                     ProdID.Value = Convert.ToInt32(cbProduct.SelectedIndex);
                 //}
                 mycommand.Parameters.Add(ProdID);

                 SqlParameter OrderID = new SqlParameter("@Order_id", SqlDbType.Int);
                 if (txtOrderID.Text != "")
                 {
                     OrderID.Value = Convert.ToInt32(txtOrderID.Text);
                 }
                 mycommand.Parameters.Add(OrderID);

                 SqlParameter Qty = new SqlParameter("@Quantity", SqlDbType.Int);
                 if (txtQuantity.Text != "")
                 {
                     Qty.Value = Convert.ToInt32(txtQuantity.Text);
                 }
                 mycommand.Parameters.Add(Qty);


                 SqlParameter Price = new SqlParameter("@Price", SqlDbType.Int);
                 if (txtPrice.Text != "")
                 {
                     Price.Value = Convert.ToInt32(txtPrice.Text);
                 }
                 mycommand.Parameters.Add(Price);

                 

                 try
                 {
                     con.Open();
                     mycommand.ExecuteNonQuery();
                     MessageBox.Show("detajla беше добавена успешно!!!");
                 }
                 catch (SqlException ol)
                 {

                     MessageBox.Show(ol.Message.ToString());
                 }
             }
        }

        private void cbProduct_BindingContextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {

            qty = Convert.ToInt32(txtQuantity.Text);

            if (cbProduct.Text == "divan Ara")
            {
                price = 350;
                sum = qty * price;

            }
            else if (cbProduct.Text == "stol Miki")
            {
                price = 200;
                sum = qty * price;
            }
            else
            {
                price = 100;
                sum = qty * price;
            }
            txtPrice.Text = price.ToString();
            txtSum.Text = sum.ToString();
            txtQuantity.Text = qty.ToString();
        }
        

       


    }
}
