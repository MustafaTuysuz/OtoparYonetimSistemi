using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparYonetimSistemi
{

    public partial class subExitCar : MetroFramework.Forms.MetroForm
    {
        FeeCalculation _feeCalculation = new FeeCalculation();
        VtProcess _vtProcess = new VtProcess();
        string _select;

        public subExitCar()
        {
            InitializeComponent();
        }
        public async void weeklySub(string select)
        {
            var re = await _feeCalculation.WeeklyCalvulation(select);
            var H = await _vtProcess.ExtractCarProperties(select);

            PlateNo.Text = H.plate;

            EntranceTime.Text = re.Gt.ToString();
            ExitTime.Text = re.Et.ToString();

            pay.Text = re.d.ToString();

            if (re.d == 0)
            {
                button1.Enabled = true;
            }

        }

        public async void monthlySub(string select)
        {
            var re = await _feeCalculation.MonthlyCalvulation(select);
            var H = await _vtProcess.ExtractCarProperties(select);

            PlateNo.Text = H.plate;

            EntranceTime.Text = re.Gt.ToString();
            ExitTime.Text = re.Et.ToString();

            pay.Text = re.d.ToString();

            if (re.d == 0)
            {
                button1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
