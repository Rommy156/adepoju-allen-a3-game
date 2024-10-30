using Game10003;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Game10003
{
    public class Cars
    {
        //declare variables 
        public Vector2 speed;
        public Vector2 position;
        public Cars[] cars;
        /* public Vector2 cpucars = Random.Vector2();*/
        public Vector2 gravity = new Vector2(0, +10);
        public void SimGravity()
        {
            Vector2 gravityForce = gravity * Time.DeltaTime;
            speed += gravityForce;
            position += speed;
        }
        public Cars(Vector2 initialPos)
        {
            Draw.Rectangle(position, speed);
        }

        public void Update() 
        {   
            SimGravity(); 
            DrawCar(); 
        }

        //array of class type
        public Cars(int numberOfCars)
        {
            cars = new Cars[numberOfCars];
            for (int i = 0; i < numberOfCars; i++)
            {
                // Initialize cars with random positions
                cars[i] = new Cars(new Vector2(100 + i * 50, 500));
            }
            foreach (var car in cars) { Draw.Circle(30, 20, 20); }

        }
        private void DrawCar() {
            Draw.FillColor = Color.Green;
            Draw.Circle(30, 20, 20);
                }


    }
}
