namespace CRUD_Operation___Nimap_
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new CRUD_Operation___Nimap_.Database1DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.p_InfoTableAdapter = new CRUD_Operation___Nimap_.Database1DataSetTableAdapters.P_InfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProductId : -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "ProductName : -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "CategoryId : -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "CategoryName : -";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox1.Location = new System.Drawing.Point(224, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox2.Location = new System.Drawing.Point(224, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(327, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox3.Location = new System.Drawing.Point(224, 136);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(327, 22);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox4.Location = new System.Drawing.Point(224, 186);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(327, 22);
            this.textBox4.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.categoryIdDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(547, 344);
            this.dataGridView1.TabIndex = 8;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            this.categoryIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            this.categoryNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // pInfoBindingSource
            // 
            this.pInfoBindingSource.DataMember = "P_Info";
            this.pInfoBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(128, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(251, 247);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 38);
            this.button3.TabIndex = 11;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(385, 247);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 38);
            this.button4.TabIndex = 12;
            this.button4.Text = "CLEAR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(510, 247);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 38);
            this.button5.TabIndex = 13;
            this.button5.Text = "RESET";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // p_InfoTableAdapter
            // 
            this.p_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(597, 699);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource pInfoBindingSource;
        private Database1DataSetTableAdapters.P_InfoTableAdapter p_InfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
    }
}

