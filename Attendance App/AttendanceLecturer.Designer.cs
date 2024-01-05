namespace Attendance_App
{
    partial class AttendanceLecturer
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
            panel1 = new Panel();
            backButton = new Button();
            addButton = new Button();
            statusComboBox = new ComboBox();
            eventComboBox = new ComboBox();
            userComboBox = new ComboBox();
            attendanceTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(246, 246, 246);
            panel1.Controls.Add(backButton);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(statusComboBox);
            panel1.Controls.Add(eventComboBox);
            panel1.Controls.Add(userComboBox);
            panel1.Controls.Add(attendanceTextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(62, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 351);
            panel1.TabIndex = 0;
            // 
            // backButton
            // 
            backButton.BackColor = Color.FromArgb(50, 56, 70);
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.ForeColor = Color.FromArgb(246, 246, 246);
            backButton.Location = new Point(587, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 10;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(50, 56, 70);
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.ForeColor = Color.FromArgb(246, 246, 246);
            addButton.Location = new Point(263, 198);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 9;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // statusComboBox
            // 
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(161, 152);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(177, 23);
            statusComboBox.TabIndex = 7;
            // 
            // eventComboBox
            // 
            eventComboBox.FormattingEnabled = true;
            eventComboBox.Location = new Point(161, 113);
            eventComboBox.Name = "eventComboBox";
            eventComboBox.Size = new Size(177, 23);
            eventComboBox.TabIndex = 6;
            // 
            // userComboBox
            // 
            userComboBox.FormattingEnabled = true;
            userComboBox.Location = new Point(161, 74);
            userComboBox.Name = "userComboBox";
            userComboBox.Size = new Size(177, 23);
            userComboBox.TabIndex = 5;
            // 
            // attendanceTextBox
            // 
            attendanceTextBox.Location = new Point(161, 33);
            attendanceTextBox.Name = "attendanceTextBox";
            attendanceTextBox.Size = new Size(177, 23);
            attendanceTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 155);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 116);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Event";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 77);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Student";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 36);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Attendance ID";
            // 
            // AttendanceLecturer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(126, 172, 120);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "AttendanceLecturer";
            Text = "AttendanceLecturer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox attendanceTextBox;
        private ComboBox userComboBox;
        private ComboBox eventComboBox;
        private ComboBox statusComboBox;
        private Button backButton;
        private Button addButton;
    }
}