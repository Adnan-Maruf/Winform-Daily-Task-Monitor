namespace Daily_Task
{
    partial class SingleTask
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ck_box = new System.Windows.Forms.CheckBox();
            this.task_name = new System.Windows.Forms.Label();
            this.task_type = new System.Windows.Forms.Label();
            this.start_time = new System.Windows.Forms.TextBox();
            this.end_time = new System.Windows.Forms.TextBox();
            this.btn_active = new System.Windows.Forms.Button();
            this.task_no = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ck_box
            // 
            this.ck_box.AutoSize = true;
            this.ck_box.Location = new System.Drawing.Point(40, 18);
            this.ck_box.Name = "ck_box";
            this.ck_box.Size = new System.Drawing.Size(15, 14);
            this.ck_box.TabIndex = 0;
            this.ck_box.UseVisualStyleBackColor = true;
            // 
            // task_name
            // 
            this.task_name.AutoSize = true;
            this.task_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.task_name.Location = new System.Drawing.Point(61, 18);
            this.task_name.Name = "task_name";
            this.task_name.Size = new System.Drawing.Size(62, 13);
            this.task_name.TabIndex = 1;
            this.task_name.Text = "Task-Name";
            // 
            // task_type
            // 
            this.task_type.AutoSize = true;
            this.task_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.task_type.Location = new System.Drawing.Point(154, 18);
            this.task_type.Name = "task_type";
            this.task_type.Size = new System.Drawing.Size(58, 13);
            this.task_type.TabIndex = 2;
            this.task_type.Text = "Task-Type";
            // 
            // start_time
            // 
            this.start_time.Location = new System.Drawing.Point(258, 15);
            this.start_time.Name = "start_time";
            this.start_time.Size = new System.Drawing.Size(80, 20);
            this.start_time.TabIndex = 3;
            // 
            // end_time
            // 
            this.end_time.Location = new System.Drawing.Point(345, 15);
            this.end_time.Name = "end_time";
            this.end_time.Size = new System.Drawing.Size(80, 20);
            this.end_time.TabIndex = 4;
            // 
            // btn_active
            // 
            this.btn_active.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_active.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_active.Location = new System.Drawing.Point(456, 13);
            this.btn_active.Name = "btn_active";
            this.btn_active.Size = new System.Drawing.Size(75, 23);
            this.btn_active.TabIndex = 5;
            this.btn_active.Text = "Active";
            this.btn_active.UseVisualStyleBackColor = false;
            this.btn_active.TextChanged += new System.EventHandler(this.btn_active_TextChanged);
            this.btn_active.Click += new System.EventHandler(this.btn_active_Click);
            // 
            // task_no
            // 
            this.task_no.AutoSize = true;
            this.task_no.Location = new System.Drawing.Point(9, 17);
            this.task_no.Name = "task_no";
            this.task_no.Size = new System.Drawing.Size(13, 13);
            this.task_no.TabIndex = 6;
            this.task_no.Text = "1";
            // 
            // SingleTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.task_no);
            this.Controls.Add(this.btn_active);
            this.Controls.Add(this.end_time);
            this.Controls.Add(this.start_time);
            this.Controls.Add(this.task_type);
            this.Controls.Add(this.task_name);
            this.Controls.Add(this.ck_box);
            this.Name = "SingleTask";
            this.Size = new System.Drawing.Size(535, 46);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox ck_box;
        public System.Windows.Forms.Label task_name;
        public System.Windows.Forms.Label task_type;
        public System.Windows.Forms.TextBox start_time;
        public System.Windows.Forms.TextBox end_time;
        public System.Windows.Forms.Button btn_active;
        public System.Windows.Forms.Label task_no;

    }
}
