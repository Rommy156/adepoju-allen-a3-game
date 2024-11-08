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
        public Vector2 gravity = new Vector2(0, +30);
        public Vector2[] randomCars = new Vector2[100];
        //set circle radius
        public float radius = 30f;
        public Vector2 speed = new Vector2(0, 0);
        public int randomNum = Random.Integer(0,99);
        public void Setup()
        {
                for (int i = 0; i < randomCars.Length; i++)
             
                    {
                         { Draw.Circle(position, 30); }
                    }
                
        }
        public void SimGravity()
        {   //lets simulate gravity to make our cars move
            speed += gravity * Time.DeltaTime;

            position += speed * Time.DeltaTime;
        }

        public void Update()
        {

            DrawCars();
            SimGravity();
        }
        public void DrawCars()
        {
            Draw.FillColor = Color.Yellow;
            Draw.Circle(position, radius);
        }
    

    }
    
}