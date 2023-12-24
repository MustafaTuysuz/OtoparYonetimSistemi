using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparYonetimSistemi
{
    internal class FeeCalculation
    {
        VtProcess _vtProcess = new VtProcess();
        

        public async Task<(DateTime Et, TimeSpan Pt, Double p)> HourlyCalvulation(string _selectNumber)
        {
            var re = await _vtProcess.ExtractCarProperties(_selectNumber);

            DateTime Et = DateTime.Now;
            TimeSpan Pt = Et - DateTime.Parse(re.time);

            double p = Pt.TotalHours * re.repice;

            return (Et, Pt, p);
        }

        public async Task<(DateTime Gt, DateTime Et, int d)> WeeklyCalvulation(string _selectNumber)
        {
            var re = await _vtProcess.ExtractCarProperties(_selectNumber);

            
            DateTime Td = DateTime.Now;

            var Gt = DateTime.Parse(re.time);
            DateTime Et = Gt.AddDays(7);

            TimeSpan remainingDays = Et - Td;
            int d = (int)remainingDays.TotalDays;

            return (Gt, Et, d);
        }

        public async Task<(DateTime Gt, DateTime Et, int d)> MonthlyCalvulation(string _selectNumber)
        {
            var re = await _vtProcess.ExtractCarProperties(_selectNumber);

            DateTime Td = DateTime.Now;

            DateTime Gt = DateTime.Parse(re.time);
            DateTime Et = Gt.AddDays(30);

            TimeSpan remainingDays = Et - Td;
            int d = (int)remainingDays.TotalDays;

            return (Gt, Et, d);
        }

    }
}
