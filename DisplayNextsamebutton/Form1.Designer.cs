namespace DisplayNextsamebutton
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
            this.employeeTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.adonetDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adonetDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeGrid = new System.Windows.Forms.DataGridView();
            this.btn_display = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_populate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.dataSet1 = new DisplayNextsamebutton.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.employeeTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adonetDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adonetDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeTableBindingSource1
            // 
            this.employeeTableBindingSource1.DataMember = "EmployeeTable";
            this.employeeTableBindingSource1.DataSource = this.adonetDataSetBindingSource;
            // 
            // employeeTableBindingSource
            // 
            this.employeeTableBindingSource.DataMember = "EmployeeTable";
            this.employeeTableBindingSource.DataSource = this.adonetDataSetBindingSource1;
            // 
            // EmployeeGrid
            // 
            this.EmployeeGrid.AutoGenerateColumns = false;
            this.EmployeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGrid.DataSource = this.dataSet1BindingSource1;
            this.EmployeeGrid.Location = new System.Drawing.Point(529, 268);
            this.EmployeeGrid.Name = "EmployeeGrid";
            this.EmployeeGrid.Size = new System.Drawing.Size(240, 150);
            this.EmployeeGrid.TabIndex = 21;
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(407, 207);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(75, 23);
            this.btn_display.TabIndex = 19;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(252, 207);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 18;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // btn_populate
            // 
            this.btn_populate.Location = new System.Drawing.Point(546, 207);
            this.btn_populate.Name = "btn_populate";
            this.btn_populate.Size = new System.Drawing.Size(75, 23);
            this.btn_populate.TabIndex = 20;
            this.btn_populate.Text = "Populate";
            this.btn_populate.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.dataSet1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(363, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(118, 127);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 13;
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(118, 185);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(100, 20);
            this.txt_salary.TabIndex = 12;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(118, 63);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 11;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1BindingSource1
            // 
            this.dataSet1BindingSource1.DataSource = this.dataSet1;
            this.dataSet1BindingSource1.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmployeeGrid);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_populate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.txt_ID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adonetDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adonetDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource employeeTableBindingSource1;
        private System.Windows.Forms.BindingSource adonetDataSetBindingSource;
        private System.Windows.Forms.BindingSource employeeTableBindingSource;
        private System.Windows.Forms.BindingSource adonetDataSetBindingSource1;
        private System.Windows.Forms.DataGridView EmployeeGrid;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_populate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.BindingSource dataSet1BindingSource1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
    }
}

