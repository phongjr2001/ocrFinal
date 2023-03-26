﻿using AForge.Video.DirectShow;      //camera
using System;
using System.Diagnostics.Tracing;
using System.Drawing;   //bitmap
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Net.NetworkInformation;
using System.Threading.Tasks; //luồng
using System.Windows.Forms;
using Tesseract;    //ocr
using Tesseract.Interop;
using ImageFormat = Tesseract.ImageFormat;

namespace OCR_Vietnamese
{


    public partial class Brightness : Form
    {
        private FilterInfoCollection cameras;   //liệt kê các thiết bị video
        private VideoCaptureDevice cam; //nguồn video của cam, ghi lại dữ liệu video từ camera
        int xDown = 0;
        int yDown = 0;
        int xUp = 0;
        int yUp = 0;
        Rectangle rectCropArea = new Rectangle();
        System.IO.MemoryStream ms = new System.IO.MemoryStream();
        Task timeout;
        string fn = "";
        Bitmap bitmap;
        public Brightness()
        {
            InitializeComponent();

            //liệt kê các camera mà máy sử dụng r hiển thị ra combobox cho ng dùng chọn
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in cameras)
            {
                comboBox1.Items.Add(info.Name);
            }
            comboBox1.SelectedIndex = 0;

            pictureBox1.Cursor = Cursors.Cross;
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //pictureBox1.Image.Clone();
            xUp = e.X;
            yUp = e.Y;
            Rectangle rec = new Rectangle(xDown, yDown, Math.Abs(xUp - xDown), Math.Abs(yUp - yDown));
            using (Pen pen = new Pen(Color.Black, 3))
            {

                pictureBox1.CreateGraphics().DrawRectangle(pen, rec);
            }
            rectCropArea = rec;
            crop.Enabled = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Invalidate();

            xDown = e.X;
            yDown = e.Y;
            crop.Enabled = true;
        }

        //mở file, sử dụng openFileDialog
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bitmap = (Bitmap)Bitmap.FromFile(openFileDialog.FileName);
                pictureBox1.Image = bitmap;
            }
        }

        //khởi động webcam
        private void btn_start_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
            cam = new VideoCaptureDevice(cameras[comboBox1.SelectedIndex].MonikerString);
            cam.NewFrame += Cam_NewFrame;
            cam.Start();
        }

        private void Cam_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bitmap;
        }

        //chụp ảnh
        private void btn_takephoto_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
        }

        //lưu ảnh
        private void btn_save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "F:\\Thực tập cs cn\\Images";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }

        //chuyển ảnh qua text
        private void button2_Click(object sender, EventArgs e)
        {
            string result = "";
            Task.Factory.StartNew(() =>
            {
                picloading.BeginInvoke(new Action(() =>
                {
                    picloading.Visible = true;
                }));
                
                //thực hiện convert
                result = OCR((Bitmap)pictureBox1.Image);
                richTextBox1.BeginInvoke(new Action(() =>
                {

                    richTextBox1.Text = result;

                }));
                picloading.BeginInvoke(new Action(() =>
                {
                    picloading.Visible = false;
                }));

            });
        }

        //convert
        private string OCR(Bitmap b)
        {
            string res = "";
            using (var engine = new TesseractEngine(@"tessdata", "vie", EngineMode.Default))
            {
                using (var page = engine.Process(b, PageSegMode.AutoOnly))
                    res = page.GetText();
            }
            return res;
        }

        private void picloading_Click(object sender, EventArgs e)
        {

        }

        private void btn_saveresult_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)";
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var extension = System.IO.Path.GetExtension(saveFileDialog.FileName);
                if (extension.ToLower() == ".txt") /*saveFileDialog.FilterIndex==1*/
                    richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                else
                    richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void Crop(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Refresh();
                //Prepare a new Bitmap on which the cropped image will be drawn
                Bitmap sourceBitmap = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(pictureBox1.Image);
               

                //Draw the image on the Graphics object with the new dimesions
                g.DrawImage(sourceBitmap, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height), rectCropArea, GraphicsUnit.Pixel);
                sourceBitmap.Dispose();
                crop.Enabled = false;
                var path = Environment.CurrentDirectory.ToString();
                ms = new System.IO.MemoryStream();

                bitmap.Save("Cropped.png", System.Drawing.Imaging.ImageFormat.Png);


                byte[] ar = new byte[ms.Length];
                var timeout = ms.WriteAsync(ar, 0, ar.Length);

            }
            catch (Exception ex)
            {

            }
        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                var imagerl = pictureBox1.Image;
                imagerl.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipXY);
                pictureBox1.Image = imagerl;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                var imagerl = pictureBox1.Image;
                imagerl.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipXY);
                pictureBox1.Image = imagerl;
            }
        }
        private Bitmap AdjustBrightness(Image image, float brightness)
        {
            // Make the ColorMatrix.

            float b = brightness;
            float finalValue=(float) brightness/255.0f;
            ColorMatrix cm = new ColorMatrix(new float[][]
                {
            new float[] {1, 0, 0, 0, 0},
            new float[] {0, 1, 0, 0, 0},
            new float[] {0, 0, 1, 0, 0},
            new float[] {0, 0, 0, 1, 0},
            new float[] {finalValue, finalValue, finalValue, 1, 1},
                });
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(cm);
            // Draw the image onto the new bitmap while applying
            // the new ColorMatrix.
            Point[] points =
            {
        new Point(0, 0),
        new Point(image.Width, 0),
        new Point(0, image.Height),
    };
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);

            // Make the result bitmap.
            Bitmap bm = new Bitmap(image.Width, image.Height);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.DrawImage(image, points, rect,
                    GraphicsUnit.Pixel, attributes);
            }

            // Return the result.
            return bm;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                var imagerl = AdjustBrightness(pictureBox1.Image, 15);
                pictureBox1.Image = imagerl;
            }
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Image = AdjustBrightness(bitmap, (float)(trackBar1.Value));
            lbBrightness.Text=trackBar1.Value.ToString();
            pictureBox1.Refresh();
        }
    }
}