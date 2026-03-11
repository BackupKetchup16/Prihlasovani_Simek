using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prihlasovani
{
    public partial class UserForm : Form
    {
        User currentUser;
        List<User> allUsers;

        public UserForm(User user, List<User> users)
        {
            InitializeComponent();
            currentUser = user;
            allUsers = users;
            lblWelcome.Text = $"Přihlášen jako: {user.Username}";
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text) || txtNewPassword.Text.Length < 4)
            {
                MessageBox.Show("Nové heslo musí mít alespoň 4 znaky!");
                return;
            }

            currentUser.PasswordHash = User.HashPassword(txtNewPassword.Text);
            DataService.SaveUsers(allUsers);

            MessageBox.Show("Heslo úspěšně změněno. Nyní se přihlaste znovu novým heslem.");
            this.Close(); 
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
