namespace SQLOperations
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
            this.button_select = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.label_empid = new System.Windows.Forms.Label();
            this.label_empname = new System.Windows.Forms.Label();
            this.label_empsalary = new System.Windows.Forms.Label();
            this.label_dptid = new System.Windows.Forms.Label();
            this.txt_empid = new System.Windows.Forms.TextBox();
            this.txt_empname = new System.Windows.Forms.TextBox();
            this.txt_empsalary = new System.Windows.Forms.TextBox();
            this.txt_dptid = new System.Windows.Forms.TextBox();
            this.employeeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDataSet = new SQLOperations.EmployeeDataSet();
            this.employeeTableTableAdapter = new SQLOperations.EmployeeDataSetTableAdapters.EmployeeTableTableAdapter();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // button_select
            // 
            this.button_select.Location = new System.Drawing.Point(294, 343);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(87, 45);
            this.button_select.TabIndex = 0;
            this.button_select.Text = "Select";
            this.button_select.UseVisualStyleBackColor = true;
            this.button_select.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(418, 343);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(89, 45);
            this.button_insert.TabIndex = 1;
            this.button_insert.Text = "Insert";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(541, 343);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(86, 45);
            this.button_update.TabIndex = 2;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(660, 343);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(84, 45);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label_empid
            // 
            this.label_empid.AutoSize = true;
            this.label_empid.Location = new System.Drawing.Point(22, 54);
            this.label_empid.Name = "label_empid";
            this.label_empid.Size = new System.Drawing.Size(67, 13);
            this.label_empid.TabIndex = 4;
            this.label_empid.Text = "Employee ID";
            this.label_empid.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label_empname
            // 
            this.label_empname.AutoSize = true;
            this.label_empname.Location = new System.Drawing.Point(22, 121);
            this.label_empname.Name = "label_empname";
            this.label_empname.Size = new System.Drawing.Size(84, 13);
            this.label_empname.TabIndex = 5;
            this.label_empname.Text = "Employee Name";
            // 
            // label_empsalary
            // 
            this.label_empsalary.AutoSize = true;
            this.label_empsalary.Location = new System.Drawing.Point(22, 186);
            this.label_empsalary.Name = "label_empsalary";
            this.label_empsalary.Size = new System.Drawing.Size(85, 13);
            this.label_empsalary.TabIndex = 6;
            this.label_empsalary.Text = "Employee Salary";
            // 
            // label_dptid
            // 
            this.label_dptid.AutoSize = true;
            this.label_dptid.Location = new System.Drawing.Point(22, 247);
            this.label_dptid.Name = "label_dptid";
            this.label_dptid.Size = new System.Drawing.Size(76, 13);
            this.label_dptid.TabIndex = 7;
            this.label_dptid.Text = "Department ID";
            // 
            // txt_empid
            // 
            this.txt_empid.Location = new System.Drawing.Point(141, 54);
            this.txt_empid.Name = "txt_empid";
            this.txt_empid.Size = new System.Drawing.Size(100, 20);
            this.txt_empid.TabIndex = 8;
            // 
            // txt_empname
            // 
            this.txt_empname.Location = new System.Drawing.Point(141, 118);
            this.txt_empname.Name = "txt_empname";
            this.txt_empname.Size = new System.Drawing.Size(100, 20);
            this.txt_empname.TabIndex = 9;
            // 
            // txt_empsalary
            // 
            this.txt_empsalary.Location = new System.Drawing.Point(141, 179);
            this.txt_empsalary.Name = "txt_empsalary";
            this.txt_empsalary.Size = new System.Drawing.Size(100, 20);
            this.txt_empsalary.TabIndex = 10;
            // 
            // txt_dptid
            // 
            this.txt_dptid.Location = new System.Drawing.Point(141, 240);
            this.txt_dptid.Name = "txt_dptid";
            this.txt_dptid.Size = new System.Drawing.Size(100, 20);
            this.txt_dptid.TabIndex = 11;
            // 
            // employeeTableBindingSource
            // 
            this.employeeTableBindingSource.DataMember = "EmployeeTable";
            this.employeeTableBindingSource.DataSource = this.employeeDataSet;
            // 
            // employeeDataSet
            // 
            this.employeeDataSet.DataSetName = "EmployeeDataSet";
            this.employeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableTableAdapter
            // 
            this.employeeTableTableAdapter.ClearBeforeFill = true;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(294, 54);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(333, 230);
            this.dgvEmployee.TabIndex = 12;
            this.dgvEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.txt_dptid);
            this.Controls.Add(this.txt_empsalary);
            this.Controls.Add(this.txt_empname);
            this.Controls.Add(this.txt_empid);
            this.Controls.Add(this.label_dptid);
            this.Controls.Add(this.label_empsalary);
            this.Controls.Add(this.label_empname);
            this.Controls.Add(this.label_empid);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.button_select);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label_empid;
        private System.Windows.Forms.Label label_empname;
        private System.Windows.Forms.Label label_empsalary;
        private System.Windows.Forms.Label label_dptid;
        private System.Windows.Forms.TextBox txt_empid;
        private System.Windows.Forms.TextBox txt_empname;
        private System.Windows.Forms.TextBox txt_empsalary;
        private System.Windows.Forms.TextBox txt_dptid;
        private EmployeeDataSet employeeDataSet;
        private System.Windows.Forms.BindingSource employeeTableBindingSource;
        private EmployeeDataSetTableAdapters.EmployeeTableTableAdapter employeeTableTableAdapter;
        private System.Windows.Forms.DataGridView dgvEmployee;
    }
}

