namespace ConnectedAssignment
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
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adonetDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adonetDataSet = new ConnectedAssignment.adonetDataSet();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_display = new System.Windows.Forms.Button();
            this.btn_populate = new System.Windows.Forms.Button();
            this.EmployeeGrid = new System.Windows.Forms.DataGridView();
            this.adonetDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableTableAdapter = new ConnectedAssignment.adonetDataSetTableAdapters.EmployeeTableTableAdapter();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSalaryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adonetDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adonetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adonetDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(99, 56);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 0;
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(99, 178);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(100, 20);
            this.txt_salary.TabIndex = 1;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(99, 120);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salary";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.employeeSalaryDataGridViewTextBoxColumn,
            this.departmentIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(330, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // adonetDataSetBindingSource
            // 
            this.adonetDataSetBindingSource.DataSource = this.adonetDataSet;
            this.adonetDataSetBindingSource.Position = 0;
            // 
            // adonetDataSet
            // 
            this.adonetDataSet.DataSetName = "adonetDataSet";
            this.adonetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(233, 200);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 7;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(388, 200);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(75, 23);
            this.btn_display.TabIndex = 8;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // btn_populate
            // 
            this.btn_populate.Location = new System.Drawing.Point(527, 200);
            this.btn_populate.Name = "btn_populate";
            this.btn_populate.Size = new System.Drawing.Size(75, 23);
            this.btn_populate.TabIndex = 9;
            this.btn_populate.Text = "Populate";
            this.btn_populate.UseVisualStyleBackColor = true;
            this.btn_populate.Click += new System.EventHandler(this.btn_populate_Click);
            // 
            // EmployeeGrid
            // 
            this.EmployeeGrid.AutoGenerateColumns = false;
            this.EmployeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn1,
            this.employeeNameDataGridViewTextBoxColumn1,
            this.employeeSalaryDataGridViewTextBoxColumn1,
            this.departmentIDDataGridViewTextBoxColumn1});
            this.EmployeeGrid.DataSource = this.employeeTableBindingSource1;
            this.EmployeeGrid.Location = new System.Drawing.Point(510, 261);
            this.EmployeeGrid.Name = "EmployeeGrid";
            this.EmployeeGrid.Size = new System.Drawing.Size(240, 150);
            this.EmployeeGrid.TabIndex = 10;
            // 
            // adonetDataSetBindingSource1
            // 
            this.adonetDataSetBindingSource1.DataSource = this.adonetDataSet;
            this.adonetDataSetBindingSource1.Position = 0;
            // 
            // employeeTableBindingSource
            // 
            this.employeeTableBindingSource.DataMember = "EmployeeTable";
            this.employeeTableBindingSource.DataSource = this.adonetDataSetBindingSource1;
            // 
            // employeeTableTableAdapter
            // 
            this.employeeTableTableAdapter.ClearBeforeFill = true;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            // 
            // employeeSalaryDataGridViewTextBoxColumn
            // 
            this.employeeSalaryDataGridViewTextBoxColumn.DataPropertyName = "EmployeeSalary";
            this.employeeSalaryDataGridViewTextBoxColumn.HeaderText = "EmployeeSalary";
            this.employeeSalaryDataGridViewTextBoxColumn.Name = "employeeSalaryDataGridViewTextBoxColumn";
            // 
            // departmentIDDataGridViewTextBoxColumn
            // 
            this.departmentIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.HeaderText = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.Name = "departmentIDDataGridViewTextBoxColumn";
            // 
            // employeeTableBindingSource1
            // 
            this.employeeTableBindingSource1.DataMember = "EmployeeTable";
            this.employeeTableBindingSource1.DataSource = this.adonetDataSetBindingSource;
            // 
            // employeeIdDataGridViewTextBoxColumn1
            // 
            this.employeeIdDataGridViewTextBoxColumn1.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn1.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn1.Name = "employeeIdDataGridViewTextBoxColumn1";
            // 
            // employeeNameDataGridViewTextBoxColumn1
            // 
            this.employeeNameDataGridViewTextBoxColumn1.DataPropertyName = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn1.HeaderText = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn1.Name = "employeeNameDataGridViewTextBoxColumn1";
            // 
            // employeeSalaryDataGridViewTextBoxColumn1
            // 
            this.employeeSalaryDataGridViewTextBoxColumn1.DataPropertyName = "EmployeeSalary";
            this.employeeSalaryDataGridViewTextBoxColumn1.HeaderText = "EmployeeSalary";
            this.employeeSalaryDataGridViewTextBoxColumn1.Name = "employeeSalaryDataGridViewTextBoxColumn1";
            // 
            // departmentIDDataGridViewTextBoxColumn1
            // 
            this.departmentIDDataGridViewTextBoxColumn1.DataPropertyName = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn1.HeaderText = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn1.Name = "departmentIDDataGridViewTextBoxColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmployeeGrid);
            this.Controls.Add(this.btn_populate);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.btn_next);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adonetDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adonetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adonetDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource adonetDataSetBindingSource;
        private adonetDataSet adonetDataSet;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.Button btn_populate;
        private System.Windows.Forms.DataGridView EmployeeGrid;
        private System.Windows.Forms.BindingSource adonetDataSetBindingSource1;
        private System.Windows.Forms.BindingSource employeeTableBindingSource;
        private adonetDataSetTableAdapters.EmployeeTableTableAdapter employeeTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeSalaryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource employeeTableBindingSource1;
    }
}

