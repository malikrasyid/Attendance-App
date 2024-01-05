using System;
using System.Data;

namespace Attendance_App
{
    internal class AttendanceManager : IDisposable
    {
        private DatabaseManager dbManager;

        public AttendanceManager()
        {
            dbManager = new DatabaseManager();
        }

        public void InputAttendance(int userId, int eventId, int status)
        {
            try
            {
                // Memeriksa apakah sudah ada presensi untuk student dan event tertentu
                if (!IsAttendanceExists(userId, eventId))
                {
                    string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string query = $"INSERT INTO attendance (user_id, event_id, status, time_stamp) VALUES ('{userId}', '{eventId}', '{status}', '{currentTime}')";
                    dbManager.ExecuteNonQuery(query);
                    MessageBox.Show("Attendance successfully added.");
                }
                else
                {
                    MessageBox.Show("Attendance for this student and event already exists.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void EditAttendance(int attendanceId, int userId, int eventId, int status)
        {
            try
            {
                // Memeriksa apakah sudah ada presensi untuk student dan event tertentu
                if (!IsAttendanceExists(userId, eventId, attendanceId))
                {
                    int currentUserRole = GetUserRole(LoginScreen.currentUserSession.Email);
                    int lecturerId = LoginScreen.currentUserSession.UserId;

                    // Memeriksa apakah pengguna adalah admin atau dosen yang mengampu mata kuliah pada event terkait
                    if (currentUserRole == 1 || (IsEventInLecturerSubject(attendanceId, lecturerId)))
                    {
                        string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        string query = $"UPDATE attendance SET user_id = '{userId}', event_id = '{eventId}', status = '{status}', time_stamp = '{currentTime}' WHERE attendance_id = '{attendanceId}'";
                        dbManager.ExecuteNonQuery(query);
                        MessageBox.Show("Attendance successfully edited.");
                    }
                    else
                    {
                        MessageBox.Show("Attendance ID does not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Attendance for this student and event already exists.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private bool IsAttendanceExists(int userId, int eventId, int excludeAttendanceId = -1)
        {
            string query = $"SELECT COUNT(*) FROM attendance WHERE user_id = '{userId}' AND event_id = '{eventId}'";

            if (excludeAttendanceId != -1)
            {
                query += $" AND attendance_id != '{excludeAttendanceId}'";
            }

            int attendanceCount = Convert.ToInt32(dbManager.ExecuteQuery(query).Rows[0][0]);
            return attendanceCount > 0;
        }

        public void RemoveAttendance(int attendanceId, int userId)
        {
            try
            {
                int currentUserRole = GetUserRole(LoginScreen.currentUserSession.Email);

                if (currentUserRole == 1 || IsEventInLecturerSubject(attendanceId, userId))
                {
                    string query = $"DELETE FROM attendance WHERE attendance_id = '{attendanceId}'";
                    dbManager.ExecuteNonQuery(query);
                    MessageBox.Show("Attendance successfully deleted.");
                }
                else
                {
                    MessageBox.Show("Attendance ID does not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show("Failed to delete attendance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int GetUserRole(string email)
        {
            string query = $"SELECT role_id FROM user WHERE email = '{email}'";
            DataTable result = dbManager.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0]["role"]);
            }

            return 0;
        }

        private bool IsEventInLecturerSubject(int attendanceId, int userId)
        {
            // Memeriksa apakah event yang terkait dengan presensi memiliki mata kuliah yang diampu oleh dosen
            string query = $"SELECT e.event_id FROM attendance a " +
                           $"INNER JOIN event e ON a.event_id = e.event_id " +
                           $"INNER JOIN subject s ON e.subject_id = s.subject_id " +
                           $"WHERE a.attendance_id = '{attendanceId}' AND mk.UserID = '{userId}'";

            DataTable result = dbManager.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public void Dispose()
        {
            dbManager.Dispose();
        }
    }
}