// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;
using System.Runtime.ConstrainedExecution;

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
        cars[] randomCars;

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
        {
            Window.ClearBackground(Color.Gray);
            /*
            randomCars = new cars() += 100* Time.DeltaTime;
            */
            Draw.Circle(input, radius);
            
                //lets store player input
            void GetPlayerInput()
            {
                if (Input.IsKeyboardKeyDown(KeyboardInput.Left)) { input.X -= 17; }
                if (Input.IsKeyboardKeyDown(KeyboardInput.Right)) input.X += 17;
                /*
                if (Input.IsKeyboardKeyDown(KeyboardInput.Up)) { input.Y -= 1; }
                if (Input.IsKeyboardKeyDown(KeyboardInput.Down)) { input.Y += 2; }*/
            }
            GetPlayerInput();

            position += input * 100 * Time.DeltaTime;
            randomCars = new cars[100];
 
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
    
    //lets make a class for other cars

    public class cars
    { public float speed = 50f;
        public Vector2 position;
        public cars[] Cars;

        public cars(Vector2 initialPos) { }

           //array of class type
        public cars(int numberOfCars)
        {
            Cars = new cars[numberOfCars];
            for (int i = 0; i < numberOfCars; i++)
            {
                // Initialize cars with random positions
                Cars[i] = new cars(new Vector2(100 + i * 50, 500));
            }  foreach (var car in Cars) { Draw.Circle(30, 20, 20); }
        }
                
      
    }
}
