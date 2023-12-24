namespace OtoparYonetimSistemi
{
    partial class CarOperations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarOperations));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            renkLBL = new Label();
            modelLBL = new Label();
            markaLBL = new Label();
            ColorTxt = new TextBox();
            ModelTxt = new TextBox();
            BrandTxt = new TextBox();
            plakaLBL = new Label();
            NumberPlateTxt = new TextBox();
            searchBtn = new Button();
            dataGridView1 = new DataGridView();
            exitCar = new DataGridViewImageColumn();
            detail = new DataGridViewImageColumn();
            numberPlate = new DataGridViewTextBoxColumn();
            time = new DataGridViewTextBoxColumn();
            brand = new DataGridViewTextBoxColumn();
            model = new DataGridViewTextBoxColumn();
            color = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(493, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
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
            groupBox1.Size = new Size(499, 101);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Araç Bilgileri";
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
            // searchBtn
            // 
            searchBtn.Location = new Point(20, 133);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(152, 30);
            searchBtn.TabIndex = 6;
            searchBtn.Text = "Sorgula";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { exitCar, detail, numberPlate, time, brand, model, color });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = SystemColors.ActiveBorder;
            dataGridView1.Location = new Point(20, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 60;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(499, 262);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // exitCar
            // 
            exitCar.FillWeight = 106.598991F;
            exitCar.HeaderText = "Ödeme Al";
            exitCar.Image = (Image)resources.GetObject("exitCar.Image");
            exitCar.Name = "exitCar";
            exitCar.ReadOnly = true;
            // 
            // detail
            // 
            detail.FillWeight = 83.62603F;
            detail.HeaderText = "Detay";
            detail.Image = (Image)resources.GetObject("detail.Image");
            detail.Name = "detail";
            detail.ReadOnly = true;
            detail.Resizable = DataGridViewTriState.True;
            detail.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // numberPlate
            // 
            numberPlate.DataPropertyName = "numberPlate";
            numberPlate.FillWeight = 83.62603F;
            numberPlate.HeaderText = "Plaka";
            numberPlate.Name = "numberPlate";
            numberPlate.ReadOnly = true;
            // 
            // time
            // 
            time.DataPropertyName = "time";
            time.FillWeight = 175.27095F;
            time.HeaderText = "Giriş Saati";
            time.Name = "time";
            time.ReadOnly = true;
            // 
            // brand
            // 
            brand.DataPropertyName = "brand";
            brand.FillWeight = 83.62603F;
            brand.HeaderText = "Marka";
            brand.Name = "brand";
            brand.ReadOnly = true;
            // 
            // model
            // 
            model.DataPropertyName = "model";
            model.FillWeight = 83.62603F;
            model.HeaderText = "Model";
            model.Name = "model";
            model.ReadOnly = true;
            // 
            // color
            // 
            color.DataPropertyName = "color";
            color.FillWeight = 83.62603F;
            color.HeaderText = "Renk";
            color.Name = "color";
            color.ReadOnly = true;
            // 
            // CarOperations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(searchBtn);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "CarOperations";
            Size = new Size(539, 444);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button searchBtn;
        private Label renkLBL;
        private Label modelLBL;
        private Label markaLBL;
        private TextBox ColorTxt;
        private TextBox ModelTxt;
        private TextBox BrandTxt;
        private Label plakaLBL;
        private TextBox NumberPlateTxt;
        private DataGridView dataGridView1;
        private DataGridViewImageColumn exitCar;
        private DataGridViewImageColumn detail;
        private DataGridViewTextBoxColumn numberPlate;
        private DataGridViewTextBoxColumn time;
        private DataGridViewTextBoxColumn brand;
        private DataGridViewTextBoxColumn model;
        private DataGridViewTextBoxColumn color;
    }
}
