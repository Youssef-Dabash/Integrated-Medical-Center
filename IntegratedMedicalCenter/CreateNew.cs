using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegratedMedicalCenter
{
    public partial class CreateNew : Form
    {
        public string PatientName => tb_name.Text;
        public string DateOfBirth => tb_dob.Text;
        public string ContactNumber => tb_cn.Text;
        public string Email => tb_email.Text;
        public string Address => tb_address.Text;

        public CreateNew()
        {
            InitializeComponent();
        }
        

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (var conn = new SQLiteConnection("Data Source=IMCSqlite.db"))
            {
                conn.Open();

                var cmd = new SQLiteCommand("INSERT INTO patient (name, DateOfBirth, ContactNumber, Email, Address) VALUES (@name, @dob, @contact, @email, @address)", conn);

                cmd.Parameters.AddWithValue("@name", tb_name.Text);
                cmd.Parameters.AddWithValue("@dob", tb_dob.Text);
                cmd.Parameters.AddWithValue("@contact", tb_cn.Text);
                cmd.Parameters.AddWithValue("@email", tb_email.Text);
                cmd.Parameters.AddWithValue("@address", tb_address.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Created ✅", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tb_name.Clear();
                    tb_dob.Clear();
                    tb_cn.Clear();
                    tb_email.Clear();
                    tb_address.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not Valid:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
