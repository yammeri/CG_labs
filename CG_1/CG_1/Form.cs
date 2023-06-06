using System;
using System.Drawing;
using System.Windows.Forms;

/* 8. Закраска произвольной области (задаются цвет границы и цвет закраски). Алгоритм с затравкой. */

namespace CG_1
{
    public partial class Form : System.Windows.Forms.Form
    {
        int x, y;
        Pen borderPen = new Pen(Color.Black);
        Pen fillPen = new Pen(Color.White);

        public Form()
        {
            InitializeComponent();
            pctBox.Image = new Bitmap(pctBox.Width, pctBox.Height);

            pctBoxBorderColor.BackColor = borderPen.Color;
            pctBoxFillColor.BackColor = fillPen.Color; 
        }

        private void pctBox_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            if (e.Button == MouseButtons.Right)
                GraphicsUtils.FillArea(pctBox, fillPen, borderPen.Color, e.X, e.Y);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pctBox.Image = new Bitmap(pctBox.Width, pctBox.Height);
        }

        private void btnBorderColor_Click(object sender, EventArgs e)
        {
            colorDlg.Color = borderPen.Color;
            if (colorDlg.ShowDialog() == DialogResult.Cancel)
                return;
            
            borderPen.Color = colorDlg.Color;
            pctBoxBorderColor.BackColor = colorDlg.Color;
        }

        private void btnFillColor_Click(object sender, EventArgs e)
        {
            colorDlg.Color = fillPen.Color;
            if (colorDlg.ShowDialog() == DialogResult.Cancel)
                return;

            fillPen.Color = colorDlg.Color;
            pctBoxFillColor.BackColor = colorDlg.Color;
        }

        private void pctBox_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(pctBox.Image);
                g.DrawLine(borderPen, e.X, e.Y, x, y);
                x = e.X;
                y = e.Y;
                pctBox.Invalidate();
            }
        }
    }
}
