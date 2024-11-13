using Game10003;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Game10003
{
    public class npcCar
    {   //lets store position
        public Vector2 position = new Vector2(Random.Float(0, 800), 0);
        //define gravity
        public Vector2 gravity = new Vector2(0, +30);
        //arrays of cars 
        public Vector2[] randomCars = new Vector2[10];
        //set circle radius
        public float radius = 30f;
        //define speed
        public Vector2 speed = new Vector2(0, 0);
        public void Setup()
        {
            for (int i = 0; i < randomCars.Length; i++)
                position = new Vector2((Random.Float(0, 800)), 0);
        }
        public void SimGravity( )
        {   //lets simulate gravity to make our cars move
            speed += gravity * Time.DeltaTime;
            position += speed * Time.DeltaTime;
        }

        public void Update()
        {
            DrawCars();
            SimGravity();
        }
             void DrawCars()
            { 
                //lets draw car ar position
                Draw.FillColor = Color.Yellow;
                Draw.Circle(position, radius);
            }

        
    }
    
}