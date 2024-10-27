// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        //lets creat variable to store input 
        Vector2 input = new Vector2 (400,550);
        //lets store position
        Vector2 postion;
       

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {   //lets set up window size and fps
            Window.SetSize(800, 600);
            Window.TargetFPS = 60;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {   Window.ClearBackground(Color.Gray);
            Draw.Circle(input, 30);    
            //lets store player input
            void GetPlayerInput() {
                if (Input.IsKeyboardKeyDown(KeyboardInput.Left)) {input.X -= 10;}
                if (Input.IsKeyboardKeyDown(KeyboardInput.Right)) { input.X += 10;}}
            GetPlayerInput();

            postion += input * 100 * Time.DeltaTime;
            

        }
    }
}
