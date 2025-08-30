using System.Data;
using System.Data.SQLite;
using System.Xml.Linq;

namespace IntegratedMedicalCenter
{
    public partial class Form1 : Form
    {
        SQLiteConnection con = new SQLiteConnection();

        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = "Data Source=IMCSqlite.db";
        }

        private void LoadData()
        {
            using (var conn = new SQLiteConnection(con))
            {
                conn.Open();
                var da = new SQLiteDataAdapter("Select * From Patient", conn);
                var dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            CreateNew createForm = new CreateNew();
            createForm.ShowDialog();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];

                UpdateForm f = new UpdateForm();

                f.PatientIdUp = Convert.ToInt32(row.Cells["id"].Value);
                f.PatientNameUp = row.Cells["name"].Value.ToString();
                f.PatientDOBUp = row.Cells["DateOfBirth"].Value.ToString();
                f.ContactNumberUp = row.Cells["ContactNumber"].Value.ToString();
                f.EmailUp = row.Cells["Email"].Value.ToString();
                f.AddressUp = row.Cells["Address"].Value.ToString();

                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadData(); 
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this patient?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (var conn = new SQLiteConnection("Data Source=IMCSqlite.db"))
                    {
                        conn.Open();
                        var cmd = new SQLiteCommand("DELETE FROM patient WHERE id = @id", conn);
                        cmd.Parameters.AddWithValue("@id", selectedId);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("The patient was successfully deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadData(); 
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while deleting:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a patient first from the table.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}


