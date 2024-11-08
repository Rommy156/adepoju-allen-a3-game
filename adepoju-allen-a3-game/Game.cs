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
            new (Random.Float(0,250),0),new (Random.Float(250,550)), new (Random.Float(550,800))
        };
        public npcCar[] npcCars = new npcCar[100];
        

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
           

            FasterCar.Setup();
            NpcCar.Setup();
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
            
            NpcCar.Update();
            FasterCar.Update();
            userCar.Update();
          
        }
    }
    
    
}
