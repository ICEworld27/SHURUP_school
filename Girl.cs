using System;
using System.Collections.Generic;
using System.Text;

namespace Classi5
{
    class Girl : Student
    {
        public override int DoExercise()
        {
            Random rnd = new Random();
            int value = rnd.Next(5,25);
            Console.WriteLine("Я сделала " + value + " приседаний");
            return value;

        }
    }
}
