namespace Prihlasovani
{
    partial class UserForm
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
            lblWelcome = new Label();
            txtNewPassword = new TextBox();
            btnChangePass = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(28, 27);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(141, 20);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Přihlášen jako pepík";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(36, 50);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(125, 27);
            txtNewPassword.TabIndex = 1;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // btnChangePass
            // 
            btnChangePass.Location = new Point(36, 83);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(119, 29);
            btnChangePass.TabIndex = 2;
            btnChangePass.Text = "Změnit heslo";
            btnChangePass.UseVisualStyleBackColor = true;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(51, 118);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Odhlásit";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(205, 197);
            Controls.Add(btnLogout);
            Controls.Add(btnChangePass);
            Controls.Add(txtNewPassword);
            Controls.Add(lblWelcome);
            Name = "UserForm";
            Text = "UserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private TextBox txtNewPassword;
        private Button btnChangePass;
        private Button btnLogout;
    }
}