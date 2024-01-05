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
    public partial class Register : Form
    {
        private DatabaseManager dbManager;
        private UsersManager userManager;
        public Register()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            userManager = new UsersManager();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string nama = nameTextBox.Text;
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text.Trim();

            if (RegisterUser(nama, email, password))
            {
                MessageBox.Show("Registrasi berhasil! Silakan login.");
            }
            else
            {
                MessageBox.Show("Registrasi gagal. Periksa kembali informasi registrasi Anda.");
            }
        }

        private bool RegisterUser(string nama, string email, string password)
        {
            try
            {

                if (EmailAvailability(email))
                {
                    userManager.AddUser(nama, email, password, 3);
                    return true;
                }
                else
                {
                    MessageBox.Show("Email sudah digunakan. Silakan gunakan email lain.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        private bool EmailAvailability(string email)
        {
            return userManager.EmailAvailability(email);
        }
    }
}
