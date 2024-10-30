// Include code libraries you need below (use the namespace).

using System;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

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
        Vector2 input = new Vector2(400, 550);
        //circle radius
        float radius = 30f;
        //lets store position
        Vector2 position;
        //lets store size
        Vector2 size;
        //array of cars 
        Cars[] randomCars = new Cars[100] ;
        //car colors 
        Color userColor = Color.White;
        Color cpuColor = Color.Red;

        UserCar userCar = new UserCar();

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {   //lets set up window size and fps
            Window.SetSize(800, 600);
            Window.TargetFPS = 60;
           
            for (int i = 0; i < randomCars.Length; i++)
            {
                // Initialize cars with random positions
                randomCars[i] = new Cars(Random.Vector2() );
            }
            foreach (var car in randomCars) { Draw.Circle(30, 20, 20); }
        }
        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Gray);
        
            /*
            randomCars = new cars() += 100* Time.DeltaTime;
            */
            
           
            //lets draw other cars on the road 
            



            //lets store player input
            void GetPlayerInput()
            {   Draw.Circle(input,radius);
                if (Input.IsKeyboardKeyDown(KeyboardInput.Left)) { input.X -= 17; }
                if (Input.IsKeyboardKeyDown(KeyboardInput.Right)) input.X += 17;

                if (Input.IsKeyboardKeyDown(KeyboardInput.Up)) { input.Y -= 17; }
                if (Input.IsKeyboardKeyDown(KeyboardInput.Down)) { input.Y += 20; }
            }
            GetPlayerInput();

            userCar = new UserCar();
          
            position += input * 100 * Time.DeltaTime;
            randomCars = new Cars[100];
 
            //lets set window collision
            float playerLeftEdge = input.X;
            float playerRightEdge = input.X + radius;
            float playerTopEdge = input.Y;
            float playerBottomEdge = input.Y + radius;

            bool isLeftOfScreen = playerLeftEdge <= 30;
            bool isRightOfScreen = playerRightEdge >= Window.Width;
            bool isAboveWindow = playerTopEdge <= 30;
            bool isBelowWindow = playerBottomEdge >= Window.Height;

            if (isLeftOfScreen || isRightOfScreen || isBelowWindow || isAboveWindow)
            {
                if (isLeftOfScreen) { input.X = 0 + radius; }
                if (isRightOfScreen) { input.X = Window.Width - radius; }
                if (isAboveWindow) { input.Y = 0 + radius; }
                if (isBelowWindow) { input.Y = Window.Height - radius; }
                
            
            }
        }
    }
    
    
}
