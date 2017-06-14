using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        Player player1, player2;
        public List<Ball> balllist;
        public Form1()

        {
            InitializeComponent();

            player1 = new Player(Paddle1, labelPlayer1);
            player2 = new Player(Paddle2, labelPlayer2);
            balllist = new List<Ball>();

            StartNewGame();
        }

        


        

        private void StartNewGame()
        {
            balllist.Add(new Ball(this, Ball, player1, player2));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            player1.ProcessMove();
            player2.ProcessMove();

            for(int i = balllist.Count  - 1 ; i >= 0; i--)
            {
                if(balllist[i].ProcessMove()) {
                    
                    balllist.RemoveAt(i);
                }
            }


           if(balllist.Count == 0)
            {
                StartNewGame();
            }
           
            
        }

        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            CheckKeys(e, true);
            
        }

        

        

        private void CheckKeys(KeyEventArgs e, bool isDown)
        {
            switch (e.KeyCode)
            {
               
                case Keys.Up:
                    player1.isUpPressed = isDown;
                    break;
                case Keys.Down:
                    player1.isDownPressed = isDown;
                    break;

                case Keys.Oemcomma:
                case Keys.W:
                    player2.isUpPressed = isDown;
                    break;
                case Keys.O:
                case Keys.S:
                    player2.isDownPressed = isDown;
                    break;

                case Keys.Escape:
                    Application.Exit();
                    break;

               
                    


            }
        }

        

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            CheckKeys(e, false);
            
        }

    }
}
