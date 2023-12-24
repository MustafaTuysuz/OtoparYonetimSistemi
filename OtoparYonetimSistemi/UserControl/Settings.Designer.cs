namespace OtoparYonetimSistemi
{
    partial class Settings
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            CloseBtn = new PictureBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            updateBtn = new Button();
            capacityTxt = new TextBox();
            groupBox2 = new GroupBox();
            button2 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            weeklyTxt = new TextBox();
            monthlyTxt = new TextBox();
            hourlyTxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // CloseBtn
            // 
            CloseBtn.Image = (Image)resources.GetObject("CloseBtn.Image");
            CloseBtn.Location = new Point(510, 10);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(20, 20);
            CloseBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseBtn.TabIndex = 0;
            CloseBtn.TabStop = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(17, 393);
            button1.Name = "button1";
            button1.Size = new Size(142, 37);
            button1.TabIndex = 1;
            button1.Text = "Otopark Sıfırla ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(updateBtn);
            groupBox1.Controls.Add(capacityTxt);
            groupBox1.Location = new Point(17, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(119, 82);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Otopark Kapasitesi";
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(10, 51);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(100, 23);
            updateBtn.TabIndex = 1;
            updateBtn.Text = "Güncelle";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // capacityTxt
            // 
            capacityTxt.Location = new Point(10, 22);
            capacityTxt.Name = "capacityTxt";
            capacityTxt.Size = new Size(100, 23);
            capacityTxt.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(monthlyTxt);
            groupBox2.Controls.Add(weeklyTxt);
            groupBox2.Controls.Add(hourlyTxt);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(152, 16);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(144, 140);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tarife Ücretleri";
            // 
            // button2
            // 
            button2.Location = new Point(8, 109);
            button2.Name = "button2";
            button2.Size = new Size(128, 23);
            button2.TabIndex = 3;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(117, 85);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 2;
            label6.Text = "TL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 55);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 2;
            label5.Text = "TL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 26);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 2;
            label4.Text = "TL";
            // 
            // weeklyTxt
            // 
            weeklyTxt.Location = new Point(56, 51);
            weeklyTxt.Name = "weeklyTxt";
            weeklyTxt.Size = new Size(59, 23);
            weeklyTxt.TabIndex = 1;
            // 
            // monthlyTxt
            // 
            monthlyTxt.Location = new Point(56, 80);
            monthlyTxt.Name = "monthlyTxt";
            monthlyTxt.Size = new Size(59, 23);
            monthlyTxt.TabIndex = 1;
            // 
            // hourlyTxt
            // 
            hourlyTxt.Location = new Point(56, 22);
            hourlyTxt.Name = "hourlyTxt";
            hourlyTxt.Size = new Size(59, 23);
            hourlyTxt.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 83);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 0;
            label3.Text = "Aylık";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 54);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 0;
            label2.Text = "Haftalık";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Saatlik ";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(CloseBtn);
            Name = "Settings";
            Size = new Size(539, 456);
            ((System.ComponentModel.ISupportInitialize)CloseBtn).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox CloseBtn;
        private Button button1;
        private GroupBox groupBox1;
        private Button updateBtn;
        private TextBox capacityTxt;
        private GroupBox groupBox2;
        private TextBox weeklyTxt;
        private TextBox monthlyTxt;
        private TextBox hourlyTxt;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label6;
        private Label label5;
        private Button RepiceUpdate;
        private Button button3;
        private Button button2;
    }
}
