using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOVD_LAB4
{
    public partial class Form1 : Form
    {
        private Bitmap OverviewImage;
        private Bitmap ObservedImage;
        private Bitmap GistogrammImage;
        private Graphics OverviewGraphics;
        private int CurrentShift;
        private bool IsFileLoaded = false;
        private int[,] LightnessMatrix;
        private int CurrentPos = 0;
        private int ScrollStep = 100;
        private int[] GistValues;
        private int LeftController = 0;
        private int RightController = 255;
        private Pen ConrollerPen = new Pen(Color.Red, 5);
        

        /*Константы - для диапазона [0;L)*/
        private const int LEFT_CHANGE_TO_ZERO = 1;
        private const int LEFT_CHANGE_TO_L = 2;
        /*Константы - для диапазона (R;255]*/
        private const int RIGHT_CHANGE_TO_R = 1;
        private const int RIGHT_CHANGE_TO_MAX = 2;
        /*Константы - для диапазона [L;R]*/
        private const int MIDDLE_SCALE_TO_ZEROMAX = 1;
        private const int MIDDLE_SCALE_TO_LMAX = 2;
        private const int MIDDLE_SCALE_TO_ZEROR = 3;

        public Form1()
        {
            InitializeComponent();
            DrawColorPictureBox();
            OpenFileDialog.Filter = "mbv (*.mbv)|*.mbv";
            GistValues = new int[256];
            OverviewImage = new Bitmap(100, 600);
            OverviewGraphics = Graphics.FromImage(OverviewImage);
            OverviewPictureBox.Image = OverviewImage;
            CurrentShift = 0;
            ObservedImage = new Bitmap(500, 500);
            ObservedPictureBox.Image = ObservedImage;
            LeftRangeComboBox.SelectedIndex = 0;
            MiddleRangeComboBox.SelectedIndex = 0;
            RightRangeComboBox.SelectedIndex = 0;

            
            
        }

        /*Метод для отрисовки яркостей под гистограммой*/
        private void DrawColorPictureBox()
        {
            Bitmap ColorImage = new Bitmap(256,30);
            Graphics G = Graphics.FromImage(ColorImage);
            for(int i = 0; i < 256; i++)
            {
                G.DrawLine(new Pen(Color.FromArgb(255, i, i, i)), new Point(i,0), new Point(i,29));
            }
            ColorPictureBox.Image = ColorImage;
        }
        

        private void LoadFileButton_Click(object sender, EventArgs e)
        {
            
            DialogResult DialogRes = OpenFileDialog.ShowDialog();
            if(DialogRes == DialogResult.OK)
            {
                string filename = OpenFileDialog.FileName;
                LoadedFileNameLabel.Text = TrimFileName(filename);
                FileStream FS = File.OpenRead(filename);
                int ImageWidth = FS.ReadByte() | FS.ReadByte() << 8;
                int ImageHeight = FS.ReadByte() | FS.ReadByte() << 8;
                LightnessMatrix = new int[ImageHeight, ImageWidth];
                for(int y = 0; y < ImageHeight; y++)
                {
                    for(int x = 0; x < ImageWidth; x++)
                    {
                        LightnessMatrix[y, x] = (FS.ReadByte() | FS.ReadByte() << 8) & 0b1111111111;
                    }
                }
                IsFileLoaded = true;
                DrawOverviewsImage();
                DrawObservedImage();
                DrawGistogramm();
            }
        }

        private string TrimFileName(string FileName)
        {
            string Result = "";
            for (int i = FileName.Length - 1; i >= 0; i--)
            {
                if (FileName[i] == '/' || FileName[i] == '\\')
                    break;
                Result += FileName[i];
            }
            char[] CharArray = Result.ToCharArray();
            Array.Reverse(CharArray);
            return new string(CharArray);
        }

        private void DrawGistogramm()
        {
            ClearArray(GistValues);
            for (int y = 0; y < ObservedImage.Height; y++)
            {
                for (int x = 0; x < ObservedImage.Width; x++)
                {
                    int lightness = (LightnessMatrix[y + CurrentPos * 5, x] >> CurrentShift) & 0xFF;
                    GistValues[lightness]++;
                }
            }
            GistogrammImage = new Bitmap(256, 256);
            Graphics ImageGraphics = Graphics.FromImage(GistogrammImage);
            Pen GistPen = new Pen(Color.Black);
            for(int x = 0; x < GistValues.Length; x++)
            {
                ImageGraphics.DrawLine(GistPen, new Point(x,255), new Point(x,255 - GistValues[x]));
            }
            GistogrammaPictureBox.Image = GistogrammImage;
            GistogrammaPictureBox.Refresh();
            Graphics ControllerGraphics = GistogrammaPictureBox.CreateGraphics();
            ControllerGraphics.DrawLine(ConrollerPen, new Point(LeftController, 0), new Point(LeftController, 255));
            ControllerGraphics.DrawLine(ConrollerPen, new Point(RightController - 2, 0), new Point(RightController - 2, 255));
        }

        private void Shift0RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CurrentShift = 0;
            if (IsFileLoaded)
            {
                DrawOverviewsImage();
                DrawObservedImage();
                DrawGistogramm();
            }
                
        }

        private void Shift1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CurrentShift = 1;
            if (IsFileLoaded)
            {
                DrawOverviewsImage();
                DrawObservedImage();
                DrawGistogramm();
            }
        }
        private void Shift2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CurrentShift = 2;
            if (IsFileLoaded)
            {
                DrawOverviewsImage();
                DrawObservedImage();
                DrawGistogramm();
            }
        }


        /*Метод для отрисовки наблюдаемого изображения*/
        private void DrawObservedImage()
        {
            if (!IsFileLoaded)
                return;
            Rectangle rect = new Rectangle(0, 0, ObservedImage.Width, ObservedImage.Height);
            BitmapData bmpData =
                ObservedImage.LockBits(rect, ImageLockMode.ReadWrite,
                ObservedImage.PixelFormat);
            IntPtr ptr = bmpData.Scan0;
            int bytes = Math.Abs(bmpData.Stride) * ObservedImage.Height;
            unsafe
            {
                byte* b = (byte*)ptr.ToPointer();
                for (int y = 0; y < ObservedImage.Height; y++)
                {
                    for (int x = 0; x < ObservedImage.Width; x++, b += 4)
                    {
                        int lightness = (LightnessMatrix[y + CurrentPos * 5, x] >> CurrentShift) & 0xFF;
                        if (lightness < LeftController) // lightness in [0;L)
                        {
                            switch (LeftRangeComboBox.SelectedIndex)
                            {
                                case LEFT_CHANGE_TO_ZERO:
                                    lightness = 0;
                                    break;
                                case LEFT_CHANGE_TO_L:
                                    lightness = LeftController;
                                    break;
                            }
                        }
                        else if (lightness >= LeftController & lightness <= RightController)
                        {// lightness in [L;R]
                            switch (MiddleRangeComboBox.SelectedIndex)
                            {
                                //НовоеЗначение = (((СтароеЗначение - СтарыйМин) * (НовыйМакс - НовыйМин)) / (СтарыйМакс - СтарыйМин)) + НовыйМи
                                case MIDDLE_SCALE_TO_ZEROMAX:// [L,R] => [0,255] 
                                    lightness = (int)((lightness - LeftController) * 255.0 / (RightController - LeftController));
                                    break;
                                case MIDDLE_SCALE_TO_LMAX://[L,R] => [L,255]
                                    lightness = (int)((lightness - LeftController) * (255.0 - LeftController) / (RightController - LeftController) + LeftController);
                                    break;
                                case MIDDLE_SCALE_TO_ZEROR://[L,R] => [0,R]
                                    lightness = (int)((lightness - LeftController) * (double)RightController /(RightController - LeftController));
                                    break;
                            }
                        }
                        else
                        {//lightness in (R:255]
                            switch (RightRangeComboBox.SelectedIndex)
                            {
                                case RIGHT_CHANGE_TO_R:
                                    lightness = RightController;
                                    break;
                                case RIGHT_CHANGE_TO_MAX:
                                    lightness = 255;
                                    break;
                            }
                        }
                        byte byte_lightness = (byte)lightness;
                        *b = byte_lightness; // blue
                        *(b + 1) = byte_lightness; // green
                        *(b + 2) = byte_lightness; // red
                        *(b + 3) = 255; // alpha
                    }

                }
            }
            ObservedImage.UnlockBits(bmpData);
            OverviewPictureBox.Refresh();
            OverviewPictureBox.CreateGraphics().DrawRectangle(new Pen(Color.Red), new Rectangle(0, CurrentPos, 97, 97));
            ObservedPictureBox.Image = ObservedImage;
            
            
        }

        private void ClearArray(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
                Array[i] = 0;
        }

        /*Метод для отрисовки обзорного изображения*/
        private void DrawOverviewsImage()
        {
            for(int y = 0; y < OverviewImage.Height; y++)
            {
                for(int x = 0; x < OverviewImage.Width; x++)
                {
                    int Lightness = (LightnessMatrix[y * 5,x * 5] >> CurrentShift) & 0xFF;
                    OverviewImage.SetPixel(x,y, Color.FromArgb(255, Lightness, Lightness, Lightness));
                }
            }
            OverviewPictureBox.Image = OverviewImage;
        }
        
        /*Прокрут обзорного изображения вверх*/
        private void UpRowButton_Click(object sender, EventArgs e)
        {
            if (!IsFileLoaded)
                return;
            if (CurrentPos == 0)
                return;
            CurrentPos -= ScrollStep;
            CurrentPos = Math.Max(CurrentPos, 0);
            DrawObservedImage();
            DrawGistogramm();
        }
        /*Прокрут обзорного изображения вниз*/
        private void DownRowButton_Click(object sender, EventArgs e)
        {
            if (!IsFileLoaded)
                return;
            if (CurrentPos == OverviewImage.Height - 100)
                return;
            CurrentPos += ScrollStep;
            CurrentPos = Math.Min(CurrentPos, OverviewImage.Height - 100);
            DrawObservedImage();
            DrawGistogramm();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ScrollStep = (int)numericUpDown1.Value;
        }

        /*Изменение положения правого движка*/
        private void RightTrackBar_Scroll(object sender, EventArgs e)
        {
            if (!IsFileLoaded)
                return;
            if (FixTrackBarsCheckBox.Checked)
            {
                if (LeftTrackBar.Value + RightTrackBar.Value - RightController >= LeftTrackBar.Minimum) {
                    LeftTrackBar.Value += RightTrackBar.Value - RightController;
                    LeftController = LeftTrackBar.Value;
                    RightController = RightTrackBar.Value;
                }
                else
                {
                    RightTrackBar.Value = RightController;
                }
            }
            else
            {
                if (RightTrackBar.Value < LeftTrackBar.Value)
                    RightTrackBar.Value = RightController;
                RightController = RightTrackBar.Value;
            }
            RightControllerLabel.Text = RightController.ToString();
            LeftControllerLabel.Text = LeftController.ToString(); 
            DrawObservedImage();
            DrawControllers();
        }

        /*Изменение положения левого движка*/
        private void LeftTrackBar_Scroll(object sender, EventArgs e)
        {
            if (!IsFileLoaded)
                return;
            if (FixTrackBarsCheckBox.Checked)
            {
                if (RightTrackBar.Value + LeftTrackBar.Value - LeftController <= RightTrackBar.Maximum) {
                    RightTrackBar.Value += LeftTrackBar.Value - LeftController;
                    RightController = RightTrackBar.Value;
                    LeftController = LeftTrackBar.Value;
                }
                else
                {
                    LeftTrackBar.Value = LeftController;
                }
            }
            else
            {
                if (LeftTrackBar.Value > RightTrackBar.Value)
                    LeftTrackBar.Value = LeftController;
                LeftController = LeftTrackBar.Value;
            }
            RightControllerLabel.Text = RightController.ToString();
            LeftControllerLabel.Text = LeftController.ToString();
            DrawObservedImage();
            DrawControllers();
        }

        /*Метод отрисовки движков*/
        private void DrawControllers()
        {
            GistogrammaPictureBox.Refresh();
            Graphics СontrollerGraphics = GistogrammaPictureBox.CreateGraphics();
            СontrollerGraphics.DrawLine(ConrollerPen, new Point(LeftController, 0), new Point(LeftController, 255));
            СontrollerGraphics.DrawLine(ConrollerPen, new Point(RightController - 2, 0), new Point(RightController - 2, 255));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawObservedImage();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawObservedImage();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawObservedImage();
        }
    }
}
