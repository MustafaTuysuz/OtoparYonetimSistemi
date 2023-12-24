namespace OtoparYonetimSistemi
{
    partial class subExitCar
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
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label2 = new Label();
            EntranceTime = new Label();
            ExitTime = new Label();
            label1 = new Label();
            pay = new Label();
            PlateNo = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(236, 336);
            button2.Name = "button2";
            button2.Size = new Size(81, 40);
            button2.TabIndex = 10;
            button2.Text = "Kapat";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(21, 336);
            button1.Name = "button1";
            button1.Size = new Size(209, 40);
            button1.TabIndex = 11;
            button1.Text = "Ödme Al";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 277);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 5;
            label4.Text = "Kalan Gün :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 212);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 6;
            label2.Text = "Çıkış Saati :";
            // 
            // EntranceTime
            // 
            EntranceTime.AutoSize = true;
            EntranceTime.Location = new Point(129, 178);
            EntranceTime.Name = "EntranceTime";
            EntranceTime.Size = new Size(47, 15);
            EntranceTime.TabIndex = 7;
            EntranceTime.Text = "--------";
            // 
            // ExitTime
            // 
            ExitTime.AutoSize = true;
            ExitTime.Location = new Point(129, 212);
            ExitTime.Name = "ExitTime";
            ExitTime.Size = new Size(47, 15);
            ExitTime.TabIndex = 8;
            ExitTime.Text = "--------";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 178);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 9;
            label1.Text = "Giriş Saati :";
            // 
            // pay
            // 
            pay.AutoSize = true;
            pay.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pay.Location = new Point(129, 275);
            pay.Name = "pay";
            pay.Size = new Size(72, 19);
            pay.TabIndex = 3;
            pay.Text = "---------";
            pay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PlateNo
            // 
            PlateNo.AutoSize = true;
            PlateNo.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            PlateNo.Location = new Point(108, 100);
            PlateNo.Name = "PlateNo";
            PlateNo.Size = new Size(113, 32);
            PlateNo.TabIndex = 4;
            PlateNo.Text = "---------";
            PlateNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // subExitCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 391);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(EntranceTime);
            Controls.Add(ExitTime);
            Controls.Add(label1);
            Controls.Add(pay);
            Controls.Add(PlateNo);
            Name = "subExitCar";
            Text = "Ödeme Sayfası";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label4;
        private Label label2;
        private Label EntranceTime;
        private Label ExitTime;
        private Label label1;
        private Label pay;
        private Label PlateNo;
    }
}