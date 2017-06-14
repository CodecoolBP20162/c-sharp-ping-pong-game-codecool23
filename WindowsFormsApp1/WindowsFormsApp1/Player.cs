using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public class Player
    {
        const int movementspeed = 3;

        public bool isUpPressed, isDownPressed;

        public PictureBox paddle;
        Label scoreLabel;
        bool? wasGoingUp;
        int numberOfTickGoingInTheSameDirection;

        int _score;
        public int score
        {
            get
            {
                return _score;
            }
            set
            {
                _score = value;
                scoreLabel.Text = score.ToString();
            }
        }

        public Player(PictureBox paddle1, Label scoreLabel)
        {
            this.paddle = paddle1;
            this.scoreLabel = scoreLabel;
        }

        internal void ProcessMove()
        {
            bool? goingUp = null;


            if (isUpPressed)
            {
                goingUp = true;
            }
            if (isDownPressed)
            {
                if (goingUp.HasValue)
                {
                    goingUp = null;
                }
                else
                {
                    goingUp = false;
                }
            }

            if (wasGoingUp.HasValue)
            {
                if (!goingUp.HasValue)
                {
                    wasGoingUp = null;
                    numberOfTickGoingInTheSameDirection = 0;
                }
                else if (wasGoingUp.Value == goingUp.Value)
                {
                    numberOfTickGoingInTheSameDirection++;
                }
                else
                {
                    wasGoingUp = goingUp;
                    numberOfTickGoingInTheSameDirection = 1;
                }
            }
            else if (goingUp.HasValue)
            {
                wasGoingUp = goingUp;
                numberOfTickGoingInTheSameDirection = 1;
            }



            DoMove(goingUp);
        }

        private void DoMove(bool? goingUp)
        {
            if (goingUp.HasValue)
            {
                var speed = movementspeed * (numberOfTickGoingInTheSameDirection / 10);
                if (goingUp.Value)
                {
                    speed *= -1;
                }
                paddle.Location = new Point(paddle.Location.X,
                   Math.Max(PongWorldInfo.topWorld,
                  Math.Min(PongWorldInfo.bottomWorld - paddle.Height, paddle.Location.Y + speed
                   )
                   ));
            }

        }
    }
}
            
            

