using System.Speech.Synthesis.TtsEngine;

namespace OtoparYonetimSistemi
{
    public partial class CarOperations : UserControl
    {
        VtProcess _vtProcess = new VtProcess();
        DetailAndUpdate _detailAndUpdate;
        subExitCar _subExitCar;
        ExitCar _exitCar;

        bool IsNullOrEmpty;
        public CarOperations()
        {
            InitializeComponent();
            _vtProcess.GetEntranceData(dataGridView1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _vtProcess.GetEntranceData(dataGridView1);

            NumberPlateTxt.Text = "";
            BrandTxt.Text = "";
            ModelTxt.Text = "";
            ColorTxt.Text = "";
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string plate, brand, model, color;

            if (NullOrEmpty("Sorgulanacak Özellik yok"))
            {
                plate = NumberPlateTxt.Text.ToUpper();
                brand = BrandTxt.Text.ToUpper();
                model = ModelTxt.Text.ToUpper();
                color = ColorTxt.Text.ToUpper();

                _vtProcess.Search(dataGridView1, plate, brand, model, color);
            }
        }

        public DataGridView DataGridView1 { get { return dataGridView1; } set { dataGridView1 = value; } }

        private bool NullOrEmpty(String message)
        {
            IsNullOrEmpty = false;
            if (String.IsNullOrEmpty(NumberPlateTxt.Text) && String.IsNullOrEmpty(BrandTxt.Text) && String.IsNullOrEmpty(ModelTxt.Text) && String.IsNullOrEmpty(ColorTxt.Text))
            {
                IsNullOrEmpty = false;
                MessageBox.Show(message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IsNullOrEmpty = true;
            }
            return IsNullOrEmpty;
        }

        public async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectNumber = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            if (e.ColumnIndex == 0)
            {
                var re = await _vtProcess.ExtractCarProperties(selectNumber);

                if (re.statu == "Haftalık Abone")
                {
                    _subExitCar = new subExitCar();
                    _subExitCar.weeklySub(selectNumber);
                    _subExitCar.Show();
                }
                else if (re.statu == "Aylık Abone")
                {
                    _subExitCar = new subExitCar();
                    _subExitCar.monthlySub(selectNumber);
                    _subExitCar.Show();
                }
                else
                {
                    _exitCar = new ExitCar(selectNumber);
                    _exitCar.Show();
                }

            }
            if (e.ColumnIndex == 1)
            {
                _detailAndUpdate = new DetailAndUpdate(this);
                _detailAndUpdate.Detail(selectNumber);
                _detailAndUpdate.Show();
            }
        }
    }
}
