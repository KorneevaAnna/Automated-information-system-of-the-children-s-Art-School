using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Макет
{
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                DataRow row;
                row = this.children_art_schoolDataSet.Inventory.NewRow();
                row["Appellation"] = textBox6.Text;
                row["Application_area"] = textBox7.Text;
                row["Age_limit"] = textBox8.Text;
                row["Shelf_life"] = textBox9.Text;
                this.children_art_schoolDataSet.Inventory.Rows.Add(row);
                this.inventoryTableAdapter.Update(this.children_art_schoolDataSet.Inventory);
                Form ifrm = new Form19();
                ifrm.Show();
                this.Hide();
            
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "children_art_schoolDataSet.Inventory". При необходимости она может быть перемещена или удалена.
            this.inventoryTableAdapter.Fill(this.children_art_schoolDataSet.Inventory);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form14 frm = new Form14();
            frm.Show();
        }
    }
}
