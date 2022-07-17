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
    public partial class searchOrder : Form
    {
        MySqlConnection conn;
        //shipperID
        const string shipperID = "strE-_LrnD";
        //ship fee
        const int fee = 15000;
        public searchOrder(MySqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand comm = new MySqlCommand("unpaid_order_by_name", conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("name", this.custName.Text);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(comm);
                da.Fill(dt);
                this.dataGridView1.DataSource = dt;
            }
            catch (MySqlException except)
            {
                MessageBox.Show(except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellBeginEdit(object sender,
    DataGridViewCellCancelEventArgs e)
        {
            string header = this.dataGridView1.Columns[e.ColumnIndex].HeaderText;
            if (header == "ID" || header == "cashierID" || header == "fee" || header == "shipperID")
            {
                MessageBox.Show("Không được thay đổi những mục này!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateOrdersButton_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = this.dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                try
                {
                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        //procedure's parameter
                        MySqlParameter[] pms = new MySqlParameter[11];
                        pms[0] = new MySqlParameter("ord_id", dataGridView1.SelectedRows[i].Cells[0].Value);
                        pms[1] = new MySqlParameter("ord_cashierID", dataGridView1.SelectedRows[i].Cells[1].Value);
                        pms[2] = new MySqlParameter("ord_discountID", dataGridView1.SelectedRows[i].Cells[2].Value);
                        pms[3] = new MySqlParameter("ord_takeAwayFlag", dataGridView1.SelectedRows[i].Cells[3].Value);
                        pms[4] = new MySqlParameter("ord_shipperID", shipperID);
                        pms[5] = new MySqlParameter("ord_shipAddress", dataGridView1.SelectedRows[i].Cells[5].Value);
                        pms[6] = new MySqlParameter("ord_customerName", dataGridView1.SelectedRows[i].Cells[6].Value);
                        pms[7] = new MySqlParameter("ord_phone", dataGridView1.SelectedRows[i].Cells[7].Value);
                        pms[8] = new MySqlParameter("ord_fee", fee);
                        pms[9] = new MySqlParameter("ord_time", dataGridView1.SelectedRows[i].Cells[9].Value);
                        pms[10] = new MySqlParameter("ord_memberID", dataGridView1.SelectedRows[i].Cells[10].Value);

                        //procedure command
                        MySqlCommand command = new MySqlCommand();
                        command.Connection = conn;
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddRange(pms);
                        command.CommandText = "update_order";
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Cập nhật thành công");
                }
                catch(MySqlException except)
                {
                    MessageBox.Show(except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.searchButton.PerformClick();
                
            }
        }
        private void DataGridView1_UserDeletingRow(object sender,
    DataGridViewRowCancelEventArgs e)
        {
            try
            {
                string deletedOrderID = e.Row.Cells[0].Value.ToString();
               
                new MySqlCommand("call delete_order (\"" + deletedOrderID + "\")", conn).ExecuteNonQuery();

            }
            catch(MySqlException except)
            {
                MessageBox.Show(except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }

}
