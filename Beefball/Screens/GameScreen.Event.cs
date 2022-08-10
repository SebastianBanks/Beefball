using System;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Specialized;
using FlatRedBall.Audio;
using FlatRedBall.Screens;
using Beefball.Entities;
using Beefball.Screens;
namespace Beefball.Screens
{
    public partial class GameScreen
    {
        void OnPuckListVsGoalListCollisionOccurred (Entities.Puck puck, Entities.Goal goal) 
        {
            if (goal == LeftGoal)
            {
                player2Score++;
                ReactToNewScore();
            } 
            else if (goal == RightGoal)
            {
                player1Score++;
                ReactToNewScore();
            }
        }

        private void ReactToNewScore()
        {
            PlayerBall1.X = -180;
            PlayerBall1.Y = 0;
            PlayerBall1.Velocity = Microsoft.Xna.Framework.Vector3.Zero;
            PlayerBall1.Acceleration = Microsoft.Xna.Framework.Vector3.Zero;

            PlayerBall2.X = 180;
            PlayerBall2.Y = 0;
            PlayerBall2.Velocity = Microsoft.Xna.Framework.Vector3.Zero;
            PlayerBall2.Acceleration = Microsoft.Xna.Framework.Vector3.Zero;

            Puck1.X = 0;
            Puck1.Y = 0;
            Puck1.Velocity = Microsoft.Xna.Framework.Vector3.Zero;

            ScoreHUD1.Score1 = player1Score;
            ScoreHUD1.Score2 = player2Score;
        }
        
    }
}
