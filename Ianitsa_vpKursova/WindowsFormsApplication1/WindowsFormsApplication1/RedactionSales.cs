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
    public partial class RedactionSales : Form
    {
        public RedactionSales()
        {
            InitializeComponent();
        }

        Customer c;
        Orders ord;
        public RedactionSales(Customer cust,Orders o)
        {
            InitializeComponent();
            this.c = cust;
            this.ord = o;
        }

        private void RedactionSales_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Сигурни ли сте,че искате да затворите?", "Изход?", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void RedactionSales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kursovaSQLDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.kursovaSQLDataSet.Product);

            txtCNo.Text = c.Cust_Id;
            txtCName.Text = c.Name;
            txtCLName.Text = c.LName;
            //txtCAddress.Text = c.Address;
            txtCCity.Text = c.City;
            txtCCountry.Text = c.Country;
            cbProdN.Text = ord.Product;
            txtOrderID.Text = ord.OrderNo;
            txtPrice.Text = ord.Price;
            txtQuantity.Text = ord.Quantity;
            dateTimePicker1.Text = ord.OrderDate;
            dateTimePicker2.Text = ord.SheepedDate;

        }

        private void btnUpdateS_Click(object sender, EventArgs e)
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
             SqlConnection conn = SearchCustomer.CreateConection();

             using (connection)
             {
                 //да проверя дали работи!!!!!!!!!!!!

                 SqlCommand mycommand = new SqlCommand("sp_updateProduct", conn);
                 mycommand.CommandType = CommandType.StoredProcedure;
                 mycommand.CommandText = "sp_updateProduct";

                 //SqlParameter CustomerID = new SqlParameter("@C_id", SqlDbType.Int);
                 //if (txtCNo.Text != "")
                 //{
                 //    CustomerID.Value = Convert.ToInt32(txtCNo.Text);
                 //}
                 //mycommand.Parameters.Add(CustomerID);

                 //SqlParameter Name = new SqlParameter("@FName", SqlDbType.NVarChar);
                 //if (txtCName.Text != "")
                 //{
                 //    Name.Value = txtCName.Text;
                 //}
                 //mycommand.Parameters.Add(Name);



             }



        }
        private void btnDelS_Click(object sender, EventArgs e)
        {
            SqlConnection connection = SearchCustomer.CreateConection();
            //КАК ДА НАПРАВЯ ДЕЛ В НЯКОЛКО ТАБЛИЦИ???????????

            using (connection)
            {
                //da PROBVAM DALI RABOTI!!!!!

                SqlCommand mycommand = new SqlCommand("sp_del_Customer", connection);
                mycommand.CommandType = CommandType.StoredProcedure;
                mycommand.CommandText = "sp_del_Customer";

                SqlParameter CustomerID = new SqlParameter("@C_id", SqlDbType.Int);
                if (txtCNo.Text != "")
                {
                    CustomerID.Value = Convert.ToInt32(txtCNo.Text);
                }
                mycommand.Parameters.Add(CustomerID);



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

                //TODO !!!!!!!!!!



            }
        }
    }
}
