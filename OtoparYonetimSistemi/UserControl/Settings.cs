namespace OtoparYonetimSistemi
{
    public partial class Settings : UserControl
    {
        VtProcess _vtProcess = new VtProcess();
        public Settings()
        {
            InitializeComponent();

            RecipeSet();

            ParkingCapacity();
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamayı kapatmak istediğinizden emin misiniz?", "Kapatma Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            _vtProcess.DeleteChildAsync();
        }
        private async void ParkingCapacity()
        {
            int capacity = await _vtProcess.GetParkingCapacity();
            capacityTxt.Text = capacity.ToString();
        }

        public async void RecipeSet()
        {
            var recipe = await _vtProcess.GetRecipeData();

            hourlyTxt.Text = recipe.hourly.ToString();
            weeklyTxt.Text = recipe.weekly.ToString();
            monthlyTxt.Text = recipe.monthly.ToString();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            _vtProcess.ChangeParkingCapacity(capacityTxt.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int h, m, y;

            if (hourlyTxt.Text == "" || monthlyTxt.Text == "" || weeklyTxt.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!");
            }
            else
            {
                h = int.Parse(hourlyTxt.Text);
                m = int.Parse(monthlyTxt.Text);
                y = int.Parse(weeklyTxt.Text);

                _vtProcess.RepiceUpdate(h, m, y);
            }
        }
    }
}
