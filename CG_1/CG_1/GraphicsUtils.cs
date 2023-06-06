using System.Drawing;
using System.Windows.Forms;

namespace CG_1
{
    internal class GraphicsUtils
    {
        private static PictureBox pctBox;
        private static Pen fillPen;
        private static Color borderColor;
        public static void FillArea(PictureBox curPctBox, Pen curFillPen, Color curBorderColor, int x, int y)
        {
            pctBox = curPctBox;
            fillPen = curFillPen;
            borderColor = curBorderColor;

            FillArea(x, y);
        }

        private static void FillArea(int x, int y)
        {
            if (x >= pctBox.Width - 1)
                return;
            if (x < 1)
                return;
            if (y >= pctBox.Height - 1)
                return;
            if (y < 1)
                return;

            Graphics graphics = Graphics.FromImage(pctBox.Image);
            graphics.DrawLine(fillPen, x, y, x, y + 0.5f);

            pctBox.Invalidate();
            Bitmap bmp = (Bitmap)pctBox.Image;

            if (bmp.GetPixel(x + 1, y).ToArgb() != borderColor.ToArgb()
                && bmp.GetPixel(x + 1, y).ToArgb() != fillPen.Color.ToArgb())
                FillArea(x + 1, y);

            if (bmp.GetPixel(x - 1, y).ToArgb() != borderColor.ToArgb()
                && bmp.GetPixel(x - 1, y).ToArgb() != fillPen.Color.ToArgb())
                FillArea(x - 1, y);

            if (bmp.GetPixel(x, y + 1).ToArgb() != borderColor.ToArgb()
                && bmp.GetPixel(x, y + 1).ToArgb() != fillPen.Color.ToArgb())
                FillArea(x, y + 1);

            if (bmp.GetPixel(x, y - 1).ToArgb() != borderColor.ToArgb()
                && bmp.GetPixel(x, y - 1).ToArgb() != fillPen.Color.ToArgb())
                FillArea(x, y - 1);
        }
    }
}
