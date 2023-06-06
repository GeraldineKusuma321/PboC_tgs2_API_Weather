namespace PBO_pr_API_Weather_Geraldine_H.K_222410103008
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pic_Cuaca = new PictureBox();
            txtBoxKota = new TextBox();
            label1 = new Label();
            label2 = new Label();
            labelkondisi = new Label();
            labelSR = new Label();
            labeldetail = new Label();
            labelWS = new Label();
            labelPr = new Label();
            labelSS = new Label();
            labelsunrise = new Label();
            labelsunset = new Label();
            labelpressure = new Label();
            labelwindspeed = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_Cuaca).BeginInit();
            SuspendLayout();
            // 
            // pic_Cuaca
            // 
            pic_Cuaca.BackColor = Color.Transparent;
            pic_Cuaca.Location = new Point(279, 113);
            pic_Cuaca.Name = "pic_Cuaca";
            pic_Cuaca.Size = new Size(162, 93);
            pic_Cuaca.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Cuaca.TabIndex = 15;
            pic_Cuaca.TabStop = false;
            // 
            // txtBoxKota
            // 
            txtBoxKota.Location = new Point(233, 80);
            txtBoxKota.Name = "txtBoxKota";
            txtBoxKota.Size = new Size(277, 27);
            txtBoxKota.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(146, 76);
            label1.Name = "label1";
            label1.Size = new Size(70, 34);
            label1.TabIndex = 3;
            label1.Text = "KOTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(530, 83);
            label2.Name = "label2";
            label2.Size = new Size(52, 22);
            label2.TabIndex = 4;
            label2.Text = "CARI";
            label2.Click += label2_Click;
            // 
            // labelkondisi
            // 
            labelkondisi.AutoSize = true;
            labelkondisi.BackColor = Color.Transparent;
            labelkondisi.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelkondisi.Location = new Point(176, 224);
            labelkondisi.Name = "labelkondisi";
            labelkondisi.Size = new Size(70, 22);
            labelkondisi.TabIndex = 8;
            labelkondisi.Text = "KONDISI:";
            // 
            // labelSR
            // 
            labelSR.AutoSize = true;
            labelSR.BackColor = Color.Transparent;
            labelSR.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelSR.Location = new Point(176, 344);
            labelSR.Name = "labelSR";
            labelSR.Size = new Size(79, 22);
            labelSR.TabIndex = 10;
            labelSR.Text = "SUNRISE: ";
            // 
            // labeldetail
            // 
            labeldetail.AutoSize = true;
            labeldetail.BackColor = Color.Transparent;
            labeldetail.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labeldetail.Location = new Point(176, 285);
            labeldetail.Name = "labeldetail";
            labeldetail.Size = new Size(62, 22);
            labeldetail.TabIndex = 11;
            labeldetail.Text = "DETAIL:";
            // 
            // labelWS
            // 
            labelWS.AutoSize = true;
            labelWS.BackColor = Color.Transparent;
            labelWS.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelWS.Location = new Point(416, 220);
            labelWS.Name = "labelWS";
            labelWS.Size = new Size(105, 22);
            labelWS.TabIndex = 12;
            labelWS.Text = "WIND SPEED: ";
            // 
            // labelPr
            // 
            labelPr.AutoSize = true;
            labelPr.BackColor = Color.Transparent;
            labelPr.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelPr.Location = new Point(416, 285);
            labelPr.Name = "labelPr";
            labelPr.Size = new Size(94, 22);
            labelPr.TabIndex = 13;
            labelPr.Text = "PRESSURE: ";
            // 
            // labelSS
            // 
            labelSS.AutoSize = true;
            labelSS.BackColor = Color.Transparent;
            labelSS.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelSS.Location = new Point(176, 396);
            labelSS.Name = "labelSS";
            labelSS.Size = new Size(71, 22);
            labelSS.TabIndex = 14;
            labelSS.Text = "SUNSET: ";
            // 
            // labelsunrise
            // 
            labelsunrise.AutoSize = true;
            labelsunrise.BackColor = Color.Transparent;
            labelsunrise.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelsunrise.Location = new Point(248, 344);
            labelsunrise.Name = "labelsunrise";
            labelsunrise.Size = new Size(36, 22);
            labelsunrise.TabIndex = 16;
            labelsunrise.Text = "N/A";
            // 
            // labelsunset
            // 
            labelsunset.AutoSize = true;
            labelsunset.BackColor = Color.Transparent;
            labelsunset.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelsunset.Location = new Point(245, 396);
            labelsunset.Name = "labelsunset";
            labelsunset.Size = new Size(36, 22);
            labelsunset.TabIndex = 17;
            labelsunset.Text = "N/A";
            // 
            // labelpressure
            // 
            labelpressure.AutoSize = true;
            labelpressure.BackColor = Color.Transparent;
            labelpressure.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelpressure.Location = new Point(504, 285);
            labelpressure.Name = "labelpressure";
            labelpressure.Size = new Size(36, 22);
            labelpressure.TabIndex = 18;
            labelpressure.Text = "N/A";
            // 
            // labelwindspeed
            // 
            labelwindspeed.AutoSize = true;
            labelwindspeed.BackColor = Color.Transparent;
            labelwindspeed.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelwindspeed.Location = new Point(517, 220);
            labelwindspeed.Name = "labelwindspeed";
            labelwindspeed.Size = new Size(36, 22);
            labelwindspeed.TabIndex = 19;
            labelwindspeed.Text = "N/A";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(labelwindspeed);
            Controls.Add(labelpressure);
            Controls.Add(labelsunset);
            Controls.Add(labelsunrise);
            Controls.Add(labelSS);
            Controls.Add(labelPr);
            Controls.Add(labelWS);
            Controls.Add(labeldetail);
            Controls.Add(labelSR);
            Controls.Add(labelkondisi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoxKota);
            Controls.Add(pic_Cuaca);
            Name = "Form1";
            Text = "WEATHER";
            ((System.ComponentModel.ISupportInitialize)pic_Cuaca).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_Cuaca;
        private TextBox txtBoxKota;
        private Label label1;
        private Label label2;
        private Label labelkondisi;
        private Label labelSR;
        private Label labeldetail;
        private Label labelWS;
        private Label labelPr;
        private Label labelSS;
        private Label labelsunrise;
        private Label labelsunset;
        private Label labelpressure;
        private Label labelwindspeed;
    }
}