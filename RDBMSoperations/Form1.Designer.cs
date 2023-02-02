namespace RDBMSoperations
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
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.select_btn = new System.Windows.Forms.Button();
            this.totalsalary_btn = new System.Windows.Forms.Button();
            this.minimum_btn = new System.Windows.Forms.Button();
            this.btn_maximum = new System.Windows.Forms.Button();
            this.btn_average = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(190, 12);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(376, 205);
            this.dgvEmployee.TabIndex = 0;
            // 
            // select_btn
            // 
            this.select_btn.Location = new System.Drawing.Point(12, 282);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(75, 23);
            this.select_btn.TabIndex = 1;
            this.select_btn.Text = "Select";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // totalsalary_btn
            // 
            this.totalsalary_btn.Location = new System.Drawing.Point(147, 282);
            this.totalsalary_btn.Name = "totalsalary_btn";
            this.totalsalary_btn.Size = new System.Drawing.Size(75, 23);
            this.totalsalary_btn.TabIndex = 2;
            this.totalsalary_btn.Text = "Total Salary";
            this.totalsalary_btn.UseVisualStyleBackColor = true;
            this.totalsalary_btn.Click += new System.EventHandler(this.totalsalary_btn_Click);
            // 
            // minimum_btn
            // 
            this.minimum_btn.Location = new System.Drawing.Point(301, 282);
            this.minimum_btn.Name = "minimum_btn";
            this.minimum_btn.Size = new System.Drawing.Size(75, 23);
            this.minimum_btn.TabIndex = 3;
            this.minimum_btn.Text = "Mininum";
            this.minimum_btn.UseVisualStyleBackColor = true;
            this.minimum_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_maximum
            // 
            this.btn_maximum.Location = new System.Drawing.Point(456, 282);
            this.btn_maximum.Name = "btn_maximum";
            this.btn_maximum.Size = new System.Drawing.Size(75, 23);
            this.btn_maximum.TabIndex = 4;
            this.btn_maximum.Text = "Maximum";
            this.btn_maximum.UseVisualStyleBackColor = true;
            this.btn_maximum.Click += new System.EventHandler(this.btn_maximum_Click);
            // 
            // btn_average
            // 
            this.btn_average.Location = new System.Drawing.Point(589, 282);
            this.btn_average.Name = "btn_average";
            this.btn_average.Size = new System.Drawing.Size(75, 23);
            this.btn_average.TabIndex = 5;
            this.btn_average.Text = "Average";
            this.btn_average.UseVisualStyleBackColor = true;
            this.btn_average.Click += new System.EventHandler(this.btn_average_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_average);
            this.Controls.Add(this.btn_maximum);
            this.Controls.Add(this.minimum_btn);
            this.Controls.Add(this.totalsalary_btn);
            this.Controls.Add(this.select_btn);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.Button totalsalary_btn;
        private System.Windows.Forms.Button minimum_btn;
        private System.Windows.Forms.Button btn_maximum;
        private System.Windows.Forms.Button btn_average;
    }
}

