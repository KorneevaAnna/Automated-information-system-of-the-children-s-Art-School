namespace Макет
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cabinetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numperDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabinetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.children_art_schoolDataSet = new Макет.Children_art_schoolDataSet();
            this.cabinetsTableAdapter = new Макет.Children_art_schoolDataSetTableAdapters.CabinetsTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cabinetsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.children_art_schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cabinetIDDataGridViewTextBoxColumn,
            this.appointmentDataGridViewTextBoxColumn,
            this.numperDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cabinetsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(756, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // cabinetIDDataGridViewTextBoxColumn
            // 
            this.cabinetIDDataGridViewTextBoxColumn.DataPropertyName = "Cabinet_ID";
            this.cabinetIDDataGridViewTextBoxColumn.HeaderText = "Cabinet_ID";
            this.cabinetIDDataGridViewTextBoxColumn.Name = "cabinetIDDataGridViewTextBoxColumn";
            this.cabinetIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appointmentDataGridViewTextBoxColumn
            // 
            this.appointmentDataGridViewTextBoxColumn.DataPropertyName = "Appointment";
            this.appointmentDataGridViewTextBoxColumn.HeaderText = "Appointment";
            this.appointmentDataGridViewTextBoxColumn.Name = "appointmentDataGridViewTextBoxColumn";
            // 
            // numperDataGridViewTextBoxColumn
            // 
            this.numperDataGridViewTextBoxColumn.DataPropertyName = "Numper";
            this.numperDataGridViewTextBoxColumn.HeaderText = "Numper";
            this.numperDataGridViewTextBoxColumn.Name = "numperDataGridViewTextBoxColumn";
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Capacity";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // cabinetsBindingSource
            // 
            this.cabinetsBindingSource.DataMember = "Cabinets";
            this.cabinetsBindingSource.DataSource = this.children_art_schoolDataSet;
            // 
            // children_art_schoolDataSet
            // 
            this.children_art_schoolDataSet.DataSetName = "Children_art_schoolDataSet";
            this.children_art_schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cabinetsTableAdapter
            // 
            this.cabinetsTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(73, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Кабинеты";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1033, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = " Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(998, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 76);
            this.button2.TabIndex = 4;
            this.button2.Text = "Переход к таблице  \"Ученики\"";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1033, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1033, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.cabinetsBindingSource1;
            this.comboBox1.DisplayMember = "Numper";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1001, 243);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "Numper";
            // 
            // cabinetsBindingSource1
            // 
            this.cabinetsBindingSource1.DataMember = "Cabinets";
            this.cabinetsBindingSource1.DataSource = this.children_art_schoolDataSet;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 379);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Поиск по id";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(160, 379);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 22);
            this.textBox3.TabIndex = 12;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1514, 222);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "Вернуться на форму Администрации";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(349, 379);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(258, 23);
            this.button8.TabIndex = 14;
            this.button8.Text = "Форма Администрации";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Макет.Properties.Resources._1111;
            this.ClientSize = new System.Drawing.Size(1153, 450);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.children_art_schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Children_art_schoolDataSet children_art_schoolDataSet;
        private System.Windows.Forms.BindingSource cabinetsBindingSource;
        private Children_art_schoolDataSetTableAdapters.CabinetsTableAdapter cabinetsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabinetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numperDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource cabinetsBindingSource1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}