using System;
using System.Drawing;
using System.Windows.Forms;

using Tao.OpenGl;
using Tao.FreeGlut; 
using Tao.Platform.Windows;

/*  1. Тип фигуры: d. правильная пирамида с заданной высотой, радиусом основания и количеством боковых граней;
    2. Прозрачность фигуры: a. фигура может быть непрозрачной;
    3. Модель освещения фигуры: a. одноточечное с заданным положением источника;
    4. Тип проекции: b. из точки; */


namespace CG_3
{
    public partial class Form : System.Windows.Forms.Form
    {
        private double _Radius = 3.0;
        private double _Height = 6.0;
        private int _Slices = 4;

        private Color _Color = Color.White;

        public Form()
        {
            InitializeComponent();
            AnT.InitializeContexts();

            tbRadius.Text = _Radius.ToString();
            tbHeight.Text = _Height.ToString();
            tbSlices.Text = _Slices.ToString();

            pctBoxColor.BackColor = _Color;
        }

        private void AnT_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            
            Gl.glClearColor(0, 0, 0, 1);
            
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);

            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);
            Gl.glEnable(Gl.GL_LIGHTING);

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            double W = 3;
            double H = W * AnT.Height / AnT.Width;
            Gl.glFrustum(-W, W, -H, H, 2, 12);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            Gl.glEnable(Gl.GL_LIGHT0);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, new float[] { 0, 0, 1, 1 });
        }

        private void AnT_MouseMove(object sender, MouseEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glPushMatrix();

            Gl.glTranslated(0, 0, -8);
            Gl.glRotated((e.X - AnT.Width) * 360 / AnT.Width, 0, 1, 0);
            Gl.glRotated((e.Y - AnT.Height) * 360 / AnT.Height, 1, 0, 0);

            Gl.glColor3f(1, 1, 1);
            Glut.glutSolidCone(_Radius, _Height, _Slices, 1);

            Gl.glPopMatrix();
            Gl.glFlush();
            AnT.Invalidate();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            clrDialog.Color = _Color;

            if (clrDialog.ShowDialog() == DialogResult.OK)
            {
                _Color = clrDialog.Color;
                pctBoxColor.BackColor = _Color;
            }
        }

        private void btnLight_Click(object sender, EventArgs e)
        {
            try
            {
                Gl.glEnable(Gl.GL_LIGHT0);
                float[] pos =
                {
                        float.Parse(tbX.Text),
                        float.Parse(tbY.Text),
                        float.Parse(tbZ.Text),
                        1
                    };
                Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, pos);

                float[] color =
                {
                        _Color.R / (float) 255,
                        _Color.G / (float) 255,
                        _Color.B / (float) 255,
                        1
                    };
                Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_DIFFUSE, color);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка входных данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tbRadius.Text))
                    _Radius = double.Parse(tbRadius.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка входных данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbRadius.Clear();
            }

            try
            {
                if (!string.IsNullOrEmpty(tbHeight.Text))
                    _Height = double.Parse(tbHeight.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка входных данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbHeight.Clear();
            }

            try
            {
                if (!string.IsNullOrEmpty(tbSlices.Text))
                    _Slices = int.Parse(tbSlices.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка входных данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSlices.Clear();
            }
        }
    }
}
