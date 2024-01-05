using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BCrypt.Net;

namespace Attendance_App
{
    public partial class LoginScreen : Form
    {
        private DatabaseManager dbManager;
        private UsersManager userManager;
        public static UserSession? currentUserSession;

        public LoginScreen()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            userManager = new UsersManager();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            if (LoginUser(email, password))
            {
                int userId = userManager.GetUserId(email);
                int role = userManager.GetUserRole(email);

                currentUserSession = new UserSession(email, userManager.GetUserRole(email), userId);
                OpenHomeScreen(role);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login gagal. Periksa username dan password Anda.");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        private bool LoginUser(string email, string password)
        {
            bool isAuthenticated = userManager.AuthUser(email, password);

            return isAuthenticated;
        }

        private void OpenHomeScreen(int role)
        {
            switch (role)
            {
                case 1:
                    HomeAdministrator homeAdministrator = new HomeAdministrator();
                    homeAdministrator.Show();
                    break;

                case 2:
                    HomeLecturer homeLecturer = new HomeLecturer();
                    homeLecturer.Show();
                    break;

                case 3:
                    HomeStudent homeStudent = new HomeStudent();
                    homeStudent.Show();
                    break;

                default:
                    MessageBox.Show("Role does not valid.");
                    break;
            }

            this.Hide();
        }

        public class UserSession
        {
            public string? Email { get; private set; }
            public int Role { get; private set; }
            public int UserId { get; private set; }

            public UserSession(string email, int role, int userId)
            {
                Email = email;
                Role = role;
                UserId = userId;
            }

            public void ClearSession()
            {
                Email = null;
                Role = 0;
                UserId = 0;
            }
        }
    }
}