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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lbBrightness = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoayAnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoayTraiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoayPhaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomAnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phongToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuNhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyênAnhSangPdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuPdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveNextcloudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.constrast = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picloading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_choose
            // 
            this.btn_choose.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_choose.Location = new System.Drawing.Point(477, 54);
            this.btn_choose.Margin = new System.Windows.Forms.Padding(4);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(137, 28);
            this.btn_choose.TabIndex = 1;
            this.btn_choose.Text = "Choose Image";
            this.btn_choose.UseVisualStyleBackColor = true;
            this.btn_choose.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ocr
            // 
            this.btn_ocr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ocr.ForeColor = System.Drawing.Color.Red;
            this.btn_ocr.Location = new System.Drawing.Point(637, 222);
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
            this.richTextBox1.Location = new System.Drawing.Point(783, 90);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(572, 509);
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
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1064, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result";
            // 
            // picloading
            // 
            this.picloading.Image = global::OCR_Vietnamese.Properties.Resources.loading;
            this.picloading.Location = new System.Drawing.Point(1024, 295);
            this.picloading.Margin = new System.Windows.Forms.Padding(4);
            this.picloading.Name = "picloading";
            this.picloading.Size = new System.Drawing.Size(143, 130);
            this.picloading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picloading.TabIndex = 7;
            this.picloading.TabStop = false;
            this.picloading.Visible = false;
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_takephoto.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_takephoto.Location = new System.Drawing.Point(279, 54);
            this.btn_takephoto.Margin = new System.Windows.Forms.Padding(4);
            this.btn_takephoto.Name = "btn_takephoto";
            this.btn_takephoto.Size = new System.Drawing.Size(124, 28);
            this.btn_takephoto.TabIndex = 9;
            this.btn_takephoto.Text = "Take photo";
            this.btn_takephoto.UseVisualStyleBackColor = true;
            this.btn_takephoto.Click += new System.EventHandler(this.btn_takephoto_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(411, 54);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(59, 28);
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
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(589, 525);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.crop_MouseMove);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 100;
            this.trackBar1.Location = new System.Drawing.Point(139, 629);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.lbBrightness.Location = new System.Drawing.Point(345, 629);
            this.lbBrightness.Name = "lbBrightness";
            this.lbBrightness.Size = new System.Drawing.Size(14, 16);
            this.lbBrightness.TabIndex = 18;
            this.lbBrightness.Text = "0";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(16, 90);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 533);
            this.panel1.TabIndex = 22;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 30);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1371, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.lưuToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1371, 30);
            this.menuStrip2.TabIndex = 26;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cropToolStripMenuItem,
            this.xoayAnhToolStripMenuItem,
            this.zoomAnhToolStripMenuItem,
            this.chuyênAnhSangPdfToolStripMenuItem});
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(161, 26);
            this.toolStripMenuItem2.Text = "Image processing";
            // 
            // cropToolStripMenuItem
            // 
            this.cropToolStripMenuItem.Name = "cropToolStripMenuItem";
            this.cropToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cropToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.cropToolStripMenuItem.Text = "Crop";
            this.cropToolStripMenuItem.Click += new System.EventHandler(this.cropToolStripMenuItem_Click);
            // 
            // xoayAnhToolStripMenuItem
            // 
            this.xoayAnhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xoayTraiToolStripMenuItem,
            this.xoayPhaiToolStripMenuItem});
            this.xoayAnhToolStripMenuItem.Name = "xoayAnhToolStripMenuItem";
            this.xoayAnhToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.xoayAnhToolStripMenuItem.Text = "Rotate Image";
            this.xoayAnhToolStripMenuItem.Click += new System.EventHandler(this.xoayAnhToolStripMenuItem_Click);
            // 
            // xoayTraiToolStripMenuItem
            // 
            this.xoayTraiToolStripMenuItem.Name = "xoayTraiToolStripMenuItem";
            this.xoayTraiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.xoayTraiToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.xoayTraiToolStripMenuItem.Text = "xoay trái";
            this.xoayTraiToolStripMenuItem.Click += new System.EventHandler(this.xoayTraiToolStripMenuItem_Click);
            // 
            // xoayPhaiToolStripMenuItem
            // 
            this.xoayPhaiToolStripMenuItem.Name = "xoayPhaiToolStripMenuItem";
            this.xoayPhaiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.xoayPhaiToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.xoayPhaiToolStripMenuItem.Text = "xoay phải";
            this.xoayPhaiToolStripMenuItem.Click += new System.EventHandler(this.xoayPhaiToolStripMenuItem_Click);
            // 
            // zoomAnhToolStripMenuItem
            // 
            this.zoomAnhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phongToToolStripMenuItem,
            this.thuNhoToolStripMenuItem});
            this.zoomAnhToolStripMenuItem.Name = "zoomAnhToolStripMenuItem";
            this.zoomAnhToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.zoomAnhToolStripMenuItem.Text = "Zoom Image";
            this.zoomAnhToolStripMenuItem.Click += new System.EventHandler(this.zoomAnhToolStripMenuItem_Click);
            // 
            // phongToToolStripMenuItem
            // 
            this.phongToToolStripMenuItem.Name = "phongToToolStripMenuItem";
            this.phongToToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.phongToToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.phongToToolStripMenuItem.Text = "phóng to";
            this.phongToToolStripMenuItem.Click += new System.EventHandler(this.phongToToolStripMenuItem_Click);
            // 
            // thuNhoToolStripMenuItem
            // 
            this.thuNhoToolStripMenuItem.Name = "thuNhoToolStripMenuItem";
            this.thuNhoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.thuNhoToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.thuNhoToolStripMenuItem.Text = "thu nhỏ";
            this.thuNhoToolStripMenuItem.Click += new System.EventHandler(this.thuNhoToolStripMenuItem_Click);
            // 
            // chuyênAnhSangPdfToolStripMenuItem
            // 
            this.chuyênAnhSangPdfToolStripMenuItem.Name = "chuyênAnhSangPdfToolStripMenuItem";
            this.chuyênAnhSangPdfToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.chuyênAnhSangPdfToolStripMenuItem.Text = "Change Image To Pdf";
            this.chuyênAnhSangPdfToolStripMenuItem.Click += new System.EventHandler(this.chuyênAnhSangPdfToolStripMenuItem_Click);
            // 
            // lưuToolStripMenuItem
            // 
            this.lưuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lưuPdfToolStripMenuItem});
            this.lưuToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lưuToolStripMenuItem.Name = "lưuToolStripMenuItem";
            this.lưuToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.lưuToolStripMenuItem.Text = "Result processing";
            // 
            // lưuPdfToolStripMenuItem
            // 
            this.lưuPdfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveLocalToolStripMenuItem,
            this.saveNextcloudToolStripMenuItem});
            this.lưuPdfToolStripMenuItem.Name = "lưuPdfToolStripMenuItem";
            this.lưuPdfToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lưuPdfToolStripMenuItem.Text = "Save";
            // 
            // saveLocalToolStripMenuItem
            // 
            this.saveLocalToolStripMenuItem.Name = "saveLocalToolStripMenuItem";
            this.saveLocalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveLocalToolStripMenuItem.Text = "Save local";
            this.saveLocalToolStripMenuItem.Click += new System.EventHandler(this.saveLocalToolStripMenuItem_Click);
            // 
            // saveNextcloudToolStripMenuItem
            // 
            this.saveNextcloudToolStripMenuItem.Name = "saveNextcloudToolStripMenuItem";
            this.saveNextcloudToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveNextcloudToolStripMenuItem.Text = "Save Nextcloud";
            this.saveNextcloudToolStripMenuItem.Click += new System.EventHandler(this.saveNextcloudToolStripMenuItem_Click);
            // 
            // constrast
            // 
            this.constrast.AutoSize = true;
            this.constrast.Location = new System.Drawing.Point(79, 638);
            this.constrast.Name = "constrast";
            this.constrast.Size = new System.Drawing.Size(63, 16);
            this.constrast.TabIndex = 28;
            this.constrast.Text = "Constrast";
            // 
            // Brightness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 679);
            this.Controls.Add(this.constrast);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbBrightness);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_takephoto);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.picloading);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_ocr);
            this.Controls.Add(this.btn_choose);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Brightness";
            this.Text = "[C#] Convert Image To Text";
            this.Load += new System.EventHandler(this.Brightness_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picloading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbBrightness;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cropToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoayAnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomAnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phongToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuNhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoayTraiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoayPhaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuPdfToolStripMenuItem;
        private System.Windows.Forms.Label constrast;
        private System.Windows.Forms.ToolStripMenuItem chuyênAnhSangPdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveNextcloudToolStripMenuItem;
    }
}

