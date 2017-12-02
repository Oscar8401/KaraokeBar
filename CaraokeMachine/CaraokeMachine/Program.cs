using System;
using System.IO;

namespace CaraokeMachine
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //creating an array to hold the song that we want to be able to play
            var songs = new string[] {"Sia", "Tove", "Walk" }; //the name of the song should be the name of the txt file
            Console.WriteLine("Welcome to Singer!\n");
            while (true)
            { 
            Console.WriteLine("Please choose the song you'd like to sing\n");
  
            Console.WriteLine("1) Sia ");
            Console.WriteLine("2) ToveLo");
            Console.WriteLine("3) Walk the moon");
            Console.WriteLine("Type 'Quit' to quit the application");


            var response = Console.ReadLine();
                if (response.ToLower() == "quit")
                {
                    break;
                }
                //try to parse the first arrgment which is response and if it is successfull then will populate the second argument which is song 
                var song = 0;
                if (!int.TryParse(response, out song))
                {
                    Console.WriteLine("Invalid input try again");
                    //it stop to execute any further code inside this loop and starts the loop over from the begining 
                    continue;
                }
                //-- decrenets to one, because arrays count from 0
                //so when they choose number one we want to reference the song at the index 0
                song--;
                var fileName = songs[song] + ".txt";
                //to print out the filename(the song from the array)
                Console.WriteLine(fileName);

                if (!File.Exists(fileName))
                {
                    Console.WriteLine("File not found, try again");
                    continue;
                }
                var lines = File.ReadAllLines(fileName);
                Console.WriteLine("*************************************");

                foreach (var line in lines)
                {
                    singer.WriteLine(line);
                }

                Console.WriteLine("*************************************");
            }
        }
    }
}