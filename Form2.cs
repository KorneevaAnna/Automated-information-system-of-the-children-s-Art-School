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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string llogin, ppassword;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "children_art_schoolDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.children_art_schoolDataSet.Workers);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (text_Name.Text == "Сотрудник" && text_Password.Text == "2")
            {
                Form f = new Form13();
                f.Show();
                this.Hide();
            }
            else if (text_Name.Text == "Администрация" && text_Password.Text == "1")
            {
                Form f = new Form14();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка");

            }
        }
        
    }
}
