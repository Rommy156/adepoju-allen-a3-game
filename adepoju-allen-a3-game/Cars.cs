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
        
        public Cars(Vector2 initialPos)
        {
            Draw.Rectangle(position, speed);
        }

        public void Update() 
        {   
            
        }

      
       
        


    }
}
