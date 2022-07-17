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
    
    public partial class order : Form
    {
        private BindingList<subOrder> customer_orders;
        bool order_exist;
        MySqlConnection conn;
        //orderID
        string orderID;
        //receiptID
        string receiptID;
            //cashierID
        const string cashierID = "D-m7l_8Mhv";
        //shipperID
        const string shipperID = "strE-_LrnD";
        //ship fee
        const int fee = 15000;

        public order(MySqlConnection conn)
        {
            order_exist = false;
            orderID = Guid.NewGuid().ToString().Substring(0,10);
            receiptID = Guid.NewGuid().ToString().Substring(0, 10);
            customer_orders = new BindingList<subOrder>();
            this.conn = conn;
            InitializeComponent();
            this.dataGridView1.DataSource = customer_orders;
        }

        private void order_Load(object sender, EventArgs e)
        {
            this.address_box.Enabled = false;
            this.cusName_box.Enabled = false;
            this.phone_box.Enabled = false;
            this.shipTime_box.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.takeAwayBox.Checked)
            {
                this.address_box.Enabled = true;
                this.cusName_box.Enabled = true;
                this.phone_box.Enabled = true;
                this.shipTime_box.Enabled = true;
            }
            else
            {
                this.address_box.Enabled = false;
                this.cusName_box.Enabled = false;
                this.phone_box.Enabled = false;
                this.shipTime_box.Enabled = false;
            }
        }

        private void checkDiscount_Click(object sender, EventArgs e)
        {
            string info="";
            MySqlDataReader reader = (new MySqlCommand("select * from discount_event", conn)).ExecuteReader();
            while (reader.Read())
            {
                info += (reader["ID"] + " " + reader["name"] + " " +reader["start_date"]+" "+reader["end_date"]+"\n\n");
            }
            reader.Close();
            MessageBox.Show(info);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string drinkName = this.drinkName.Text;
            MySqlDataReader reader = (new MySqlCommand("select * from drink where name =\""+drinkName+"\" limit 1", conn)).ExecuteReader();
            if (!reader.Read())
            {
                MessageBox.Show("Không tìm thấy đồ uống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reader.Close();
                return;
            }
            int amount;
            if (!Int32.TryParse(this.drinkAmount.Text,out amount))
            {
                MessageBox.Show("Số lượng sai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reader.Close();
                return;
            }
            bool exist=false;
            for (int i = 0; i < customer_orders.Count; i++)
            {
                if (customer_orders[i].drinkID == reader["ID"].ToString())
                {
                    customer_orders[i].amount = customer_orders[i].amount+amount;
                    customer_orders.ResetBindings();
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                customer_orders.Add(new subOrder(reader["ID"].ToString(), reader["name"].ToString(), Int32.Parse(reader["price"].ToString()), amount));
            }
            reader.Close();
        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            if (customer_orders.Count < 1)
            {
                MessageBox.Show("Đơn hàng không được trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //procedure's parameter
            MySqlParameter[] pms = new MySqlParameter[11];
            pms[0] = new MySqlParameter("ord_id", orderID);
            pms[1] = new MySqlParameter("ord_cashierID", cashierID);
            pms[2] = new MySqlParameter("ord_discountID", this.discountID_box.Text);
            int takeAway = this.takeAwayBox.Checked ? 1 : 0;
            pms[3] = new MySqlParameter("ord_takeAwayFlag", takeAway);
            pms[4] = new MySqlParameter("ord_shipperID", shipperID);
            pms[5] = new MySqlParameter("ord_shipAddress", this.address_box.Text);
            pms[6] = new MySqlParameter("ord_customerName", this.cusName_box.Text);
            pms[7] = new MySqlParameter("ord_phone", this.phone_box.Text);
            pms[8] = new MySqlParameter("ord_fee", fee);
            pms[9] = new MySqlParameter("ord_time", this.shipTime_box.Value);
            pms[10] = new MySqlParameter("ord_memberID", this.memberID_box.Text);

            //procedure command
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(pms);
            try
            {
                new MySqlCommand("delete from order_include where orderID=\"" + orderID + "\"",conn).ExecuteNonQuery();
                MySqlDataReader reader = (new MySqlCommand("select * from orders where ID=\"" + orderID + "\"", conn)).ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    //update
                    command.CommandText = "update_order";
                }
                else
                {
                    reader.Close();
                    //insert
                    command.CommandText = "insert_order";
                }
                command.ExecuteNonQuery();
                for (int i = 0; i < customer_orders.Count; i++)
                {
                    new MySqlCommand("insert into order_include values (\"" + orderID + "\",\"" + customer_orders[i].drinkID + "\"," + customer_orders[i].amount.ToString() + ")",conn).ExecuteNonQuery();
                }
                order_exist = true;
                MessageBox.Show("Đặt hàng thành công!!");
            }
            catch(MySqlException except)
            {
                MessageBox.Show(except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void deleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                new MySqlCommand("call delete_order (\""+orderID+"\")", conn).ExecuteNonQuery();
                order_exist = false;
                MessageBox.Show("Xóa đơn thành công");
            }
            catch(MySqlException except)
            {
                MessageBox.Show(except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void payUpButton_Click(object sender, EventArgs e)
        {
            if (order_exist)
            {
                receipt rec = new receipt(customer_orders, orderID, receiptID, conn);
                rec.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hãy đặt hàng trước khi thanh toán", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    public class subOrder
    {
        public string drinkID { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int amount { get; set; }
        public subOrder(string drinkID,string name, int price, int amount)
        {
            this.drinkID = drinkID;
            this.name = name;
            this.price = price;
            this.amount = amount;
        }
    }
}
