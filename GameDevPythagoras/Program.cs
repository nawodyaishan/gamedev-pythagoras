using System;
using System.Runtime.ConstrainedExecution;

namespace GameDevPythagoras
{
    /// <summary>
    /// Pythagoras Implementation for position calculation using C#
    /// </summary>
    class Program
    {
        // declaring x and y coordinates for player positions
        static float point1X;
        static float point1Y;
        static float point2X;
        static float point2Y;

 
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {
                // extract point coordinates from string
                GetInputValuesFromString(input);

                // calculate distance between points 1 and 2
                float distance = (float) Math.Sqrt((Math.Pow(point1X - point2X, 2) + Math.Pow(point1Y - point2Y, 2)));

                double angle = (float)Math.Atan2(point2Y - point1Y, point2X - point1X);

                angle *= (float)180/Math.PI;

                Console.WriteLine("The Distance Between Player A and B is " + (float) Math.Round(distance, 6));
                Console.WriteLine("The Angle from Player A to Player B is " + (float)Math.Round(angle, 5) + " degrees");
                input = Console.ReadLine();
                
                
            }
        }

        /// <summary>
        /// Extracts point coordinates from the given input string
        /// </summary>
        /// <param name="input">input string</param>
        static void GetInputValuesFromString(string input)
        {
            // extract point 1 x
            int spaceIndex = input.IndexOf(' ');
            point1X = float.Parse(input.Substring(0, spaceIndex));

            // move along string and extract point 1 y
            input = input.Substring(spaceIndex + 1);
            spaceIndex = input.IndexOf(' ');
            point1Y = float.Parse(input.Substring(0, spaceIndex));

            // move along string and extract point 2 x
            input = input.Substring(spaceIndex + 1);
            spaceIndex = input.IndexOf(' ');
            point2X = float.Parse(input.Substring(0, spaceIndex));

            // point 2 y is the rest of the string
            input = input.Substring(spaceIndex + 1);
            point2Y = float.Parse(input);
        }
    }
}

