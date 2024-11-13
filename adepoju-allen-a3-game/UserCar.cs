
         using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Game10003
{ //circle radius

    public class userCar
    {   //lets set raius for circlw
        public float radius = 30f;
        Vector2 input = new Vector2(400, 500);
        //lets store position
        public Vector2 position = new Vector2(Random.Float(0, 800), Window.Height);
        public void Update()
        {
            GetPlayerInput();
            Collisions();
            position += input * 50 * Time.DeltaTime;
        }
        //lets get player input and draw circle at position

        //lets store player input
        void GetPlayerInput()
        {
            Draw.FillColor = Color.Red;
            Draw.Circle(input, radius);
            if (Input.IsKeyboardKeyDown(KeyboardInput.Left)) { input.X -= 17; }
            if (Input.IsKeyboardKeyDown(KeyboardInput.Right)) input.X += 17;
            /*
            if (Input.IsKeyboardKeyDown(KeyboardInput.Up)) { input.Y -= 17; }
            if (Input.IsKeyboardKeyDown(KeyboardInput.Down)) { input.Y += 20; }*/
        }
            //lets set window collision
        void Collisions()
        {
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
       