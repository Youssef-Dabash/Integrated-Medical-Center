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
    public partial class UpdateForm : Form
    {
        public int PatientIdUp { get; set; }

        public string PatientNameUp
        {
            get => tb_name.Text;
            set => tb_name.Text = value;
        }

        public string PatientDOBUp
        {
            get => tb_dob.Text;
            set => tb_dob.Text = value;
        }

        public string ContactNumberUp
        {
            get => tb_cn.Text;
            set => tb_cn.Text = value;
        }

        public string EmailUp
        {
            get => tb_email.Text;
            set => tb_email.Text = value;
        }

        public string AddressUp
        {
            get => tb_address.Text;
            set => tb_address.Text = value;
        }

        public UpdateForm()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            using (var conn = new SQLiteConnection("Data Source=IMCSqlite.db"))
            {
                conn.Open();
                var cmd = new SQLiteCommand("UPDATE patient SET name = @name, DateOfBirth = @dob, ContactNumber = @contact, Email = @email, Address = @address WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@name", PatientNameUp);
                cmd.Parameters.AddWithValue("@dob", PatientDOBUp);
                cmd.Parameters.AddWithValue("@contact", ContactNumberUp);
                cmd.Parameters.AddWithValue("@email", EmailUp);
                cmd.Parameters.AddWithValue("@address", AddressUp);
                cmd.Parameters.AddWithValue("@id", PatientIdUp);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Modified successfully ✅", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while updating:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
