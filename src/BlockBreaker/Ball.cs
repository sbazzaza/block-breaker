using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace BlockBreaker
{
    public class Ball
    {
        public int x;
        public int y;
        public int lastX;
        public int lastY;
        public int dx;
        public int dy;
        public Brush Ballcolor;
        public Brush BackgroundColor;
        public int speed = 1;
        public int radious=7;

        public Ball(int x, int y, int dx, int dy, Brush Ballcolor,Brush BackgroundColor)
        {
            this.x = x;
            this.y = y;
            this.dx = dx;
            this.dy = dy;
            this.Ballcolor = Ballcolor;
            this.BackgroundColor = BackgroundColor;
            lastX = 0;
            lastY = 0;
        }

        public void move()
        {
            lastX = x;
            lastY = y;

            x += speed * dx;
            y += speed * dy;
        }

        public void hitHorizontal()
        {
            dy = dy * -1;
        }

        public void hitVertical()
        {
            dx = dx * -1;
        }

        public void Draw()
        {
            FormMain.g.FillEllipse(BackgroundColor, lastX - radious, lastY - radious, 2 * radious, 2 * radious );
            FormMain.g.FillEllipse(Ballcolor, x - radious, y - radious, 2 * radious, 2 * radious);
            //FormMain.g.DrawImage(Image.FromFile("ball1.png"), x - radious, y - radious, 2 * radious, 2 * radious);

        }
    }
}
