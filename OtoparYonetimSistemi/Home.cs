using System.Windows.Forms;

namespace OtoparYonetimSistemi
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            selectMenü(DashBoard.Height, DashBoard.Top, dashBoard1);
        }
        private void entranceBtn_Click(object sender, EventArgs e)
        {
            selectMenü(entranceBtn.Height, entranceBtn.Top, entranceAndExit1);
        }
        private void systemBtn_Click(object sender, EventArgs e)
        {
            selectMenü(systemBtn.Height, systemBtn.Top, settings1);
        }
        private void DashBoard_Click(object sender, EventArgs e)
        {
            selectMenü(DashBoard.Height, DashBoard.Top, dashBoard1);
        }
        private void carOperations_Click(object sender, EventArgs e)
        {
            selectMenü(carOperations.Height, carOperations.Top, carOperations1);
        }
        private void selectMenü(int height, int top, UserControl userForm)
        {
            SidePanel.Height = height;
            SidePanel.Top = top;
            userForm.BringToFront();
        }
    }
}

