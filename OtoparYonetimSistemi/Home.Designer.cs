namespace OtoparYonetimSistemi
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panel1 = new Panel();
            SidePanel = new Panel();
            systemBtn = new Button();
            carOperations = new Button();
            entranceBtn = new Button();
            DashBoard = new Button();
            entranceAndExit1 = new EntranceCar();
            subscription1 = new Subscription();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            carOperations1 = new CarOperations();
            dashBoard1 = new DashBoard();
            settings1 = new Settings();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(SidePanel);
            panel1.Controls.Add(systemBtn);
            panel1.Controls.Add(carOperations);
            panel1.Controls.Add(entranceBtn);
            panel1.Controls.Add(DashBoard);
            panel1.Location = new Point(-8, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(196, 456);
            panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = SystemColors.Window;
            SidePanel.Location = new Point(8, 55);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(10, 38);
            SidePanel.TabIndex = 1;
            // 
            // systemBtn
            // 
            systemBtn.BackColor = SystemColors.Highlight;
            systemBtn.FlatAppearance.BorderSize = 0;
            systemBtn.FlatStyle = FlatStyle.Flat;
            systemBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            systemBtn.ForeColor = Color.White;
            systemBtn.Image = (Image)resources.GetObject("systemBtn.Image");
            systemBtn.ImageAlign = ContentAlignment.MiddleRight;
            systemBtn.Location = new Point(19, 400);
            systemBtn.Name = "systemBtn";
            systemBtn.Size = new Size(176, 38);
            systemBtn.TabIndex = 0;
            systemBtn.Text = "               Ayarlar";
            systemBtn.TextAlign = ContentAlignment.MiddleRight;
            systemBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            systemBtn.UseVisualStyleBackColor = false;
            systemBtn.Click += systemBtn_Click;
            // 
            // carOperations
            // 
            carOperations.BackColor = SystemColors.Highlight;
            carOperations.FlatAppearance.BorderSize = 0;
            carOperations.FlatStyle = FlatStyle.Flat;
            carOperations.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            carOperations.ForeColor = Color.White;
            carOperations.Image = (Image)resources.GetObject("carOperations.Image");
            carOperations.ImageAlign = ContentAlignment.MiddleRight;
            carOperations.Location = new Point(19, 143);
            carOperations.Name = "carOperations";
            carOperations.Size = new Size(176, 38);
            carOperations.TabIndex = 0;
            carOperations.Text = "   Araç İşlemleri";
            carOperations.TextAlign = ContentAlignment.MiddleRight;
            carOperations.TextImageRelation = TextImageRelation.ImageBeforeText;
            carOperations.UseVisualStyleBackColor = false;
            carOperations.Click += carOperations_Click;
            // 
            // entranceBtn
            // 
            entranceBtn.BackColor = SystemColors.Highlight;
            entranceBtn.FlatAppearance.BorderSize = 0;
            entranceBtn.FlatStyle = FlatStyle.Flat;
            entranceBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            entranceBtn.ForeColor = Color.White;
            entranceBtn.Image = (Image)resources.GetObject("entranceBtn.Image");
            entranceBtn.ImageAlign = ContentAlignment.MiddleRight;
            entranceBtn.Location = new Point(19, 99);
            entranceBtn.Name = "entranceBtn";
            entranceBtn.Size = new Size(176, 38);
            entranceBtn.TabIndex = 0;
            entranceBtn.Text = "         Araç Girişi ";
            entranceBtn.TextAlign = ContentAlignment.MiddleRight;
            entranceBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            entranceBtn.UseVisualStyleBackColor = false;
            entranceBtn.Click += entranceBtn_Click;
            // 
            // DashBoard
            // 
            DashBoard.BackColor = SystemColors.Highlight;
            DashBoard.FlatAppearance.BorderSize = 0;
            DashBoard.FlatStyle = FlatStyle.Flat;
            DashBoard.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DashBoard.ForeColor = Color.White;
            DashBoard.Image = (Image)resources.GetObject("DashBoard.Image");
            DashBoard.ImageAlign = ContentAlignment.MiddleRight;
            DashBoard.Location = new Point(19, 55);
            DashBoard.Name = "DashBoard";
            DashBoard.Size = new Size(176, 38);
            DashBoard.TabIndex = 0;
            DashBoard.Text = "        DashBoard";
            DashBoard.TextAlign = ContentAlignment.MiddleRight;
            DashBoard.TextImageRelation = TextImageRelation.ImageBeforeText;
            DashBoard.UseVisualStyleBackColor = false;
            DashBoard.Click += DashBoard_Click;
            // 
            // entranceAndExit1
            // 
            entranceAndExit1.Location = new Point(191, -3);
            entranceAndExit1.Name = "entranceAndExit1";
            entranceAndExit1.Size = new Size(539, 456);
            entranceAndExit1.TabIndex = 3;
            // 
            // subscription1
            // 
            subscription1.Location = new Point(191, -3);
            subscription1.Name = "subscription1";
            subscription1.Size = new Size(539, 456);
            subscription1.TabIndex = 3;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 20;
            bunifuElipse1.TargetControl = this;
            // 
            // carOperations1
            // 
            carOperations1.Location = new Point(191, 0);
            carOperations1.Name = "carOperations1";
            carOperations1.Size = new Size(539, 453);
            carOperations1.TabIndex = 2;
            // 
            // dashBoard1
            // 
            dashBoard1.Location = new Point(191, 0);
            dashBoard1.Name = "dashBoard1";
            dashBoard1.Size = new Size(539, 453);
            dashBoard1.TabIndex = 2;
            // 
            // settings1
            // 
            settings1.Location = new Point(191, 0);
            settings1.Name = "settings1";
            settings1.Size = new Size(539, 456);
            settings1.TabIndex = 2;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 450);
            Controls.Add(settings1);
            Controls.Add(dashBoard1);
            Controls.Add(carOperations1);
            Controls.Add(subscription1);
            Controls.Add(entranceAndExit1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Otopark Yönetim Sistemi";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button DashBoard;
        private Button systemBtn;
        private Panel SidePanel;
        private Subscription subscription1;
        private EntranceCar entranceAndExit1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Button carOperations;
        private Button entranceBtn;
        private DashBoard dashBoard1;
        private CarOperations carOperations1;
        private Settings settings1;
    }
}