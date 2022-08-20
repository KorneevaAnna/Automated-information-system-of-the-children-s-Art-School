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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "children_art_schoolDataSet.list_of_children_in_the_clubs". При необходимости она может быть перемещена или удалена.
            this.list_of_children_in_the_clubsTableAdapter.Fill(this.children_art_schoolDataSet.list_of_children_in_the_clubs);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            list_of_children_in_the_clubsTableAdapter.Update(children_art_schoolDataSet);
            this.Validate();
            this.listofchildrenintheclubsBindingSource.EndEdit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 frm = new Form11();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list_of_children_in_the_clubsTableAdapter.Update(children_art_schoolDataSet);
            this.Validate();
            this.listofchildrenintheclubsBindingSource.EndEdit();
        }

        private void button4_Click(object sender, EventArgs e)
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


            SqlCommand sqlCom = new SqlCommand("SELECT * From dbo.list_of_children_in_the_clubs WHERE RecordID =" + textBox3.Text.ToString() + "", sqlConn);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
