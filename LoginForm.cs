

namespace Prihlasovani
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var users = DataService.LoadUsers();
            string enteredPass = txtPassword.Text;
            string hash = User.HashPassword(enteredPass);
            User found = users.Find(u => u.Username == txtUsername.Text && u.PasswordHash == hash);

            if (found != null)
            {
                // Seznam výchozích hesel, která chceme hlídat
                string[] defaultPasswords = { "admin123", "1234", "reset123" };
                bool isDefault = false;

                foreach (string dp in defaultPasswords)
                {
                    if (User.HashPassword(dp) == found.PasswordHash)
                    {
                        isDefault = true;
                        break;
                    }
                }

                if (isDefault)
                {
                    MessageBox.Show("Používáte výchozí heslo! Pøed pokraèováním si jej musíte zmìnit.",
                                    "Bezpeènostní upozornìní", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    this.Hide();
                    UserForm changeForm = new UserForm(found, users);
                    changeForm.ShowDialog();

                    this.Show();
                    txtPassword.Clear();
                    return;
                }

                this.Hide();
                if (found is Admin admin)
                    new AdminForm(admin, users).ShowDialog();
                else
                    new UserForm(found, users).ShowDialog();

                this.Show();
                txtPassword.Clear();
            }
            else MessageBox.Show("Chyba pøihlášení!");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Vyplò jméno, šampione!");
                return;
            }

            var users = DataService.LoadUsers();
            users.Add(new User(txtUsername.Text, txtPassword.Text));
            DataService.SaveUsers(users);
            MessageBox.Show("Uživatel zaregistrován!");
        }

    }
}
