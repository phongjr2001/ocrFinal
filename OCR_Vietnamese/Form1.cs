using System;
using System.Diagnostics;
using System.Drawing;            //bitmap
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;    //luồng
using System.Windows.Forms;
using AForge.Video.DirectShow;   //camera
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using Tesseract;                //ocr

namespace OCR_Vietnamese
{
    public partial class Brightness : Form
    {
        private FilterInfoCollection cameras;   //liệt kê các thiết bị video
        private VideoCaptureDevice cam;         //nguồn video của cam, ghi lại dữ liệu video từ camera
        int xDown              = 0;
        int yDown              = 0;
        int xUp                = 0;
        int yUp                = 0;
        int scaleFactor        = 5;
        int cropX;
        int cropY;
        int cropWidth;
        int cropHeight;
        int oCropX;
        int oCropY;
        public Pen cropPen;
        public DashStyle cropDashStyle = DashStyle.DashDot;
        string UserName = "user";
        string Password = "demo123";
        //string UserName = "tqhuy18072001@gmail.com";
        //string Password = "tqhuy18072001@gmail.com";
        MemoryStream ms        = new MemoryStream();
        Rectangle rectCropArea = new Rectangle();
        string localFilePath;
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
            pictureBox1.Cursor      = Cursors.Cross;
        }
       

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Cursor = Cursors.Cross;
                cropX = e.X;
                cropY = e.Y;
                cropPen = new Pen(Color.Black, 1);
                cropPen.DashStyle = DashStyle.DashDotDot;
            }
            pictureBox1.Refresh();
        }

        //mở file, sử dụng openFileDialog
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bitmap            = (Bitmap)Bitmap.FromFile(openFileDialog.FileName);
                pictureBox1.Image = bitmap;
            }
        }

        //khởi động webcam
        private void btn_start_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
                cam.Stop();

            cam           = new VideoCaptureDevice(cameras[comboBox1.SelectedIndex].MonikerString);
            cam.NewFrame += Cam_NewFrame;
            cam.Start();
        }

        private void Cam_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap     = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bitmap;
        }

        //chụp ảnh
        private void btn_takephoto_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
                cam.Stop();
        }

        //lưu ảnh
        private void btn_save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "F:\\Thực tập cs cn\\Images";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Image.Save(saveFileDialog1.FileName);
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

        private void btn_saveresult_Click(object sender, EventArgs e)
        {
           
        }

       

       
        private Bitmap AdjustBrightness(Image image, float brightness)
        {
            // Make the ColorMatrix.
            float b = brightness;
            float finalValue = (float)brightness / 255.0f;
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
                gr.DrawImage(image, points, rect, GraphicsUnit.Pixel, attributes);
            }
            // Return the result.
            return bm;
        }

        

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Image = AdjustBrightness(bitmap, (float)(trackBar1.Value));
            lbBrightness.Text = trackBar1.Value.ToString();
            pictureBox1.Refresh();
        }

        private void btn_ZoomIn_Click(object sender, EventArgs e)
        {
            pictureBox1.Height += scaleFactor;
            pictureBox1.Width  += scaleFactor;
        }

        private void btn_ZoomOut_Click(object sender, EventArgs e)
        {
            pictureBox1.Height -= scaleFactor;
            pictureBox1.Width  -= scaleFactor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }
        void DrawImage(XGraphics gfx, string jpegSamplePath, int x, int y, int width, int height)
        {
            XImage image = XImage.FromFile(jpegSamplePath);
            gfx.DrawImage(image, x, y, width, height);
        }
        private void UploadFile(string localFilePath, string remoteFilePath)
        {
            string curlArguments = $"-k -u {UserName}:{Password} -T \"{localFilePath}\" \"{remoteFilePath}\"";

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName               = "curl",
                Arguments              = curlArguments,
                UseShellExecute        = false,
                RedirectStandardError  = true,
                RedirectStandardOutput = true,
                CreateNoWindow         = true
            };

            Process process = new Process { StartInfo = startInfo };

            process.Start();

            //string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            process.WaitForExit();

            if (process.ExitCode != 0)
                throw new Exception($"Upload thất bại. Error: {error}");
        }

        private void cropToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Cursor = Cursors.Default;
            if (cropWidth < 1)
            {
                return;
            }
            Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);
            //First we define a rectangle with the help of already calculated points  
            Bitmap OriginalImage = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);
            //Original image  
            Bitmap _img = new Bitmap(cropWidth, cropHeight);
            // for cropinf image  
            Graphics g = Graphics.FromImage(_img);
            // create graphics  
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;
            //set image attributes  
            g.DrawImage(OriginalImage, 0, 0, rect, GraphicsUnit.Pixel);
            pictureBox1.Image = _img;
            pictureBox1.Width = _img.Width;
            pictureBox1.Height = _img.Height;
            
        }

        private void xoayAnhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chinhSangTôiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = AdjustBrightness(bitmap, (float)(trackBar1.Value));
            lbBrightness.Text = trackBar1.Value.ToString();
            pictureBox1.Refresh();
        }

        private void phongToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Height += scaleFactor;
            pictureBox1.Width += scaleFactor;
        }

        private void thuNhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Height -= scaleFactor;
            pictureBox1.Width -= scaleFactor;
        }

        private void crop_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null)
                return;
            if (e.Button == MouseButtons.Left)
            {
                pictureBox1.Refresh();
                cropWidth = e.X - cropX;
                cropHeight = e.Y - cropY;
                pictureBox1.CreateGraphics().DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight);
            }
        }

        private void xoayTraiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                var imagerl = pictureBox1.Image;
                imagerl.RotateFlip(RotateFlipType.Rotate90FlipXY);
                pictureBox1.Image = imagerl;
            }
        }

        private void xoayPhaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                var imagerl = pictureBox1.Image;
                imagerl.RotateFlip(RotateFlipType.Rotate270FlipXY);
                pictureBox1.Image = imagerl;
            }
        }

        private void chuyênAnhSangPdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.InitialDirectory = "E:\\image";
            dlg.Filter = "JPEG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            dlg.Multiselect = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                PdfDocument document = new PdfDocument();
                document.Info.Title = "Created using PDFsharp";

                foreach (string fileSpec in dlg.FileNames)
                {
                    PdfPage page = document.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, fileSpec, 0, 0, (int)page.Width, (int)page.Height);
                }
                if (document.PageCount > 0) document.Save(@"E:\\image\\change.pdf");
            }
        }

        private void saveLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|RTF Files (*.rtf)|*.rtf";
            saveFileDialog.AddExtension = true;
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var extension = Path.GetExtension(saveFileDialog.FileName);
                    if (extension.ToLower() == ".txt") /*saveFileDialog.FilterIndex==1*/
                        richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                    else
                        richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                }
                MessageBox.Show("Upload thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Upload thất bại! Lỗi: {ex.Message}");
            }
        }

        private void saveNextcloudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //string localFilePath;
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|RTF Files (*.rtf)|*.rtf|All Files (*)";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                    var extension = Path.GetExtension(saveFileDialog.FileName);
                    localFilePath = saveFileDialog.FileName;
                }
                string fileName = Path.GetFileNameWithoutExtension(saveFileDialog.FileName);
                //string localFilePath = "F:\\Curl\\TestCurl.txt";
                string remoteFilePath = $"https://demo21.nextfiles.eu/remote.php/webdav/NextCloud/{fileName}.txt";
                //string remoteFilePath = $"https://efss.qloud.my/remote.php/dav/files/tqhuy18072001%40gmail.com/Huytq/{fileName}.txt";

                UploadFile(localFilePath, remoteFilePath);
                MessageBox.Show("Upload thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Upload thất bại! Lỗi: {ex.Message}");
            }
        }

        private void Brightness_Load(object sender, EventArgs e)
        {

        }

        private void zoomAnhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}