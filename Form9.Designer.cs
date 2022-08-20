namespace Макет
{
    partial class Form9
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
            this.recordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofuseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startandendofusagetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condictionoftheequipmentafteruseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountingfortheissuanceinventorysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.children_art_schoolDataSet = new Макет.Children_art_schoolDataSet();
            this.accounting_for_the_issuance_inventorysTableAdapter = new Макет.Children_art_schoolDataSetTableAdapters.Accounting_for_the_issuance_inventorysTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.accountingfortheissuanceinventorysBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingfortheissuanceinventorysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.children_art_schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingfortheissuanceinventorysBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(987, 150);
            this.dataGridView1.TabIndex = 0;
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
            // children_art_schoolDataSet
            // 
            this.children_art_schoolDataSet.DataSetName = "Children_art_schoolDataSet";
            this.children_art_schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accounting_for_the_issuance_inventorysTableAdapter
            // 
            this.accounting_for_the_issuance_inventorysTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Учёт выдачи инвентаря";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(893, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = " Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(893, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 78);
            this.button2.TabIndex = 12;
            this.button2.Text = "Переход к таблице  \"Список детей в кружках\"";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 313);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.accountingfortheissuanceinventorysBindingSource1;
            this.comboBox1.DisplayMember = "Condiction_of_the_equipment_after_use";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 394);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 24);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.ValueMember = "Description";
            // 
            // accountingfortheissuanceinventorysBindingSource1
            // 
            this.accountingfortheissuanceinventorysBindingSource1.DataMember = "Accounting_for_the_issuance_inventorys";
            this.accountingfortheissuanceinventorysBindingSource1.DataSource = this.children_art_schoolDataSet;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 225);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 23);
            this.button6.TabIndex = 32;
            this.button6.Text = "Поиск по id";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(164, 225);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 33;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(24, 354);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(236, 23);
            this.button7.TabIndex = 34;
            this.button7.Text = "Форма Администрации";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Макет.Properties.Resources.orig;
            this.ClientSize = new System.Drawing.Size(1048, 450);
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
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingfortheissuanceinventorysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.children_art_schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingfortheissuanceinventorysBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource accountingfortheissuanceinventorysBindingSource1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button7;
    }
}