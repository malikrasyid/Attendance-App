using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static Attendance_App.LoginScreen;

namespace Attendance_App
{
    public partial class HomeStudent : Form
    {
        private DatabaseManager dbManager;
        public static UserSession? currentUserSession;

        public HomeStudent()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginScreen loginScreen = new LoginScreen();
                loginScreen.Show();
                this.Hide();
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dataGridViewAttendance.DataSource;

            if (dt.Rows.Count > 0)
            {
                ExportToCSV(dt);
            }
            else
            {
                MessageBox.Show("No attendance data available for export.", "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ExportToCSV(DataTable dt)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    DefaultExt = "csv",
                    Filter = "CSV files (*.csv)|*.csv",
                    Title = "Save CSV File"
                };

                DialogResult result = saveFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    StringBuilder csvContent = new StringBuilder();

                    csvContent.AppendLine("Time,Event_Name,Student,Status");

                    foreach (DataRow row in dt.Rows)
                    {
                        csvContent.AppendLine($"{row["Time"]},{row["Event_Name"]},{row["Student"]},{row["Status"]}");
                    }

                    File.WriteAllText(filePath, csvContent.ToString());

                    MessageBox.Show($"Data has been exported to {filePath}", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show("Failed to export data.", "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
