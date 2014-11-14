using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace BlockBreaker
{
    public class Plate
    {
        public int x;
        public int y;
        public int lastX;
        public int width = 100;
        public int height = 10;
        public int speed = 5;
        public int heightFromFloor = 50;

        public Plate()
        {
            lastX = 0;
        }

        public void moveLeft()
        {
            lastX = x;

            x = x - speed;
            this.Draw();
        }

        public void moveRight()
        {
            lastX = x;

            x = x + speed;
            this.Draw();
        }

        public void hitBall()
        {
            //Ball.hitHorizontal();
        }

        public void Draw()
        {
            FormMain.g.FillRectangle(Brushes.White, lastX - width / 2, y - height / 2 , width, height);
            FormMain.g.FillRectangle(Brushes.Blue, x - width/2 , y - height/2 , width, height);
        }

    }
}
