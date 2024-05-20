using System.Security.Cryptography.X509Certificates;

namespace Assignment3._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            
            point.X = GetPoints('X');
            point.Y = GetPoints('Y');

            point.EvaluatePoint();
        }

        public static int GetPoints(char a)
        {
            string userInput = "0";
            do
            { 
            Console.WriteLine($"Please enter the {a} value of the point.");
            userInput = Console.ReadLine();   
            }while (userInput == "");

            return Convert.ToInt32(userInput);
        }
        
    }
    
    public class Point()
    { 

        internal int X { get; set; }
        internal int Y { get; set; }

        public void EvaluatePoint()
        {
            if (this.X >= 0 && this.Y >= 0)
            {
                FindQuadrant("First");
            }
            else if (this.X < 0 && this.Y >= 0)
            {
                FindQuadrant("Second");
            }
            else if (this.X < 0 && this.Y < 0)
            {
                FindQuadrant("Third");
            }
            else if (this.X >= 0 && this.Y < 0)
            {
                FindQuadrant("Fourth");
            }
        }

        public void FindQuadrant(string quadrant)
        {
            Console.WriteLine($"The coordinate point ({this.X},{this.Y}) lies in the {quadrant} Quadrant");
        }
    }
}
