using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;

namespace Макет
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "children_art_schoolDataSet.Club". При необходимости она может быть перемещена или удалена.
            this.clubTableAdapter.Fill(this.children_art_schoolDataSet.Club);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clubTableAdapter.Update(children_art_schoolDataSet);
            this.Validate();
            this.clubBindingSource.EndEdit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clubTableAdapter.Update(children_art_schoolDataSet);
            this.Validate();
            this.clubBindingSource.EndEdit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection("Data Source=ANNA;Initial Catalog=Children_art_school;Integrated Security=True");
            sqlConn.Open();


            SqlCommand sqlCom = new SqlCommand("SELECT * From dbo.Club WHERE Club_ID =" + textBox3.Text.ToString() + "", sqlConn);
            SqlDataReader dr = sqlCom.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form14 frm = new Form14();
            frm.Show();
        }
    }
}
