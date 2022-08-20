namespace Макет
{
    partial class Form18
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.accountingfortheissuanceinventorysBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.children_art_schoolDataSet = new Макет.Children_art_schoolDataSet();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.recordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofuseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startandendofusagetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condictionoftheequipmentafteruseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountingfortheissuanceinventorysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accounting_for_the_issuance_inventorysTableAdapter = new Макет.Children_art_schoolDataSetTableAdapters.Accounting_for_the_issuance_inventorysTableAdapter();
            this.cabinetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cabinetsTableAdapter = new Макет.Children_art_schoolDataSetTableAdapters.CabinetsTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.accountingfortheissuanceinventorysBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.children_art_schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingfortheissuanceinventorysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Учёт выдачи инвентаря";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(164, 239);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 42;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 239);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 23);
            this.button6.TabIndex = 41;
            this.button6.Text = "Поиск по id";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.accountingfortheissuanceinventorysBindingSource1;
            this.comboBox1.DisplayMember = "Date_of_use";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 379);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 24);
            this.comboBox1.TabIndex = 39;
            // 
            // accountingfortheissuanceinventorysBindingSource1
            // 
            this.accountingfortheissuanceinventorysBindingSource1.DataMember = "Accounting_for_the_issuance_inventorys";
            this.accountingfortheissuanceinventorysBindingSource1.DataSource = this.children_art_schoolDataSet;
            // 
            // children_art_schoolDataSet
            // 
            this.children_art_schoolDataSet.DataSetName = "Children_art_schoolDataSet";
            this.children_art_schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 327);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 23);
            this.button4.TabIndex = 36;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 35;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = " Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordIDDataGridViewTextBoxColumn,
            this.inventoryIDDataGridViewTextBoxColumn,
            this.clubIDDataGridViewTextBoxColumn,
            this.teacherIDDataGridViewTextBoxColumn,
            this.dateofuseDataGridViewTextBoxColumn,
            this.startandendofusagetimeDataGridViewTextBoxColumn,
            this.condictionoftheequipmentafteruseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.accountingfortheissuanceinventorysBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(746, 150);
            this.dataGridView1.TabIndex = 44;
            // 
            // recordIDDataGridViewTextBoxColumn
            // 
            this.recordIDDataGridViewTextBoxColumn.DataPropertyName = "RecordID";
            this.recordIDDataGridViewTextBoxColumn.HeaderText = "RecordID";
            this.recordIDDataGridViewTextBoxColumn.Name = "recordIDDataGridViewTextBoxColumn";
            this.recordIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inventoryIDDataGridViewTextBoxColumn
            // 
            this.inventoryIDDataGridViewTextBoxColumn.DataPropertyName = "Inventory_ID";
            this.inventoryIDDataGridViewTextBoxColumn.HeaderText = "Inventory_ID";
            this.inventoryIDDataGridViewTextBoxColumn.Name = "inventoryIDDataGridViewTextBoxColumn";
            // 
            // clubIDDataGridViewTextBoxColumn
            // 
            this.clubIDDataGridViewTextBoxColumn.DataPropertyName = "Club_ID";
            this.clubIDDataGridViewTextBoxColumn.HeaderText = "Club_ID";
            this.clubIDDataGridViewTextBoxColumn.Name = "clubIDDataGridViewTextBoxColumn";
            // 
            // teacherIDDataGridViewTextBoxColumn
            // 
            this.teacherIDDataGridViewTextBoxColumn.DataPropertyName = "Teacher_ID";
            this.teacherIDDataGridViewTextBoxColumn.HeaderText = "Teacher_ID";
            this.teacherIDDataGridViewTextBoxColumn.Name = "teacherIDDataGridViewTextBoxColumn";
            // 
            // dateofuseDataGridViewTextBoxColumn
            // 
            this.dateofuseDataGridViewTextBoxColumn.DataPropertyName = "Date_of_use";
            this.dateofuseDataGridViewTextBoxColumn.HeaderText = "Date_of_use";
            this.dateofuseDataGridViewTextBoxColumn.Name = "dateofuseDataGridViewTextBoxColumn";
            // 
            // startandendofusagetimeDataGridViewTextBoxColumn
            // 
            this.startandendofusagetimeDataGridViewTextBoxColumn.DataPropertyName = "Start_and_end_of_usage_time";
            this.startandendofusagetimeDataGridViewTextBoxColumn.HeaderText = "Start_and_end_of_usage_time";
            this.startandendofusagetimeDataGridViewTextBoxColumn.Name = "startandendofusagetimeDataGridViewTextBoxColumn";
            // 
            // condictionoftheequipmentafteruseDataGridViewTextBoxColumn
            // 
            this.condictionoftheequipmentafteruseDataGridViewTextBoxColumn.DataPropertyName = "Condiction_of_the_equipment_after_use";
            this.condictionoftheequipmentafteruseDataGridViewTextBoxColumn.HeaderText = "Condiction_of_the_equipment_after_use";
            this.condictionoftheequipmentafteruseDataGridViewTextBoxColumn.Name = "condictionoftheequipmentafteruseDataGridViewTextBoxColumn";
            // 
            // accountingfortheissuanceinventorysBindingSource
            // 
            this.accountingfortheissuanceinventorysBindingSource.DataMember = "Accounting_for_the_issuance_inventorys";
            this.accountingfortheissuanceinventorysBindingSource.DataSource = this.children_art_schoolDataSet;
            // 
            // accounting_for_the_issuance_inventorysTableAdapter
            // 
            this.accounting_for_the_issuance_inventorysTableAdapter.ClearBeforeFill = true;
            // 
            // cabinetsBindingSource
            // 
            this.cabinetsBindingSource.DataMember = "Cabinets";
            this.cabinetsBindingSource.DataSource = this.children_art_schoolDataSet;
            // 
            // cabinetsTableAdapter
            // 
            this.cabinetsTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(676, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 50);
            this.button2.TabIndex = 45;
            this.button2.Text = "Форма Сотрудников";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Макет.Properties.Resources._139324140926;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Name = "Form18";
            this.Text = "Form18";
            this.Load += new System.EventHandler(this.Form18_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountingfortheissuanceinventorysBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.children_art_schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingfortheissuanceinventorysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinetsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Children_art_schoolDataSet children_art_schoolDataSet;
        private System.Windows.Forms.BindingSource accountingfortheissuanceinventorysBindingSource;
        private Children_art_schoolDataSetTableAdapters.Accounting_for_the_issuance_inventorysTableAdapter accounting_for_the_issuance_inventorysTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofuseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startandendofusagetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condictionoftheequipmentafteruseDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cabinetsBindingSource;
        private Children_art_schoolDataSetTableAdapters.CabinetsTableAdapter cabinetsTableAdapter;
        private System.Windows.Forms.BindingSource accountingfortheissuanceinventorysBindingSource1;
        private System.Windows.Forms.Button button2;
    }
}