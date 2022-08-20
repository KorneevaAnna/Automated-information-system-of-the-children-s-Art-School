namespace Макет
{
    partial class Form6
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
            this.clubIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameclubDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabinetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofstudentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationoftheclassesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agelimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.children_art_schoolDataSet = new Макет.Children_art_schoolDataSet();
            this.clubTableAdapter = new Макет.Children_art_schoolDataSetTableAdapters.ClubTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clubBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.children_art_schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clubIDDataGridViewTextBoxColumn,
            this.nameclubDataGridViewTextBoxColumn,
            this.teacherIDDataGridViewTextBoxColumn,
            this.cabinetIDDataGridViewTextBoxColumn,
            this.numberofstudentsDataGridViewTextBoxColumn,
            this.durationoftheclassesDataGridViewTextBoxColumn,
            this.agelimitDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clubBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(996, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // clubIDDataGridViewTextBoxColumn
            // 
            this.clubIDDataGridViewTextBoxColumn.DataPropertyName = "Club_ID";
            this.clubIDDataGridViewTextBoxColumn.HeaderText = "Club_ID";
            this.clubIDDataGridViewTextBoxColumn.Name = "clubIDDataGridViewTextBoxColumn";
            this.clubIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameclubDataGridViewTextBoxColumn
            // 
            this.nameclubDataGridViewTextBoxColumn.DataPropertyName = "Name_club";
            this.nameclubDataGridViewTextBoxColumn.HeaderText = "Name_club";
            this.nameclubDataGridViewTextBoxColumn.Name = "nameclubDataGridViewTextBoxColumn";
            // 
            // teacherIDDataGridViewTextBoxColumn
            // 
            this.teacherIDDataGridViewTextBoxColumn.DataPropertyName = "Teacher_ID";
            this.teacherIDDataGridViewTextBoxColumn.HeaderText = "Teacher_ID";
            this.teacherIDDataGridViewTextBoxColumn.Name = "teacherIDDataGridViewTextBoxColumn";
            // 
            // cabinetIDDataGridViewTextBoxColumn
            // 
            this.cabinetIDDataGridViewTextBoxColumn.DataPropertyName = "Cabinet_ID";
            this.cabinetIDDataGridViewTextBoxColumn.HeaderText = "Cabinet_ID";
            this.cabinetIDDataGridViewTextBoxColumn.Name = "cabinetIDDataGridViewTextBoxColumn";
            // 
            // numberofstudentsDataGridViewTextBoxColumn
            // 
            this.numberofstudentsDataGridViewTextBoxColumn.DataPropertyName = "Number_of_students";
            this.numberofstudentsDataGridViewTextBoxColumn.HeaderText = "Number_of_students";
            this.numberofstudentsDataGridViewTextBoxColumn.Name = "numberofstudentsDataGridViewTextBoxColumn";
            // 
            // durationoftheclassesDataGridViewTextBoxColumn
            // 
            this.durationoftheclassesDataGridViewTextBoxColumn.DataPropertyName = "Duration_of_the_classes";
            this.durationoftheclassesDataGridViewTextBoxColumn.HeaderText = "Duration_of_the_classes";
            this.durationoftheclassesDataGridViewTextBoxColumn.Name = "durationoftheclassesDataGridViewTextBoxColumn";
            // 
            // agelimitDataGridViewTextBoxColumn
            // 
            this.agelimitDataGridViewTextBoxColumn.DataPropertyName = "Age_limit";
            this.agelimitDataGridViewTextBoxColumn.HeaderText = "Age_limit";
            this.agelimitDataGridViewTextBoxColumn.Name = "agelimitDataGridViewTextBoxColumn";
            // 
            // clubBindingSource
            // 
            this.clubBindingSource.DataMember = "Club";
            this.clubBindingSource.DataSource = this.children_art_schoolDataSet;
            // 
            // children_art_schoolDataSet
            // 
            this.children_art_schoolDataSet.DataSetName = "Children_art_schoolDataSet";
            this.children_art_schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clubTableAdapter
            // 
            this.clubTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(901, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = " Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Кружки";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(855, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 83);
            this.button2.TabIndex = 8;
            this.button2.Text = "Переход к таблице  \"Кружок - инвентарь\"";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 307);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.clubBindingSource1;
            this.comboBox1.DisplayMember = "Name_club";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 355);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 24);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "Name_club";
            // 
            // clubBindingSource1
            // 
            this.clubBindingSource1.DataMember = "Club";
            this.clubBindingSource1.DataSource = this.children_art_schoolDataSet;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 224);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 23);
            this.button6.TabIndex = 20;
            this.button6.Text = "Поиск по id";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(139, 225);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 22);
            this.textBox3.TabIndex = 21;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(172, 281);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(184, 23);
            this.button7.TabIndex = 22;
            this.button7.Text = "Форма Администрации";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Макет.Properties.Resources.йй;
            this.ClientSize = new System.Drawing.Size(1036, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.children_art_schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Children_art_schoolDataSet children_art_schoolDataSet;
        private System.Windows.Forms.BindingSource clubBindingSource;
        private Children_art_schoolDataSetTableAdapters.ClubTableAdapter clubTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameclubDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabinetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofstudentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationoftheclassesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agelimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource clubBindingSource1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button7;
    }
}