namespace OtoparYonetimSistemi
{
    partial class ExitCar
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
            PlateNo = new Label();
            label1 = new Label();
            label2 = new Label();
            pay = new Label();
            label4 = new Label();
            ExitTime = new Label();
            EntranceTime = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // PlateNo
            // 
            PlateNo.AutoSize = true;
            PlateNo.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            PlateNo.Location = new Point(110, 102);
            PlateNo.Name = "PlateNo";
            PlateNo.Size = new Size(113, 32);
            PlateNo.TabIndex = 0;
            PlateNo.Text = "---------";
            PlateNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 180);
            label1.Name = "label1";
            label1.Size = new Size(73, 17);
            label1.TabIndex = 1;
            label1.Text = "Giriş Saati :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 214);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 1;
            label2.Text = "Çıkış Saati :";
            // 
            // pay
            // 
            pay.AutoSize = true;
            pay.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pay.Location = new Point(131, 277);
            pay.Name = "pay";
            pay.Size = new Size(72, 19);
            pay.TabIndex = 0;
            pay.Text = "---------";
            pay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 279);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 1;
            label4.Text = "Tutar :";
            // 
            // ExitTime
            // 
            ExitTime.AutoSize = true;
            ExitTime.Location = new Point(131, 214);
            ExitTime.Name = "ExitTime";
            ExitTime.Size = new Size(40, 17);
            ExitTime.TabIndex = 1;
            ExitTime.Text = "--------";
            // 
            // EntranceTime
            // 
            EntranceTime.AutoSize = true;
            EntranceTime.Location = new Point(131, 180);
            EntranceTime.Name = "EntranceTime";
            EntranceTime.Size = new Size(40, 17);
            EntranceTime.TabIndex = 1;
            EntranceTime.Text = "--------";
            // 
            // button1
            // 
            button1.Location = new Point(23, 338);
            button1.Name = "button1";
            button1.Size = new Size(209, 40);
            button1.TabIndex = 2;
            button1.Text = "Ödme Al";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(238, 338);
            button2.Name = "button2";
            button2.Size = new Size(81, 40);
            button2.TabIndex = 2;
            button2.Text = "Kapat";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ExitCar
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
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
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ExitCar";
            Padding = new Padding(20, 68, 20, 23);
            Text = "Ödeme Sayfası";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PlateNo;
        private Label label1;
        private Label label2;
        private Label pay;
        private Label label4;
        private Label ExitTime;
        private Label EntranceTime;
        private Label PayTime;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}