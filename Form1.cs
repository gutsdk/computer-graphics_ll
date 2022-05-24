using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KGLB2_3
{
    public partial class Form1 : Form
    {
        Tor _tor;
        double i = 0;
        bool typeDraw, sortPoly, shadeColor;
        private Surface surface;
        public void Draw(bool type, bool shade, bool sort)
        {
            surface.Ks = (double)numericUpDownOSNS.Value;
            surface.Kd = (double)numericUpDownOSRS.Value;
            surface.N = (int)numericUpDownKGP.Value;
            surface.Ia = (double)numericUpDownITS.Value;
            surface.Ip = (double)numericUpDownISvOSO.Value;
            surface.Ka = (double)numericUpDownOSOS.Value;
            pictureBox1.Image = _tor.DrawingTor(pictureBox1.Width, pictureBox1.Height, 275, type, shade, sort, surface, (int)numericRedByte.Value, (int)numericGreenByte.Value, (int)numericBlueByte.Value);
        }
        public Form1()
        {
            InitializeComponent();
            surface = new Surface();
        }
        private void checkBoxStop_CheckedChange(object sender, EventArgs e)
        {
            if(checkBoxStop.Checked)timer1.Enabled = false;
            else timer1.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _tor = new Tor();
            timer1.Enabled = true;
            KeyPreview = true;
            KeyDown += Form1_KeyDown;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    _tor.Up();
                    break;
                case Keys.A:
                    _tor.Left();
                    break;
                case Keys.S:
                    _tor.Down();
                    break;
                case Keys.D:
                    _tor.Right();
                    break;
                case Keys.Q:
                    _tor.Forward();
                    break;
                case Keys.E:
                    _tor.Backward();
                    break;
            }
            Draw(typeDraw, shadeColor, sortPoly);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Draw(typeDraw, shadeColor, sortPoly);
            _tor.Speed = i;
            i += 2;
        }
        private void checkBoxBrush_CheckedChange(object sender, EventArgs e)
        {
            if (checkBoxBrush.Checked) typeDraw = true;
            else typeDraw = false;
        }

        private void checkBoxArt_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxArt.Checked) sortPoly = true;
            else sortPoly = false;
        }
        private void checkBoxPhong_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPhong.Checked) shadeColor = true;
            else shadeColor = false;
        }
    }
}