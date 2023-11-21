namespace CS322_DZ07
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ViewData_btn = new System.Windows.Forms.Button();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.first_name_tb = new System.Windows.Forms.TextBox();
            this.last_name_tb = new System.Windows.Forms.TextBox();
            this.age_tb = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.id_label = new System.Windows.Forms.Label();
            this.first_name_label = new System.Windows.Forms.Label();
            this.last_name_label = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.edit_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 278);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // ViewData_btn
            // 
            this.ViewData_btn.Location = new System.Drawing.Point(73, 415);
            this.ViewData_btn.Name = "ViewData_btn";
            this.ViewData_btn.Size = new System.Drawing.Size(75, 23);
            this.ViewData_btn.TabIndex = 1;
            this.ViewData_btn.Text = "View";
            this.ViewData_btn.UseVisualStyleBackColor = true;
            this.ViewData_btn.Click += new System.EventHandler(this.ViewData_btn_Click);
            // 
            // id_tb
            // 
            this.id_tb.Location = new System.Drawing.Point(73, 328);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(100, 20);
            this.id_tb.TabIndex = 2;
            this.id_tb.TextChanged += new System.EventHandler(this.id_tb_TextChanged);
            // 
            // first_name_tb
            // 
            this.first_name_tb.Location = new System.Drawing.Point(255, 328);
            this.first_name_tb.Name = "first_name_tb";
            this.first_name_tb.Size = new System.Drawing.Size(100, 20);
            this.first_name_tb.TabIndex = 3;
            // 
            // last_name_tb
            // 
            this.last_name_tb.Location = new System.Drawing.Point(442, 328);
            this.last_name_tb.Name = "last_name_tb";
            this.last_name_tb.Size = new System.Drawing.Size(100, 20);
            this.last_name_tb.TabIndex = 4;
            // 
            // age_tb
            // 
            this.age_tb.Location = new System.Drawing.Point(632, 328);
            this.age_tb.Name = "age_tb";
            this.age_tb.Size = new System.Drawing.Size(100, 20);
            this.age_tb.TabIndex = 5;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(174, 415);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 6;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(280, 415);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 7;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(73, 310);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(16, 13);
            this.id_label.TabIndex = 8;
            this.id_label.Text = "Id";
            this.id_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // first_name_label
            // 
            this.first_name_label.AutoSize = true;
            this.first_name_label.Location = new System.Drawing.Point(252, 310);
            this.first_name_label.Name = "first_name_label";
            this.first_name_label.Size = new System.Drawing.Size(55, 13);
            this.first_name_label.TabIndex = 9;
            this.first_name_label.Text = "First name";
            // 
            // last_name_label
            // 
            this.last_name_label.AutoSize = true;
            this.last_name_label.Location = new System.Drawing.Point(439, 310);
            this.last_name_label.Name = "last_name_label";
            this.last_name_label.Size = new System.Drawing.Size(56, 13);
            this.last_name_label.TabIndex = 10;
            this.last_name_label.Text = "Last name";
            this.last_name_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(629, 310);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(26, 13);
            this.age.TabIndex = 11;
            this.age.Text = "Age";
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(377, 415);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_btn.TabIndex = 12;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.age);
            this.Controls.Add(this.last_name_label);
            this.Controls.Add(this.first_name_label);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.age_tb);
            this.Controls.Add(this.last_name_tb);
            this.Controls.Add(this.first_name_tb);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.ViewData_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ViewData_btn;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.TextBox first_name_tb;
        private System.Windows.Forms.TextBox last_name_tb;
        private System.Windows.Forms.TextBox age_tb;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label first_name_label;
        private System.Windows.Forms.Label last_name_label;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Button edit_btn;
    }
}

