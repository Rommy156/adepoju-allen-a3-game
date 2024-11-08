using Game10003;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace adepoju_allen_a3_game
{
    public class FasterCars 
    {
        public Vector2 speed = new Vector2(0, 10);
        public float radius = 30f;
         Vector2 position;

        public void Setup() 
        {
            position = new Vector2(700, Window.Height);
        }
        public void FastCars()
        {
            Draw.FillColor = Color.Green;
            Draw.Circle(position, radius);
        }
       
        public void Update()
        {
            position += speed * Time.DeltaTime;
            FastCars(); ; 
        }
    }
}
