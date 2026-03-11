namespace Prihlasovani
{
    partial class AdminForm
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
            listBoxUsers = new ListBox();
            btnReset = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // listBoxUsers
            // 
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.Location = new Point(48, 12);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(150, 104);
            listBoxUsers.TabIndex = 0;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(12, 122);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(221, 29);
            btnReset.TabIndex = 1;
            btnReset.Text = "Resetovat heslo na '1234'";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(70, 157);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Odhlásit";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 200);
            Controls.Add(btnLogout);
            Controls.Add(btnReset);
            Controls.Add(listBoxUsers);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxUsers;
        private Button btnReset;
        private Button btnLogout;
    }
}