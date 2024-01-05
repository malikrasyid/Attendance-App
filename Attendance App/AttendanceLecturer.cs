using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_App
{
    public partial class AttendanceLecturer : Form
    {
        private DatabaseManager dbManager;
        private AttendanceManager attendanceManager;
        public AttendanceLecturer()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close this page?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                HomeLecturer homeLecturer = new HomeLecturer();
                homeLecturer.Show();
                this.Hide();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DataRowView selectedStudent = (DataRowView)userComboBox.SelectedItem;
            long UserID = Convert.ToInt64(selectedStudent["UserID"]);
            DataRowView selectedEvent = (DataRowView)eventComboBox.SelectedItem;
            int EventID = Convert.ToInt32(selectedEvent["EventID"]);
            DataRowView selectedStatus = (DataRowView)statusComboBox.SelectedItem;
            int Status = Convert.ToInt32(selectedStatus["Kehadiran"]);

            if (AddAttendance(UserID, EventID, Status))
            {
            }
            else
            {
                MessageBox.Show("Attendance failed to be added.");
            }

            refreshData();
        }

        private bool AddAttendance(long UserID, int EventID, int Status)
        {
            try
            {
                attendanceManager.InputAttendance(UserID, EventID, Status);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
    }
}
