// Include code libraries you need below (use the namespace).

using adepoju_allen_a3_game;
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
        public Vector2 position = new Vector2(Random.Float(0, 800), Window.Height);
        //circle radius
        float radius = 30f;
        //array of cars 
        public Vector2[] randomCars =
        {
            new (Random.Float(0,250)),
            new (Random.Float(250,550)),
            new (Random.Float(550,800))
        };
        public npcCar[] npcCars;
        public static bool End = false;
        public static bool Win = false;

        userCar userCar = new userCar();
        npcCar NpcCar = new npcCar();
        FasterCars FasterCar = new FasterCars();

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {   //lets set up window size and fps
            Window.SetSize(800, 600);
            Window.TargetFPS = 60;

            SetupNpcCars();
            FasterCar.Setup();
            NpcCar.Setup();
        }
        /// <summary>
        ///     Update runs every frame.
        /// </summary>

        private void SetupNpcCars()
        {
            npcCars = new npcCar[10];
            for (int i = 0; i < npcCars.Length; i++)
            {
                npcCars[i] = new npcCar();
                npcCars[i].Setup();
            }
        }
        public void Update()
        {   //set background color
            Window.ClearBackground(Color.Gray);
            //loop in the update
            foreach (var car in npcCars) { car.Update(); }
            if (position.Y > Window.Height)
            {
                position = new Vector2(Random.Float(0, Window.Width), 0);

                { Draw.Circle(position, radius); }
            }
            //lets draw other cars on the road ;

            NpcCar.Update();
            FasterCar.Update();
            userCar.Update();


            //circle collision 
            float circleRadii = userCar.radius + NpcCar.radius;
            bool doCirclesColl = Vector2.Distance(userCar.position, NpcCar.position) <= circleRadii;
            //game win/lose logic
            if (doCirclesColl)
            {
                End = true;
                if (doCirclesColl && position.X < Window.Width)
                {
                    {
                        if (Game.Win)
                        {
                            Text.Draw($"YOU WON!", new Vector2(50, 50));
                        }
                        if (Game.End)
                        {
                            Text.Draw($"YOU LOSE!", new Vector2(50, 50));
                        }
                    }

                }
            }
        }
    }
}
    
    

