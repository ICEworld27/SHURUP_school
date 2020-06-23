using System;
using System.Collections.Generic;
using System.Text;

namespace Classi5
{
    class Boy : Student
    {
        public override int DoExercise()
        {
            Random rnd = new Random();
            int value = rnd.Next(17,25);
            Console.WriteLine("Я сделал " + value + " отжиманий");
            return value;

        }
    }
}
