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
            DialogResult result = MessageBox.Show("Uygulamay� Kapatmak istiyor musunuz?", "Uygulama Kapat�l�yor...", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                    MessageBox.Show("Kullanc� ad� veya �ifre hatal�");
                }
            }
            else
            {
                MessageBox.Show("�nternet Ba�lant�n�z� Kontrol Ediniz.", "�nternet Ba�lan�lam�yor...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}