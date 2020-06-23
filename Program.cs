using System;
using System.Collections.Generic;

namespace Classi5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> s = new List<int> {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
            Student z;
            Random rnd = new Random();
            for (int i = 0; i < s.Count; i++)
            {
                int r = rnd.Next(1, 2);
                if (r == 1)
                {
                    z = new Boy();
                    s[i] = z.DoExercise();
                }
                else
                {
                    z = new Girl();
                    s[i] = z.DoExercise();
                }

            }
            int g = 0;
            for (int i = 0; i < s.Count; i++)
            {
                if (s[i] >= 20)
                {
                    g++;
                }
            }

        }
    }
}
