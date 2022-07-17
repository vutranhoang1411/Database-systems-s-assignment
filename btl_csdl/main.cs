using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace btl_csdl
{
    public partial class main : Form
    {
        MySqlConnection conn;
        const string server = "localhost";
        const string database = "btl_csdl2";
        const string username = "vutranhoang";
        const string password = "Hoang2002";
        string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID="
            + username + ";" + "PASSWORD=" + password + ";";
        public main()
        {
            InitializeComponent();
            this.conn = new MySqlConnection(constring);
            this.conn.Open();
        }

        private void order_button_Click(object sender, EventArgs e)
        {
            order new_order = new order(this.conn);
            new_order.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchOrder search = new searchOrder(conn);
            search.ShowDialog();
        }
    }
}
