namespace Prihlasovani
{


    public partial class AdminForm : Form
    {

        private Admin currentAdmin;
        private List<User> allUsers;

        public AdminForm(Admin admin, List<User> users)
        {
            InitializeComponent();
            currentAdmin = admin;
            allUsers = users;
            RefreshList();
        }

        private void RefreshList()
        {
            listBoxUsers.DataSource = null;
            listBoxUsers.DataSource = allUsers;
            listBoxUsers.DisplayMember = "Username"; // ListBox zobrazí jen jména
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            User selected = (User)listBoxUsers.SelectedItem;

            if (selected != null)
            {
                selected.PasswordHash = User.HashPassword("1234");
                DataService.SaveUsers(allUsers);
                MessageBox.Show($"Uživateli {selected.Username} bylo heslo nastaveno na '1234'");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}

