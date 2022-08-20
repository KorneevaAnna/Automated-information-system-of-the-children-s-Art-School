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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "children_art_schoolDataSet.Accounting_for_the_issuance_inventorys". При необходимости она может быть перемещена или удалена.
            this.accounting_for_the_issuance_inventorysTableAdapter.Fill(this.children_art_schoolDataSet.Accounting_for_the_issuance_inventorys);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            accounting_for_the_issuance_inventorysTableAdapter.Update(children_art_schoolDataSet);
            this.Validate();
            this.accountingfortheissuanceinventorysBindingSource.EndEdit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 frm = new Form10();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            accounting_for_the_issuance_inventorysTableAdapter.Update(children_art_schoolDataSet);
            this.Validate();
            this.accountingfortheissuanceinventorysBindingSource.EndEdit();
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


            SqlCommand sqlCom = new SqlCommand("SELECT * From dbo.Accounting_for_the_issuance_inventorys WHERE RecordID =" + textBox3.Text.ToString() + "", sqlConn);
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
