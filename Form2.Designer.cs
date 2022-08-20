namespace Макет
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.children_art_schoolDataSet = new Макет.Children_art_schoolDataSet();
            this.workersTableAdapter = new Макет.Children_art_schoolDataSetTableAdapters.WorkersTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.text_Name = new System.Windows.Forms.TextBox();
            this.text_Password = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.children_art_schoolDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "Workers";
            this.workersBindingSource.DataSource = this.children_art_schoolDataSet;
            // 
            // children_art_schoolDataSet
            // 
            this.children_art_schoolDataSet.DataSetName = "Children_art_schoolDataSet";
            this.children_art_schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ввод";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // text_Name
            // 
            this.text_Name.Location = new System.Drawing.Point(391, 152);
            this.text_Name.Name = "text_Name";
            this.text_Name.Size = new System.Drawing.Size(100, 22);
            this.text_Name.TabIndex = 1;
            // 
            // text_Password
            // 
            this.text_Password.Location = new System.Drawing.Point(391, 180);
            this.text_Password.Name = "text_Password";
            this.text_Password.PasswordChar = '*';
            this.text_Password.Size = new System.Drawing.Size(100, 22);
            this.text_Password.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(522, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Имя пользователя: Администрация или Сотрудник?";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(250, 180);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Введите пароль:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(261, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(111, 22);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Вход в систему";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Макет.Properties.Resources.Screen_Shot_2016_09_20_at_4_10_59_PM_1_;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.text_Password);
            this.Controls.Add(this.text_Name);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.children_art_schoolDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Children_art_schoolDataSet children_art_schoolDataSet;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private Children_art_schoolDataSetTableAdapters.WorkersTableAdapter workersTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_Name;
        private System.Windows.Forms.TextBox text_Password;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}