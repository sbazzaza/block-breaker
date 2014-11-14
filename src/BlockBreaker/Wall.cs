using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace BlockBreaker
{
    public class Wall
    {
        public int depth = 5;
        public int width;
        public int height;
        int menuHeight;
        public Wall(int menuHeight)
        {
            this.menuHeight = menuHeight;
        }

        public void hitWallHorizontal()
        {
            //Ball.hitHorizontal();
        }

        public void hitWallVertical()
        {
            //Ball.hitVertical();
        }

        public void Draw()
        {
            FormMain.g.FillRectangle(Brushes.Yellow, 0, 0, depth, height);

            FormMain.g.FillRectangle(Brushes.Yellow, width - depth, 0, depth, height);

            FormMain.g.FillRectangle(Brushes.Yellow, 0, menuHeight, width, depth);
        }
    }
}
