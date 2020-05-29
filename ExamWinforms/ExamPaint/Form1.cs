using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamPaint
{
    public partial class Form1 : Form
    {
        Bitmap picture1;
        Bitmap picture2;
        string mode;
        int x, y;
        int xClick, yClick;      
        
       
        public Form1()
        {
            InitializeComponent();
            mode = "Line";
            picture1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            picture2 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            x = 0;
            y = 0;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                picture1 = (Bitmap)Image.FromFile(openFileDialog.FileName);
                pictureBox1.Image = picture1;
            }


        }
    

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                picture1.Save(saveFileDialog.FileName);
            }
            else MessageBox.Show("Файл не выбран", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                picture1.Save(saveFileDialog.FileName);
            }
           
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Clipboard.GetImage();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(pictureBox1.Image);
            pictureBox1.Image = null;
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(pictureBox1.Image);
        }
        //open file
        private void toolStripButnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                picture1 = (Bitmap)Image.FromFile(openFileDialog.FileName);
                pictureBox1.Image = picture1;
            }
        }
        //save file
        private void toolStripBtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                picture1.Save(saveFileDialog.FileName);
            }
        }
        //print
        private void toolStripBtnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
        }
        //exit
        private void toolStripBtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       

        private void увеличитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void уменьшитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

       
        //line
        private void toolStripBtnLine_Click(object sender, EventArgs e)
        {
            mode = "Line";
        }
        //rectangle
        private void toolStripBtnRect_Click(object sender, EventArgs e)
        {
            mode = "Rectangle";
        }
        //circle
        private void toolStripBtnCircle_Click(object sender, EventArgs e)
        {
            mode = "Circle";
        }

        private void toolStripBtnTriangle_Click(object sender, EventArgs e)
        {
            mode = "Triangle";
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Pen pen = new Pen(toolStripBtnBlack.BackColor, trackBarColorSize.Value);
            Graphics graphics = Graphics.FromImage(picture1);
            if (mode == "Rectangle")
            {
                graphics.DrawRectangle(pen, xClick, yClick, e.X - xClick, e.Y - yClick);
            }
            if (mode == "Circle")
            {
                graphics.DrawEllipse(pen, xClick, yClick, e.X - xClick, e.Y - yClick);
            }

        }
        //color
        private void toolStripBtnBlack_Click(object sender, EventArgs e)
        {
            ToolStripButton toolStripButton = (ToolStripButton)sender;
            toolStripBtnBlack.BackColor = toolStripButton.BackColor;
        }
        //circle color
        private void toolStripBtnColorCircle_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                toolStripBtnBlack.BackColor = colorDialog.Color;
            }
        }
        //eraser
        private void toolStripBtnEraser_Click(object sender, EventArgs e)
        {
            ToolStripButton toolStripButton = (ToolStripButton)sender;
            toolStripBtnBlack.BackColor = toolStripBtnEraser.BackColor;
        }
        //clear
        private void toolStripBtnClear_Click(object sender, EventArgs e)
        {
            Graphics graphics = Graphics.FromImage(picture1);
            Graphics graphics1 = Graphics.FromImage(picture2);
            graphics.Clear(Color.White);
            graphics1.Clear(Color.White);
            pictureBox1.Refresh();
        }
        //full screen
        private void toolStripBtnFullScreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        //mini screen
        private void toolStripBtnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            xClick = e.X;
            yClick = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Pen pen = new Pen(toolStripBtnBlack.BackColor, trackBarColorSize.Value)
            {
                EndCap = System.Drawing.Drawing2D.LineCap.Round,
                StartCap = System.Drawing.Drawing2D.LineCap.Round
            };

            Graphics graphics1 = Graphics.FromImage(picture1);
            Graphics graphics2 = Graphics.FromImage(picture2);

            if (e.Button == MouseButtons.Left)
            {
                if (mode == "Line")
                {
                    graphics1.DrawLine(pen, x, y, e.X, e.Y);
                }
                if (mode == "Rectangle")
                {
                    graphics2.Clear(Color.White);
                    int x1, y1;
                    x1 = xClick;
                    y1 = yClick;
                    if (x1 > e.X) x1 = e.X;
                    if (y1 > e.Y) y1 = e.Y;

                    graphics2.DrawRectangle(pen, x1, y1, Math.Abs(e.X - xClick), Math.Abs(e.Y - yClick));
                }
                if (mode == "Circle")
                {
                    graphics2.Clear(Color.White);
                    graphics2.DrawEllipse(pen, xClick, yClick, e.X - xClick, e.Y - yClick);
                }
                graphics2.DrawImage(picture1, 0, 0);
                pictureBox1.Image = picture2;
            }
            x = e.X;
            y = e.Y;
        }

       

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

