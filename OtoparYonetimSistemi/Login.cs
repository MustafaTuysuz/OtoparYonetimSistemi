namespace OtoparYonetimSistemi
{
    public partial class Login : Form
    {
        VtProcess _VtProcess = new VtProcess();
        string UserName = "", Password = "";
        public Login()
        {
            InitializeComponent();
            _VtProcess.FirebaseConnect();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamayý Kapatmak istiyor musunuz?", "Uygulama Kapatýlýyor...", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (_VtProcess.IsInternetAvailable() || true)
            {
                _VtProcess.FirebaseConnect();
                if (txt_User.Text.ToString() == UserName && txt_Pass.Text.ToString() == Password)
                {
                    Home home = new Home();
                    this.Hide();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Kullancý adý veya Þifre hatalý");
                }
            }
            else
            {
                MessageBox.Show("Ýnternet Baðlantýnýzý Kontrol Ediniz.", "Ýnternet Baðlanýlamýyor...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}