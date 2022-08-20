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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form14 frm = new Form14();
            frm.Show();
        }

        //"Proveder = sqlconnection;

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection( "Data Source=ANNA;Initial Catalog=Children_art_school;Integrated Security=True");
            sqlConn.Open();
            SqlCommand sqlCom = new SqlCommand("select w.Surname, w.Name, w.Patronymic, w.Date_of_birth, s.Specialty from WORKERS w join Specialization_of_employees s on s.Sprcialisation_ID = w.Specialization_ID order by w.Date_of_birth", sqlConn);
            SqlDataReader dr = sqlCom.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            
        }
    }
}
