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

namespace Data_Access_Layer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string connString= @"Data Source=DESKTOP-669LIT0\SQLEXPRESS;Initial Catalog=infobeans;Integrated Security=True";
            SqlConnection sql = new SqlConnection(connString);
            sql.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * FROM employee1",sql);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            SqlDataAdapter da1 = new SqlDataAdapter("Select * FROM dept", sql);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);

            comboBox1.DisplayMember = "deptname";
            comboBox1.ValueMember = "deptno";
            comboBox1.DataSource = ds.Tables[0];
            
            sql.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
;