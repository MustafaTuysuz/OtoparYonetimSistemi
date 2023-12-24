namespace OtoparYonetimSistemi
{
    public partial class ExitCar : MetroFramework.Forms.MetroForm
    {
        VtProcess _vtProcess = new VtProcess();
        FeeCalculation _feeCalculation = new FeeCalculation();
        string _select;

        public ExitCar(string select)
        {
            InitializeComponent();
            _select = select;
            HourlyPay();
        }
        private async Task HourlyPay()
        {
            var H = await _feeCalculation.HourlyCalvulation(_select);
            var re = await _vtProcess.ExtractCarProperties(_select);

            PlateNo.Text = re.plate;
            EntranceTime.Text = re.time;
            ExitTime.Text = H.Et.ToString();

            if (H.Pt.TotalHours < 1)
            {
                pay.Text = re.repice.ToString("C");
            }
            else
            {
                pay.Text = H.p.ToString("C");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("- Ödeme Alındı.\n \n - Araç çıkış yapabilir", "", MessageBoxButtons.OK, MessageBoxIcon.None);

            if (DialogResult.OK == result)
            {
                this.Hide();
                _vtProcess.RemoveRecord(_select);
            }
        }
    }
}
