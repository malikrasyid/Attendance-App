namespace Attendance_App
{
    partial class HomeStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeStudent));
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            logoutButton = new Button();
            panel2 = new Panel();
            exportButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(246, 246, 246);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(944, 58);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(50, 56, 70);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(666, 0);
            button4.Name = "button4";
            button4.Padding = new Padding(4);
            button4.Size = new Size(95, 58);
            button4.TabIndex = 4;
            button4.Text = "Profile";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(50, 56, 70);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(557, 0);
            button3.Name = "button3";
            button3.Padding = new Padding(4);
            button3.Size = new Size(113, 58);
            button3.TabIndex = 3;
            button3.Text = "Schedule";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(50, 56, 70);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(438, 0);
            button2.Name = "button2";
            button2.Padding = new Padding(4);
            button2.Size = new Size(122, 58);
            button2.TabIndex = 2;
            button2.Text = "Dashboard";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(50, 56, 70);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(349, 0);
            button1.Name = "button1";
            button1.Padding = new Padding(4);
            button1.Size = new Size(92, 58);
            button1.TabIndex = 1;
            button1.Text = "Home";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(50, 56, 70);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(173, 30);
            label1.TabIndex = 0;
            label1.Text = "Attendance App";
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.FromArgb(246, 246, 246);
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            logoutButton.ForeColor = Color.FromArgb(50, 56, 70);
            logoutButton.Image = (Image)resources.GetObject("logoutButton.Image");
            logoutButton.ImageAlign = ContentAlignment.MiddleLeft;
            logoutButton.Location = new Point(841, 445);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(91, 44);
            logoutButton.TabIndex = 1;
            logoutButton.Text = "Logout";
            logoutButton.TextAlign = ContentAlignment.MiddleRight;
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += button5_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(246, 246, 246);
            panel2.Controls.Add(exportButton);
            panel2.Location = new Point(140, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(640, 399);
            panel2.TabIndex = 2;
            // 
            // exportButton
            // 
            exportButton.BackColor = Color.FromArgb(126, 172, 120);
            exportButton.FlatStyle = FlatStyle.Flat;
            exportButton.ForeColor = Color.FromArgb(246, 246, 246);
            exportButton.Location = new Point(257, 60);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(125, 57);
            exportButton.TabIndex = 3;
            exportButton.Text = "Export";
            exportButton.UseVisualStyleBackColor = false;
            exportButton.Click += exportButton_Click;
            // 
            // HomeStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 56, 70);
            ClientSize = new Size(944, 501);
            Controls.Add(panel2);
            Controls.Add(logoutButton);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Name = "HomeStudent";
            Text = "HomeStudent";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button logoutButton;
        private Button button4;
        private Button button3;
        private Button button2;
        private Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewAttendance;
        private Button exportButton;
    }
}