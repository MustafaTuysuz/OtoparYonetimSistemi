namespace OtoparYonetimSistemi
{
    partial class DetailAndUpdate
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
            button1 = new Button();
            bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(components);
            label1 = new Label();
            PlateNumberTxt = new TextBox();
            label2 = new Label();
            BrandTxt = new TextBox();
            label3 = new Label();
            ModelTxt = new TextBox();
            label4 = new Label();
            ColorTxt = new TextBox();
            label5 = new Label();
            checkBox1 = new CheckBox();
            StatuTxt = new TextBox();
            label7 = new Label();
            DeleteBtn = new Button();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            TimeTxt = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(23, 286);
            button1.Name = "button1";
            button1.Size = new Size(288, 38);
            button1.TabIndex = 0;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // bunifuElipse2
            // 
            bunifuElipse2.ElipseRadius = 20;
            bunifuElipse2.TargetControl = button1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 84);
            label1.Name = "label1";
            label1.Size = new Size(40, 17);
            label1.TabIndex = 1;
            label1.Text = "Plaka";
            // 
            // PlateNumberTxt
            // 
            PlateNumberTxt.BackColor = SystemColors.Control;
            PlateNumberTxt.Enabled = false;
            PlateNumberTxt.Location = new Point(155, 80);
            PlateNumberTxt.Name = "PlateNumberTxt";
            PlateNumberTxt.Size = new Size(120, 22);
            PlateNumberTxt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 117);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 1;
            label2.Text = "Marka";
            // 
            // BrandTxt
            // 
            BrandTxt.BackColor = SystemColors.Control;
            BrandTxt.Enabled = false;
            BrandTxt.Location = new Point(155, 113);
            BrandTxt.Name = "BrandTxt";
            BrandTxt.Size = new Size(120, 22);
            BrandTxt.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 150);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 1;
            label3.Text = "Model";
            // 
            // ModelTxt
            // 
            ModelTxt.BackColor = SystemColors.Control;
            ModelTxt.Enabled = false;
            ModelTxt.Location = new Point(155, 146);
            ModelTxt.Name = "ModelTxt";
            ModelTxt.Size = new Size(120, 22);
            ModelTxt.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 182);
            label4.Name = "label4";
            label4.Size = new Size(36, 17);
            label4.TabIndex = 1;
            label4.Text = "Renk";
            // 
            // ColorTxt
            // 
            ColorTxt.BackColor = SystemColors.Control;
            ColorTxt.Enabled = false;
            ColorTxt.Location = new Point(155, 179);
            ColorTxt.Name = "ColorTxt";
            ColorTxt.Size = new Size(120, 22);
            ColorTxt.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 215);
            label5.Name = "label5";
            label5.Size = new Size(33, 17);
            label5.TabIndex = 1;
            label5.Text = "Giriş";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.FlatAppearance.BorderSize = 0;
            checkBox1.Location = new Point(23, 330);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(158, 21);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Güncelemeye izin ver ";
            checkBox1.TextAlign = ContentAlignment.MiddleCenter;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // StatuTxt
            // 
            StatuTxt.BackColor = SystemColors.Control;
            StatuTxt.Enabled = false;
            StatuTxt.Location = new Point(155, 245);
            StatuTxt.Name = "StatuTxt";
            StatuTxt.Size = new Size(120, 22);
            StatuTxt.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(71, 248);
            label7.Name = "label7";
            label7.Size = new Size(40, 17);
            label7.TabIndex = 1;
            label7.Text = "Statü";
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Red;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBtn.Location = new Point(233, 329);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 25);
            DeleteBtn.TabIndex = 6;
            DeleteBtn.Text = "Kaydı Sil";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 15;
            bunifuElipse1.TargetControl = DeleteBtn;
            // 
            // TimeTxt
            // 
            TimeTxt.BackColor = SystemColors.Control;
            TimeTxt.Enabled = false;
            TimeTxt.Location = new Point(155, 212);
            TimeTxt.Name = "TimeTxt";
            TimeTxt.Size = new Size(120, 22);
            TimeTxt.TabIndex = 2;
            // 
            // DetailAndUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 255);
            ClientSize = new Size(334, 366);
            Controls.Add(DeleteBtn);
            Controls.Add(StatuTxt);
            Controls.Add(checkBox1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(TimeTxt);
            Controls.Add(ColorTxt);
            Controls.Add(label4);
            Controls.Add(ModelTxt);
            Controls.Add(label3);
            Controls.Add(BrandTxt);
            Controls.Add(label2);
            Controls.Add(PlateNumberTxt);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "DetailAndUpdate";
            Text = "Araç Detayları";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Button button1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Label label5;
        private TextBox ColorTxt;
        private Label label4;
        private TextBox ModelTxt;
        private Label label3;
        private TextBox BrandTxt;
        private Label label2;
        private TextBox PlateNumberTxt;
        private Label label1;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox1;
        private TextBox Numbe;
        private CheckBox checkBox1;
        private TextBox textBox2;
        private Label label7;
        private Label label8;
        private TextBox StatuTxt;
        private Button DeleteBtn;
        private TextBox TimeTxt;
    }
}