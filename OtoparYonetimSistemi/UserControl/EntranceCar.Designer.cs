namespace OtoparYonetimSistemi
{
    partial class EntranceCar
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
            renkLBL = new Label();
            modelLBL = new Label();
            markaLBL = new Label();
            ColorTxt = new TextBox();
            ModelTxt = new TextBox();
            BrandTxt = new TextBox();
            plakaLBL = new Label();
            NumberPlateTxt = new TextBox();
            occupiedAreasLbl = new Label();
            emptyAreasLbl = new Label();
            activeAreasLbl = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            SaveBtn = new Button();
            groupBox2 = new GroupBox();
            weeklyRb = new RadioButton();
            monthlyRb = new RadioButton();
            hourlyRb = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // renkLBL
            // 
            renkLBL.AutoSize = true;
            renkLBL.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            renkLBL.Location = new Point(260, 66);
            renkLBL.Name = "renkLBL";
            renkLBL.Size = new Size(36, 17);
            renkLBL.TabIndex = 3;
            renkLBL.Text = "Renk";
            // 
            // modelLBL
            // 
            modelLBL.AutoSize = true;
            modelLBL.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            modelLBL.Location = new Point(260, 36);
            modelLBL.Name = "modelLBL";
            modelLBL.Size = new Size(46, 17);
            modelLBL.TabIndex = 3;
            modelLBL.Text = "Model";
            // 
            // markaLBL
            // 
            markaLBL.AutoSize = true;
            markaLBL.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            markaLBL.Location = new Point(6, 66);
            markaLBL.Name = "markaLBL";
            markaLBL.Size = new Size(45, 17);
            markaLBL.TabIndex = 3;
            markaLBL.Text = "Marka";
            // 
            // ColorTxt
            // 
            ColorTxt.Location = new Point(329, 63);
            ColorTxt.Name = "ColorTxt";
            ColorTxt.Size = new Size(132, 24);
            ColorTxt.TabIndex = 4;
            // 
            // ModelTxt
            // 
            ModelTxt.Location = new Point(329, 33);
            ModelTxt.Name = "ModelTxt";
            ModelTxt.Size = new Size(132, 24);
            ModelTxt.TabIndex = 3;
            // 
            // BrandTxt
            // 
            BrandTxt.Location = new Point(75, 63);
            BrandTxt.Name = "BrandTxt";
            BrandTxt.Size = new Size(132, 24);
            BrandTxt.TabIndex = 2;
            // 
            // plakaLBL
            // 
            plakaLBL.AutoSize = true;
            plakaLBL.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            plakaLBL.Location = new Point(6, 36);
            plakaLBL.Name = "plakaLBL";
            plakaLBL.Size = new Size(40, 17);
            plakaLBL.TabIndex = 1;
            plakaLBL.Text = "Plaka";
            // 
            // NumberPlateTxt
            // 
            NumberPlateTxt.Location = new Point(75, 33);
            NumberPlateTxt.Name = "NumberPlateTxt";
            NumberPlateTxt.Size = new Size(132, 24);
            NumberPlateTxt.TabIndex = 1;
            // 
            // occupiedAreasLbl
            // 
            occupiedAreasLbl.AutoSize = true;
            occupiedAreasLbl.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            occupiedAreasLbl.Location = new Point(483, 423);
            occupiedAreasLbl.Name = "occupiedAreasLbl";
            occupiedAreasLbl.Size = new Size(32, 17);
            occupiedAreasLbl.TabIndex = 9;
            occupiedAreasLbl.Text = "------";
            // 
            // emptyAreasLbl
            // 
            emptyAreasLbl.AutoSize = true;
            emptyAreasLbl.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            emptyAreasLbl.Location = new Point(296, 423);
            emptyAreasLbl.Name = "emptyAreasLbl";
            emptyAreasLbl.Size = new Size(32, 17);
            emptyAreasLbl.TabIndex = 9;
            emptyAreasLbl.Text = "------";
            // 
            // activeAreasLbl
            // 
            activeAreasLbl.AutoSize = true;
            activeAreasLbl.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            activeAreasLbl.Location = new Point(145, 423);
            activeAreasLbl.Name = "activeAreasLbl";
            activeAreasLbl.Size = new Size(32, 17);
            activeAreasLbl.TabIndex = 8;
            activeAreasLbl.Text = "------";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(394, 423);
            label6.Name = "label6";
            label6.Size = new Size(83, 17);
            label6.TabIndex = 6;
            label6.Text = "Dolu Alanlar:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(214, 423);
            label7.Name = "label7";
            label7.Size = new Size(76, 17);
            label7.TabIndex = 7;
            label7.Text = "Boş Alanlar:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(16, 423);
            label8.Name = "label8";
            label8.Size = new Size(123, 17);
            label8.TabIndex = 4;
            label8.Text = "Otopark Kapasitesi:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(renkLBL);
            groupBox1.Controls.Add(modelLBL);
            groupBox1.Controls.Add(markaLBL);
            groupBox1.Controls.Add(ColorTxt);
            groupBox1.Controls.Add(ModelTxt);
            groupBox1.Controls.Add(BrandTxt);
            groupBox1.Controls.Add(plakaLBL);
            groupBox1.Controls.Add(NumberPlateTxt);
            groupBox1.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(20, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(499, 147);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Araç Girişi";
            // 
            // SaveBtn
            // 
            SaveBtn.FlatAppearance.BorderSize = 0;
            SaveBtn.Location = new Point(291, 194);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(228, 33);
            SaveBtn.TabIndex = 6;
            SaveBtn.Text = "Kaydet";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(weeklyRb);
            groupBox2.Controls.Add(monthlyRb);
            groupBox2.Controls.Add(hourlyRb);
            groupBox2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(20, 175);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(252, 68);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tarife";
            // 
            // weeklyRb
            // 
            weeklyRb.AutoSize = true;
            weeklyRb.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            weeklyRb.Location = new Point(94, 31);
            weeklyRb.Name = "weeklyRb";
            weeklyRb.Size = new Size(75, 21);
            weeklyRb.TabIndex = 0;
            weeklyRb.TabStop = true;
            weeklyRb.Text = "Haftalık";
            weeklyRb.TextAlign = ContentAlignment.MiddleCenter;
            weeklyRb.UseVisualStyleBackColor = true;
            // 
            // monthlyRb
            // 
            monthlyRb.AutoSize = true;
            monthlyRb.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            monthlyRb.Location = new Point(192, 31);
            monthlyRb.Name = "monthlyRb";
            monthlyRb.Size = new Size(54, 21);
            monthlyRb.TabIndex = 0;
            monthlyRb.TabStop = true;
            monthlyRb.Text = "Aylık";
            monthlyRb.UseVisualStyleBackColor = true;
            // 
            // hourlyRb
            // 
            hourlyRb.AutoSize = true;
            hourlyRb.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            hourlyRb.Location = new Point(6, 31);
            hourlyRb.Name = "hourlyRb";
            hourlyRb.Size = new Size(68, 21);
            hourlyRb.TabIndex = 0;
            hourlyRb.TabStop = true;
            hourlyRb.Text = "Saatlik";
            hourlyRb.UseVisualStyleBackColor = true;
            // 
            // EntranceCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SaveBtn);
            Controls.Add(groupBox2);
            Controls.Add(occupiedAreasLbl);
            Controls.Add(label6);
            Controls.Add(emptyAreasLbl);
            Controls.Add(activeAreasLbl);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Name = "EntranceCar";
            Size = new Size(539, 444);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SaveBtn;
        private TextBox ColorTxt;
        private TextBox ModelTxt;
        private TextBox BrandTxt;
        private TextBox NumberPlateTxt;
        private Label renkLBL;
        private Label modelLBL;
        private Label markaLBL;
        private Label plakaLBL;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label occupiedAreasLbl;
        private Label emptyAreasLbl;
        private Label activeAreasLbl;
        private Label label1;
        private GroupBox groupBox1;
        private Button button1;
        private GroupBox groupBox2;
        private RadioButton weeklyRb;
        private RadioButton monthlyRb;
        private RadioButton hourlyRb;
    }
}
