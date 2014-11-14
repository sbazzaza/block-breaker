using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace BlockBreaker
{
    public class Game
    {
        Ball ball;
        Wall wall;
        Plate plate;
        public int Score = 0;
        public bool GameOver = false;
        public static int width = 400;
        public static int height = 500;
        int menuHeight;

        public Game(int menuHeight)
        {
            this.menuHeight = menuHeight;
            ball = new Ball(300, 150, 1, -1, Brushes.Green, Brushes.White);
            wall = new Wall(menuHeight);
            plate = new Plate();

            plate.x = (width / 2);
            plate.y = (height) - plate.heightFromFloor;

            wall.width = width;
            wall.height = height;
        }

        public void Draw()
        {
            FormMain.g.Clear(Color.White);
            plate.Draw();
            wall.Draw();
            printScore(0);
        }

        public void Move()
        {


            if (ball.y + (ball.speed * ball.dy) < wall.depth + ball.radious + menuHeight)
                ball.hitHorizontal();

            else if (ball.x + (ball.speed * ball.dx) < wall.depth + ball.radious)
                ball.hitVertical();

            else if (ball.x + (ball.speed * ball.dx) > width - ball.radious - wall.depth)
                ball.hitVertical();

            else if (ball.y + (ball.speed * ball.dy) > plate.y - plate.height / 2 - ball.radious)
            {
                if ((ball.x + (ball.speed * ball.dx) > plate.x - plate.width / 2 ) && (ball.x + (ball.speed * ball.dx) < plate.x + plate.width / 2))
                {
                    ball.hitHorizontal();
                    Score++;
                    printScore(Score);
                }
                else
                {
                    gameOver();
                }
            }

            ball.move();
            ball.Draw();
        }

        public void printScore(int Score)
        {
            FormMain.g.FillRectangle(Brushes.White, width - 100, height - 35, 75, 20);
            FormMain.g.DrawString("Score : " + Score, new Font("tahoma", 10), Brushes.Black, new PointF(width - 100, height - 35));
        }

        public void gameOver()
        {
            GameOver = true;
            MessageBox.Show("GameOver");
        }

        public void RightKey()
        {
            if ((plate.width/2 + plate.x + plate.speed) < width - wall.depth)
            {
                plate.moveRight();
            }
        }

        public void LefttKey()
        {
            if ((plate.x - plate.speed - plate.width/2) > wall.depth)
            {
                plate.moveLeft();
            }
        }

    }
}
