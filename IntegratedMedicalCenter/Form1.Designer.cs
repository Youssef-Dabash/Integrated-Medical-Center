namespace IntegratedMedicalCenter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_create = new Button();
            btn_read = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            dataGridView1 = new DataGridView();
            btn_close = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_create
            // 
            btn_create.Location = new Point(12, 12);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(75, 23);
            btn_create.TabIndex = 0;
            btn_create.Text = "Create";
            btn_create.UseVisualStyleBackColor = true;
            btn_create.Click += btn_create_Click;
            // 
            // btn_read
            // 
            btn_read.Location = new Point(156, 12);
            btn_read.Name = "btn_read";
            btn_read.Size = new Size(75, 23);
            btn_read.TabIndex = 1;
            btn_read.Text = "Read";
            btn_read.UseVisualStyleBackColor = true;
            btn_read.Click += btn_read_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(312, 12);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 2;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(488, 12);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(761, 463);
            dataGridView1.TabIndex = 4;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(670, 12);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(75, 23);
            btn_close.TabIndex = 5;
            btn_close.Text = "Close";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 525);
            Controls.Add(btn_close);
            Controls.Add(dataGridView1);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_read);
            Controls.Add(btn_create);
            Name = "Form1";
            Text = "CRUD";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_create;
        private Button btn_read;
        private Button btn_update;
        private Button btn_delete;
        private DataGridView dataGridView1;
        private Button btn_close;
    }
}
