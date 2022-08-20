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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "children_art_schoolDataSet.Specialization_of_employees". При необходимости она может быть перемещена или удалена.
            this.specialization_of_employeesTableAdapter.Fill(this.children_art_schoolDataSet.Specialization_of_employees);

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            specialization_of_employeesTableAdapter.Update(children_art_schoolDataSet);
            this.Validate();
            this.specializationofemployeesBindingSource.EndEdit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form12 frm = new Form12();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            specialization_of_employeesTableAdapter.Update(children_art_schoolDataSet);
            this.Validate();
            this.specializationofemployeesBindingSource.EndEdit();
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


            SqlCommand sqlCom = new SqlCommand("SELECT * From dbo.Specialization_of_employees WHERE Sprcialisation_ID =" + textBox3.Text.ToString() + "", sqlConn);
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

