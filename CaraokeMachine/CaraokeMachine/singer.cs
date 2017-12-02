using System;
using System.Collections.Generic;
using System.Text;

namespace CaraokeMachine
{
    public class singer
    {
        //by making the method static, that's mean we don't have t instatiate the singer
        public static void WriteLine (string line)
        {
            var results = line.Split(':');
            WriteLine(results[0],int.Parse(results[1]));
        }
        public static void WriteLine (string line, int time)
        {
            //how long it will take for each charackter to e load
            var speed = line.Length;
            foreach (var letter in line.ToCharArray())
            {
                Console.Write(letter);
                //this method tell the application stop donig everything for some miliseconds
                System.Threading.Thread.Sleep(speed);

            }
            Console.WriteLine("");
            
        }
    }
}
