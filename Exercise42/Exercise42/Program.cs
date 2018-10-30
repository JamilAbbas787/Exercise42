using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise42
{
    class Program
    {
        static void Main(string[] args)
        {
            string continueAnswer;
            do
            {
                var xCord = new Point();
                //xCord.Xcoordinate();
                var yCord = new Point();
                //yCord.Ycoordinate();

                Console.WriteLine($"You have created a point ({xCord.Xcoordinate()}, {yCord.Ycoordinate()})");

                Console.WriteLine("Would you like to continue (y/n): ");
                continueAnswer = Console.ReadLine();

            } while (continueAnswer.Equals("y",StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Goodbye!");
        }

    }

    class Point
    {

        public int Xcoordinate()
        {
            bool validateX;
            int xCoordinate;
            do
            {
                Console.Write("Enter your X coordinate: ");
                string xCoordinateString = Console.ReadLine();
                validateX = int.TryParse(xCoordinateString, out xCoordinate);

            } while (!validateX);

            return xCoordinate;

        }

        public int Ycoordinate()
        {
            bool validateY;
            int yCoordinate;

            do
            {
                Console.Write("Enter your Y coordinate: ");
                string yCoordinateString = Console.ReadLine();
                validateY = int.TryParse(yCoordinateString, out yCoordinate);

            } while (!validateY);

            return yCoordinate;
        }
                
    }
}
