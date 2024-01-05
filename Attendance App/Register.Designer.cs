namespace Attendance_App
{
    partial class Register
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
            panel = new Panel();
            nameTextBox = new TextBox();
            label3 = new Label();
            passwordTextBox = new TextBox();
            emailTextBox = new TextBox();
            registerButton = new Button();
            label2 = new Label();
            label1 = new Label();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(246, 246, 246);
            panel.Controls.Add(nameTextBox);
            panel.Controls.Add(label3);
            panel.Controls.Add(passwordTextBox);
            panel.Controls.Add(emailTextBox);
            panel.Controls.Add(registerButton);
            panel.Controls.Add(label2);
            panel.Controls.Add(label1);
            panel.Location = new Point(80, 100);
            panel.Name = "panel";
            panel.Size = new Size(320, 360);
            panel.TabIndex = 12;
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.FromArgb(232, 232, 232);
            nameTextBox.Location = new Point(46, 79);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(240, 23);
            nameTextBox.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.FromArgb(50, 56, 70);
            label3.Location = new Point(46, 51);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 22;
            label3.Text = "Name";
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.FromArgb(232, 232, 232);
            passwordTextBox.Location = new Point(46, 233);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(240, 23);
            passwordTextBox.TabIndex = 20;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.FromArgb(232, 232, 232);
            emailTextBox.Location = new Point(46, 155);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(240, 23);
            emailTextBox.TabIndex = 17;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.FromArgb(50, 56, 70);
            registerButton.BackgroundImageLayout = ImageLayout.None;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.ForeColor = Color.White;
            registerButton.Location = new Point(100, 290);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(120, 25);
            registerButton.TabIndex = 16;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(50, 56, 70);
            label2.Location = new Point(46, 206);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 19;
            label2.Text = "Pasword";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.FromArgb(50, 56, 70);
            label1.Location = new Point(46, 127);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 18;
            label1.Text = "Email";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(126, 172, 120);
            ClientSize = new Size(484, 561);
            Controls.Add(panel);
            Name = "Register";
            Text = "Register";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel;
        private TextBox nameTextBox;
        private Label label3;
        private TextBox passwordTextBox;
        private TextBox emailTextBox;
        private Button registerButton;
        private Label label2;
        private Label label1;
    }
}