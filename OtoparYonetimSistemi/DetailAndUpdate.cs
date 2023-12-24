namespace OtoparYonetimSistemi
{
    public partial class DetailAndUpdate : MetroFramework.Forms.MetroForm
    {
        VtProcess _vtProcess = new VtProcess();
        String _time, _plate;

        CarOperations _carOperations;

        int _repice;
        public DetailAndUpdate()
        {
            InitializeComponent();
        }

        public DetailAndUpdate(CarOperations carOperations)
        {
            carOperations = _carOperations;
            InitializeComponent();
        }

        public async Task Detail(string selecNumber)
        {
            var re = await _vtProcess.ExtractCarProperties(selecNumber);

            _time = re.time;
            _plate = re.plate;
            _repice = re.repice;

            PlateNumberTxt.Text = _plate;
            BrandTxt.Text = re.brand;
            ModelTxt.Text = re.model;
            ColorTxt.Text = re.color;

            TimeTxt.Text = _time;
            StatuTxt.Text = re.statu;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PlateNumberTxt.Enabled = true;
                BrandTxt.Enabled = true;
                ModelTxt.Enabled = true;
                ColorTxt.Enabled = true;
            }
            if (!checkBox1.Checked)
            {
                PlateNumberTxt.Enabled = false;
                BrandTxt.Enabled = false;
                ModelTxt.Enabled = false;
                ColorTxt.Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                DialogResult result = MessageBox.Show("Aktif Kayıt Güncellensin mi?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (DialogResult.Yes == result)
                {
                    _vtProcess.DataUpdate(_plate, PlateNumberTxt.Text.ToString(), BrandTxt.Text.ToString(), ModelTxt.Text.ToString(), ColorTxt.Text.ToString(), _time, _repice, StatuTxt.Text);

                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Güncelleme onayını işaretleyiniz.");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"{_plate.ToUpper()} plakalı araç kaydı silinsin mi?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == result)
            {
                _vtProcess.RemoveRecord(_plate);
                _vtProcess.GetEntranceData(_carOperations.DataGridView1);
                
                this.Hide();
            }
        }
    }
}
