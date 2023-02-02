namespace TypedUntypes
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
            this.btn_typed = new System.Windows.Forms.Button();
            this.btn_untyped = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adonetDataSet = new TypedUntypes.adonetDataSet();
            this.adonetDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.employeeTableTableAdapter = new TypedUntypes.adonetDataSetTableAdapters.EmployeeTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adonetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adonetDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_typed
            // 
            this.btn_typed.Location = new System.Drawing.Point(119, 250);
            this.btn_typed.Name = "btn_typed";
            this.btn_typed.Size = new System.Drawing.Size(107, 50);
            this.btn_typed.TabIndex = 0;
            this.btn_typed.Text = "Display Typed";
            this.btn_typed.UseVisualStyleBackColor = true;
            this.btn_typed.Click += new System.EventHandler(this.btn_typed_Click);
            // 
            // btn_untyped
            // 
            this.btn_untyped.Location = new System.Drawing.Point(330, 250);
            this.btn_untyped.Name = "btn_untyped";
            this.btn_untyped.Size = new System.Drawing.Size(103, 50);
            this.btn_untyped.TabIndex = 1;
            this.btn_untyped.Text = "Display Untyped";
            this.btn_untyped.UseVisualStyleBackColor = true;
            this.btn_untyped.Click += new System.EventHandler(this.btn_untyped_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(243, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "Update Untyped";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AutoGenerateColumns = false;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.employeeSalaryDataGridViewTextBoxColumn,
            this.departmentIDDataGridViewTextBoxColumn});
            this.dgvEmployee.DataSource = this.employeeTableBindingSource;
            this.dgvEmployee.Location = new System.Drawing.Point(353, 78);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(240, 150);
            this.dgvEmployee.TabIndex = 3;
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
            // employeeTableBindingSource
            // 
            this.employeeTableBindingSource.DataMember = "EmployeeTable";
            this.employeeTableBindingSource.DataSource = this.adonetDataSet;
            // 
            // adonetDataSet
            // 
            this.adonetDataSet.DataSetName = "adonetDataSet";
            this.adonetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adonetDataSetBindingSource
            // 
            this.adonetDataSetBindingSource.DataSource = this.adonetDataSet;
            this.adonetDataSetBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(119, 78);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(178, 20);
            this.txt_name.TabIndex = 5;
            // 
            // employeeTableTableAdapter
            // 
            this.employeeTableTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_untyped);
            this.Controls.Add(this.btn_typed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adonetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adonetDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_typed;
        private System.Windows.Forms.Button btn_untyped;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.BindingSource adonetDataSetBindingSource;
        private adonetDataSet adonetDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.BindingSource employeeTableBindingSource;
        private adonetDataSetTableAdapters.EmployeeTableTableAdapter employeeTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
    }
}

