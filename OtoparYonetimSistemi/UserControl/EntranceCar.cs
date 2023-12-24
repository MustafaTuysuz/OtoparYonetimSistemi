using System.Diagnostics.Eventing.Reader;

namespace OtoparYonetimSistemi
{
    public partial class EntranceCar : UserControl
    {
        VtProcess _vtProcess = new VtProcess();
        bool IsNullOrEmpty;
        public EntranceCar()
        {
            InitializeComponent();
            EntranceRecordCount();
        }

        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            string plate, brand, model, color, time, statu = String.Empty;

            int result = await RepiceSetCar();

            if (NullOrEmpty("Lütfen tüm alanları dolduru."))
            {
                if (Convert.ToInt16(emptyAreasLbl.Text) <= 0)
                {
                    MessageBox.Show("Otopark da boş alan yok", "Alan Uyarsı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    plate = NumberPlateTxt.Text;
                    brand = BrandTxt.Text;
                    model = ModelTxt.Text;
                    color = ColorTxt.Text;
                    time = DateTime.Now.ToString();

                    if (hourlyRb.Checked)
                    {
                        statu = "Saatlik Abone";
                    }
                    else if (weeklyRb.Checked)
                    {
                        statu = "Haftalık Abone";
                    }
                    else if (monthlyRb.Checked)
                    {
                        statu = "Aylık Abone";
                    }

                    _vtProcess.AddData(plate.ToUpper(), brand.ToUpper(), model.ToUpper(), color.ToUpper(), time, result, statu);

                    TextBoxEmpty();

                    EntranceRecordCount();
                }
            }
        }
        private void TextBoxEmpty()
        {
            NumberPlateTxt.Text = "";
            BrandTxt.Text = "";
            ModelTxt.Text = "";
            ColorTxt.Text = "";
        }
        public async Task EntranceRecordCount()
        {
            try
            {
                int capacity = await _vtProcess.GetParkingCapacity();
                int count = await _vtProcess.GetEntranceCount();

                activeAreasLbl.Text = capacity.ToString();
                occupiedAreasLbl.Text = count.ToString();
                emptyAreasLbl.Text = Convert.ToString(capacity - count);
            }
            catch (Exception ex)
            {
            }
        }

        private bool NullOrEmpty(String message)
        {
            IsNullOrEmpty = false;

            if (String.IsNullOrEmpty(NumberPlateTxt.Text) || String.IsNullOrEmpty(BrandTxt.Text) || String.IsNullOrEmpty(ModelTxt.Text) || String.IsNullOrEmpty(ColorTxt.Text))
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
        public async Task<int> RepiceSetCar()
        {
            var _repice = await _vtProcess.GetRecipeData();
            int repice;

            if (hourlyRb.Checked)
            {
                return repice = _repice.hourly;
                hourlyRb.Checked = false;
            }
            if (monthlyRb.Checked)
            {
                return repice = _repice.monthly;
                monthlyRb.Checked = false;
            }
            if (weeklyRb.Checked)
            {
                return repice = _repice.weekly;
                weeklyRb.Checked = false;

            }
            return 0;

        }
    }
}
