using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_csdl
{
    public partial class receipt : Form
    {
        string receiptID;
        BindingList<subOrder> customer_orders;
        string orderID;
        MySqlConnection conn;
        public receipt(BindingList<subOrder> customer_orders, string orderID, string receiptID, MySqlConnection conn)
        {
            this.conn = conn;
            this.receiptID = receiptID;
            this.customer_orders = customer_orders;
            this.orderID = orderID;
            InitializeComponent();
            this.dataGridView1.DataSource = customer_orders;
            try
            {
                int subtotal = (int)((new MySqlCommand("select Payment(\"" + orderID + "\")", conn)).ExecuteScalar());
                int discount = (int)((new MySqlCommand("select Discount(\"" + orderID + "\")", conn)).ExecuteScalar());
                int total = (int)((new MySqlCommand("select Payment_final(\"" + orderID + "\")", conn)).ExecuteScalar());
                this.subTotal.Text += (" " + subtotal.ToString() + " VND");
                this.Discount.Text += (" " + discount.ToString() + "%");
                this.Total.Text += (" " + total.ToString() + " VND");
            }
            catch(MySqlException except)
            {
                MessageBox.Show(except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///call pay_up procedure
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "insert_receipt";
                comm.Parameters.AddWithValue("orderID", orderID);
                comm.Parameters.AddWithValue("receiptID", receiptID);
                comm.ExecuteNonQuery();
                MessageBox.Show("Thanh toán thành công!");
                this.Close();
            }
            catch(MySqlException except)
            {
                MessageBox.Show(except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
    }
}
