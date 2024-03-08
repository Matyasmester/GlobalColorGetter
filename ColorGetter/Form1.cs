using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Gma.System.MouseKeyHook;

namespace ColorGetter
{
    public partial class MainForm : Form
    {
        private int screenLeft = SystemInformation.VirtualScreen.Left;
        private int screenTop  = SystemInformation.VirtualScreen.Top;
        private int screenWidth = SystemInformation.VirtualScreen.Width;
        private int screenHeight = SystemInformation.VirtualScreen.Height;

        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(ref Point lpPoint);

        public MainForm()
        {
            InitializeComponent();

            Hook.GlobalEvents().MouseClick += OnMouseButtonPressed;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        
        private void OnMouseButtonPressed(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Middle) return;

            Point p = new Point();

            GetCursorPos(ref p);

            Color c = GetColorAt(in p);

            ColorPicBox.BackColor = c;

            string R = c.R.ToString();
            string G = c.G.ToString();
            string B = c.B.ToString();

            RLabel.Text = R;
            GLabel.Text = G;
            BLabel.Text = B;

            string hex = c.R.ToString("x2") + c.G.ToString("x2") + c.B.ToString("x2");

            HexLabel.Text = hex;

            Clipboard.SetText(hex);
        }

        private Color GetColorAt(in Point p)
        {
            Color retval;

            using(Bitmap bitmap = new Bitmap(screenWidth, screenHeight))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.CopyFromScreen(screenLeft, screenTop, 0, 0, bitmap.Size);
                }

                retval = bitmap.GetPixel(p.X, p.Y);
            }

            return retval;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BLabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void HexLabel_Click(object sender, EventArgs e)
        {

        }

        private void TopmostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = TopmostCheckBox.Checked;
        }
    }
}
