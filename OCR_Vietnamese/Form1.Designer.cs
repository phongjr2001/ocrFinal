namespace OCR_Vietnamese
{
    partial class Brightness
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Brightness));
            this.btn_choose = new System.Windows.Forms.Button();
            this.btn_ocr = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.picloading = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_takephoto = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_saveresult = new System.Windows.Forms.Button();
            this.crop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.adjust = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lbBrightness = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picloading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_choose
            // 
            this.btn_choose.Location = new System.Drawing.Point(495, 54);
            this.btn_choose.Margin = new System.Windows.Forms.Padding(4);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(119, 28);
            this.btn_choose.TabIndex = 1;
            this.btn_choose.Text = "Choose Image";
            this.btn_choose.UseVisualStyleBackColor = true;
            this.btn_choose.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ocr
            // 
            this.btn_ocr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ocr.ForeColor = System.Drawing.Color.Red;
            this.btn_ocr.Location = new System.Drawing.Point(637, 313);
            this.btn_ocr.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ocr.Name = "btn_ocr";
            this.btn_ocr.Size = new System.Drawing.Size(123, 110);
            this.btn_ocr.TabIndex = 2;
            this.btn_ocr.Text = "OCR";
            this.btn_ocr.UseVisualStyleBackColor = true;
            this.btn_ocr.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.richTextBox1.Location = new System.Drawing.Point(787, 90);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(647, 574);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(783, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result";
            // 
            // picloading
            // 
            this.picloading.Image = global::OCR_Vietnamese.Properties.Resources.loading;
            this.picloading.Location = new System.Drawing.Point(1040, 283);
            this.picloading.Margin = new System.Windows.Forms.Padding(4);
            this.picloading.Name = "picloading";
            this.picloading.Size = new System.Drawing.Size(143, 130);
            this.picloading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picloading.TabIndex = 7;
            this.picloading.TabStop = false;
            this.picloading.Visible = false;
            this.picloading.Click += new System.EventHandler(this.picloading_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(16, 54);
            this.btn_start.Margin = new System.Windows.Forms.Padding(4);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(100, 28);
            this.btn_start.TabIndex = 8;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_takephoto
            // 
            this.btn_takephoto.Location = new System.Drawing.Point(279, 54);
            this.btn_takephoto.Margin = new System.Windows.Forms.Padding(4);
            this.btn_takephoto.Name = "btn_takephoto";
            this.btn_takephoto.Size = new System.Drawing.Size(100, 28);
            this.btn_takephoto.TabIndex = 9;
            this.btn_takephoto.Text = "Take photo";
            this.btn_takephoto.UseVisualStyleBackColor = true;
            this.btn_takephoto.Click += new System.EventHandler(this.btn_takephoto_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(387, 54);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 28);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 54);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "ImageName|*.png";
            // 
            // btn_saveresult
            // 
            this.btn_saveresult.Location = new System.Drawing.Point(1335, 54);
            this.btn_saveresult.Margin = new System.Windows.Forms.Padding(4);
            this.btn_saveresult.Name = "btn_saveresult";
            this.btn_saveresult.Size = new System.Drawing.Size(100, 28);
            this.btn_saveresult.TabIndex = 12;
            this.btn_saveresult.Text = "Save";
            this.btn_saveresult.UseVisualStyleBackColor = true;
            this.btn_saveresult.Click += new System.EventHandler(this.btn_saveresult_Click);
            // 
            // crop
            // 
            this.crop.Location = new System.Drawing.Point(659, 54);
            this.crop.Name = "crop";
            this.crop.Size = new System.Drawing.Size(77, 47);
            this.crop.TabIndex = 13;
            this.crop.Text = "crop";
            this.crop.UseVisualStyleBackColor = true;
            this.crop.Click += new System.EventHandler(this.Crop);
            this.crop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.crop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(659, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 63);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(659, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 58);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // adjust
            // 
            this.adjust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.adjust.Location = new System.Drawing.Point(661, 12);
            this.adjust.Name = "adjust";
            this.adjust.Size = new System.Drawing.Size(75, 23);
            this.adjust.TabIndex = 16;
            this.adjust.Text = "adjust";
            this.adjust.UseVisualStyleBackColor = true;
            this.adjust.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(16, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(597, 574);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 100;
            this.trackBar1.Location = new System.Drawing.Point(855, 27);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(201, 56);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 17;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lbBrightness
            // 
            this.lbBrightness.AutoSize = true;
            this.lbBrightness.Location = new System.Drawing.Point(1062, 27);
            this.lbBrightness.Name = "lbBrightness";
            this.lbBrightness.Size = new System.Drawing.Size(14, 16);
            this.lbBrightness.TabIndex = 18;
            this.lbBrightness.Text = "0";
            // 
            // Brightness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 679);
            this.Controls.Add(this.lbBrightness);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.adjust);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.crop);
            this.Controls.Add(this.btn_saveresult);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_takephoto);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.picloading);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_ocr);
            this.Controls.Add(this.btn_choose);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Brightness";
            this.Text = "[C#] Convert Image To Text";
            ((System.ComponentModel.ISupportInitialize)(this.picloading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_choose;
        private System.Windows.Forms.Button btn_ocr;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picloading;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_takephoto;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_saveresult;
        private System.Windows.Forms.Button crop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button adjust;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbBrightness;
    }
}

