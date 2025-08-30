namespace IntegratedMedicalCenter
{
    partial class CreateNew
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
            label1 = new Label();
            lab_add_name = new Label();
            lab_add_dbo = new Label();
            lab_add_cn = new Label();
            lab_add_email = new Label();
            lab_add_address = new Label();
            tb_name = new TextBox();
            tb_dob = new TextBox();
            tb_email = new TextBox();
            tb_address = new TextBox();
            tb_cn = new TextBox();
            btn_add = new Button();
            bt_back = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 40);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Create New Patient";
            // 
            // lab_add_name
            // 
            lab_add_name.AutoSize = true;
            lab_add_name.Location = new Point(75, 103);
            lab_add_name.Name = "lab_add_name";
            lab_add_name.Size = new Size(39, 15);
            lab_add_name.TabIndex = 1;
            lab_add_name.Text = "Name";
            // 
            // lab_add_dbo
            // 
            lab_add_dbo.AutoSize = true;
            lab_add_dbo.Location = new Point(75, 159);
            lab_add_dbo.Name = "lab_add_dbo";
            lab_add_dbo.Size = new Size(73, 15);
            lab_add_dbo.TabIndex = 2;
            lab_add_dbo.Text = "Date of Birth";
            // 
            // lab_add_cn
            // 
            lab_add_cn.AutoSize = true;
            lab_add_cn.Location = new Point(75, 215);
            lab_add_cn.Name = "lab_add_cn";
            lab_add_cn.Size = new Size(96, 15);
            lab_add_cn.TabIndex = 3;
            lab_add_cn.Text = "Contact Number";
            // 
            // lab_add_email
            // 
            lab_add_email.AutoSize = true;
            lab_add_email.Location = new Point(75, 271);
            lab_add_email.Name = "lab_add_email";
            lab_add_email.Size = new Size(36, 15);
            lab_add_email.TabIndex = 4;
            lab_add_email.Text = "Email";
            // 
            // lab_add_address
            // 
            lab_add_address.AutoSize = true;
            lab_add_address.Location = new Point(75, 327);
            lab_add_address.Name = "lab_add_address";
            lab_add_address.Size = new Size(49, 15);
            lab_add_address.TabIndex = 5;
            lab_add_address.Text = "Address";
            // 
            // tb_name
            // 
            tb_name.Location = new Point(184, 103);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(120, 23);
            tb_name.TabIndex = 6;
            // 
            // tb_dob
            // 
            tb_dob.Location = new Point(184, 159);
            tb_dob.Name = "tb_dob";
            tb_dob.Size = new Size(120, 23);
            tb_dob.TabIndex = 7;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(184, 271);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(120, 23);
            tb_email.TabIndex = 9;
            // 
            // tb_address
            // 
            tb_address.Location = new Point(184, 327);
            tb_address.Name = "tb_address";
            tb_address.Size = new Size(120, 23);
            tb_address.TabIndex = 10;
            // 
            // tb_cn
            // 
            tb_cn.Location = new Point(182, 215);
            tb_cn.Name = "tb_cn";
            tb_cn.Size = new Size(120, 23);
            tb_cn.TabIndex = 8;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(75, 383);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 11;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // bt_back
            // 
            bt_back.Location = new Point(227, 383);
            bt_back.Name = "bt_back";
            bt_back.Size = new Size(75, 23);
            bt_back.TabIndex = 12;
            bt_back.Text = "Back";
            bt_back.UseVisualStyleBackColor = true;
            bt_back.Click += bt_back_Click;
            // 
            // CreateNew
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(379, 450);
            Controls.Add(bt_back);
            Controls.Add(btn_add);
            Controls.Add(tb_cn);
            Controls.Add(tb_address);
            Controls.Add(tb_email);
            Controls.Add(tb_dob);
            Controls.Add(tb_name);
            Controls.Add(lab_add_address);
            Controls.Add(lab_add_email);
            Controls.Add(lab_add_cn);
            Controls.Add(lab_add_dbo);
            Controls.Add(lab_add_name);
            Controls.Add(label1);
            Name = "CreateNew";
            Text = "Create New";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lab_add_name;
        private Label lab_add_dbo;
        private Label lab_add_cn;
        private Label lab_add_email;
        private Label lab_add_address;
        private TextBox tb_name;
        private TextBox tb_dob;
        private TextBox tb_email;
        private TextBox tb_address;
        private TextBox tb_cn;
        private Button btn_add;
        private Button bt_back;
    }
}