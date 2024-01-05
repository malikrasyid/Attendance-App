using System;
using System.Data;
using System.Windows.Forms;
using BCrypt.Net;

namespace Attendance_App
{
    internal class UsersManager : IDisposable
    {
        private DatabaseManager dbManager;

        public UsersManager()
        {
            dbManager = new DatabaseManager();
        }

        public bool AuthUser(string email, string password)
        {
            string query = $"SELECT * FROM user WHERE email='{email}'";
            DataTable result = dbManager.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                string hashedPasswordFromDatabase = result.Rows[0]["password"].ToString();

                bool isAuthenticated = BCrypt.Net.BCrypt.Verify(password, hashedPasswordFromDatabase);

                if (!isAuthenticated)
                {
                    MessageBox.Show($"Authentication failed. Email: {email}, Password: {password}, Hashed Password: {hashedPasswordFromDatabase}");
                }

                return isAuthenticated;
            }

            return false;
        }



        public void AddUser(string name, string email, string password, int roleId)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            string query = $"INSERT INTO user (name, email, password, role_id) VALUES ('{name}', '{email}', '{hashedPassword}', '{roleId}')";
            dbManager.ExecuteNonQuery(query);
        }

        public void UpdateUser(int userId, string newRole)
        {
            string query = $"UPDATE user SET role = '{newRole}' WHERE user_id = {userId}";
            dbManager.ExecuteNonQuery(query);
        }


        public void RemoveUser(int userId)
        {
            string query = $"DELETE FROM Users WHERE ID = {userId}";
            dbManager.ExecuteNonQuery(query);
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

        public bool EmailAvailability(string email)
        {
            string query = $"SELECT COUNT(*) FROM user WHERE email = '{email}'";
            int userCount = Convert.ToInt32(dbManager.ExecuteQuery(query).Rows[0][0]);

            return userCount == 0;
        }

        public int GetUserId(string email)
        {
            string query = $"SELECT user_id FROM user WHERE email = '{email}'";
            DataTable result = dbManager.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0]["id"]);
            }

            return 0;
        }

        public void Dispose()
        {
            dbManager.Dispose();
        }


    }
}
