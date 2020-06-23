using System;
using System.Collections.Generic;

namespace Classi5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student z;
            Random rnd = new Random();
            int s;
            int g = 0;
            for (int i = 0; i < 25; i++)
            {
                int r = rnd.Next(1, 2);
                if (r == 1)
                {
                    z = new Boy();
                    
                }
                else
                {
                    z = new Girl();
                    

                }
                s = z.DoExercise();
                if (s >= 20)
                {
                    g++;
                }
                

            }
            Console.WriteLine(g + " человек сдал(и) зачёт");
        }
    }
}

