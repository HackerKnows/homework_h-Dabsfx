using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopyLandscape
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            graphics = e.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // солнце
            graphics.FillEllipse(Brushes.Yellow, 310, 20, 70, 70);
            int x1 = 0;
            for (int num1 = 1; num1 <= 4; num1++)
            {
                // рисуем дерево и траву
                DrawGrass(x1, 270);
                DrawTree(x1, 200);
                x1 = x1 + 100;
            }
        }

        private void DrawGrass(int x, int y)
        {
            Image img = Image.FromFile("../../GrassBlock.png");
            graphics.DrawImage(img, x, y);
        }

        private void DrawTree(int x, int y)
        {
            Image img = Image.FromFile("../../TreeUgly.png");
            graphics.DrawImage(img, x, y);
        }
    }
}
