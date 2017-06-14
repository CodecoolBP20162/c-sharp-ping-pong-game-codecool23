using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public class Ball
    {
        Form1 form;
        private PictureBox ball, aballModel;
        Random rand = new Random();
        int xSpeed, ySpeed;
        Player leftPlayer, rightPlayer;
        public Ball(Form1 form, PictureBox ballModel, Player leftPlayer, Player rightPlayer)
        {
            this.form = form;
            aballModel = ballModel;
            this.ball = new PictureBox();
            this.ball.Size = aballModel.Size;
            form.Controls.Add(ball);
            this.ball.Image = ballModel.Image;
            this.leftPlayer = leftPlayer;
            this.rightPlayer = rightPlayer;
            xSpeed = 1;
            ySpeed = 2;
            ResetBall();
        }

        internal bool ProcessMove()
        {
            var bottom = PongWorldInfo.bottomWorld - ball.Height;
            ball.Location = new Point(ball.Location.X + xSpeed,
               Math.Max(PongWorldInfo.topWorld, Math.Min(PongWorldInfo.bottomWorld - ball.Height, ball.Location.Y + ySpeed)));
            if (ball.Location.Y >= bottom || ball.Location.Y <= PongWorldInfo.topWorld)
            {
                ySpeed *= -1;
            }

            if (ball.Location.X <= PongWorldInfo.leftOfWorld)
            {
                Score(leftPlayer);
                return true;
            } else if(ball.Location.X >= PongWorldInfo.rightOfWorld - ball.Width)
            {
                Score(rightPlayer);
                return true;
            }

            if(leftPlayer.paddle.Bounds.IntersectsWith(ball.Bounds)
                || rightPlayer.paddle.Bounds.IntersectsWith(ball.Bounds)) {
                xSpeed *= -2;
                //ySpeed *= 1;
               form.balllist.Add( new Ball(form, aballModel, leftPlayer, rightPlayer));
                
            }
            return false;
            
        }
        private void Score(Player winningPlayer)
        {
            winningPlayer.score++;
            form.Controls.Remove(ball);

        }

        private void ResetBall()
        {
            ball.Location = new Point((PongWorldInfo.leftOfWorld + PongWorldInfo.rightOfWorld) / 2, (PongWorldInfo.topWorld + PongWorldInfo.bottomWorld) / 2);
            do
            {
                xSpeed = rand.Next(-3, 3);
                ySpeed = rand.Next(-3, 3);
            } while (Math.Abs(xSpeed) + Math.Abs(ySpeed) <= 3 || Math.Abs(xSpeed) <= 1);
        }
    }
}

