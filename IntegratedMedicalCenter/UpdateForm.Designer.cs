namespace IntegratedMedicalCenter
{
    partial class UpdateForm
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
            bt_back = new Button();
            btn_update = new Button();
            tb_cn = new TextBox();
            tb_address = new TextBox();
            tb_email = new TextBox();
            tb_dob = new TextBox();
            lab_add_address = new Label();
            lab_add_email = new Label();
            lab_add_cn = new Label();
            lab_add_dbo = new Label();
            lab_add_name = new Label();
            label1 = new Label();
            tb_name = new TextBox();
            SuspendLayout();
            // 
            // bt_back
            // 
            bt_back.Location = new Point(276, 386);
            bt_back.Name = "bt_back";
            bt_back.Size = new Size(75, 23);
            bt_back.TabIndex = 26;
            bt_back.Text = "Back";
            bt_back.UseVisualStyleBackColor = true;
            bt_back.Click += bt_back_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(124, 385);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 25;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // tb_cn
            // 
            tb_cn.Location = new Point(231, 211);
            tb_cn.Name = "tb_cn";
            tb_cn.Size = new Size(120, 23);
            tb_cn.TabIndex = 22;
            // 
            // tb_address
            // 
            tb_address.Location = new Point(233, 317);
            tb_address.Name = "tb_address";
            tb_address.Size = new Size(120, 23);
            tb_address.TabIndex = 24;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(233, 264);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(120, 23);
            tb_email.TabIndex = 23;
            // 
            // tb_dob
            // 
            tb_dob.Location = new Point(233, 158);
            tb_dob.Name = "tb_dob";
            tb_dob.Size = new Size(120, 23);
            tb_dob.TabIndex = 21;
            // 
            // lab_add_address
            // 
            lab_add_address.AutoSize = true;
            lab_add_address.Location = new Point(124, 329);
            lab_add_address.Name = "lab_add_address";
            lab_add_address.Size = new Size(49, 15);
            lab_add_address.TabIndex = 18;
            lab_add_address.Text = "Address";
            // 
            // lab_add_email
            // 
            lab_add_email.AutoSize = true;
            lab_add_email.Location = new Point(124, 273);
            lab_add_email.Name = "lab_add_email";
            lab_add_email.Size = new Size(36, 15);
            lab_add_email.TabIndex = 17;
            lab_add_email.Text = "Email";
            // 
            // lab_add_cn
            // 
            lab_add_cn.AutoSize = true;
            lab_add_cn.Location = new Point(124, 217);
            lab_add_cn.Name = "lab_add_cn";
            lab_add_cn.Size = new Size(96, 15);
            lab_add_cn.TabIndex = 16;
            lab_add_cn.Text = "Contact Number";
            // 
            // lab_add_dbo
            // 
            lab_add_dbo.AutoSize = true;
            lab_add_dbo.Location = new Point(124, 161);
            lab_add_dbo.Name = "lab_add_dbo";
            lab_add_dbo.Size = new Size(73, 15);
            lab_add_dbo.TabIndex = 15;
            lab_add_dbo.Text = "Date of Birth";
            // 
            // lab_add_name
            // 
            lab_add_name.AutoSize = true;
            lab_add_name.Location = new Point(124, 105);
            lab_add_name.Name = "lab_add_name";
            lab_add_name.Size = new Size(39, 15);
            lab_add_name.TabIndex = 14;
            lab_add_name.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(193, 45);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 13;
            label1.Text = "Update Date";
            // 
            // tb_name
            // 
            tb_name.Location = new Point(233, 105);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(120, 23);
            tb_name.TabIndex = 20;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(468, 450);
            Controls.Add(tb_name);
            Controls.Add(bt_back);
            Controls.Add(btn_update);
            Controls.Add(tb_cn);
            Controls.Add(tb_address);
            Controls.Add(tb_email);
            Controls.Add(tb_dob);
            Controls.Add(lab_add_address);
            Controls.Add(lab_add_email);
            Controls.Add(lab_add_cn);
            Controls.Add(lab_add_dbo);
            Controls.Add(lab_add_name);
            Controls.Add(label1);
            Name = "UpdateForm";
            Text = "Update Data";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_back;
        private Button btn_update;
        private TextBox tb_cn;
        private TextBox tb_address;
        private TextBox tb_email;
        private TextBox tb_dob;
        private TextBox PatientName;
        private Label lab_add_address;
        private Label lab_add_email;
        private Label lab_add_cn;
        private Label lab_add_dbo;
        private Label lab_add_name;
        private Label label1;
        private TextBox tb_name;
    }
}