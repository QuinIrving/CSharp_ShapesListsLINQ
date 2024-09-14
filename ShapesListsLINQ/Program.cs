using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesListsLINQ
{
    class Program
    {
        public static string getShape()
        {
            Console.WriteLine("Please select shape to process or [Q]uit:\n" +
                "[C]ircle\n" +
                "[R]ectangle\n" +
                "[S]quare\n" +
                "[T]riangle");
            // reads what shape the user wants to process (or quit)
            return Console.ReadLine();
        }
        public static void createCircle()
        {
            // prompts and reads the values needed to create a circle then sends it to the printing function
            Console.Write("Please enter circle radius: ");
            Circle c = new Circle(double.Parse(Console.ReadLine()));
            printObj(c);
        }
        public static void createRectangle()
        {
            // prompts and reads the values needed to create a rectangle then sends it to the printing function
            Console.Write("Please enter rectangle length: ");
            double l = double.Parse(Console.ReadLine());
            Console.Write("Please enter rectangle width: ");
            double w = double.Parse(Console.ReadLine());
            Rectangle r = new Rectangle(l, w);
            printObj(r);
        }
        public static void createSquare()
        {
            // prompts and reads the values needed to create a square then sends it to the printing function
            Console.Write("Please enter square side: ");
            double si = double.Parse(Console.ReadLine());
            Square sq = new Square(si);
            printObj(sq);
        }
        public static void createTriangle()
        {
            // prompts and reads the values needed to create a triangle then sends it to the printing function
            Console.Write("Please enter triangle side a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please enter triangle side b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Please enter triangle side c: ");
            double c = double.Parse(Console.ReadLine());
            Triangle t = new Triangle(a, b, c);
            printObj(t);
        }
        public static void printObj(Shape _s)
        {
            // prompts the user for what they want outputted for the shape they are processing
            Console.WriteLine("Please select output:\n" +
                "[A]rea\n" +
                "[P]erimeter\n" +
                "[B]oth");
            string c = Console.ReadLine();
            // based on response, print what the user desires
            switch (c)
            {
                case "A":
                case "a":
                    Console.WriteLine("Area: " + Math.Round(_s.Area(), 2) );
                    break;
                case "P":
                case "p":
                    Console.WriteLine("Perimeter: " + Math.Round(_s.Perimeter(), 2) );
                    break;
                case "B":
                case "b":
                    Console.WriteLine("Area: " + Math.Round(_s.Area(), 2) );
                    Console.WriteLine("Perimeter: " + Math.Round(_s.Perimeter(), 2) );
                    break;
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("PART A\n------");
            bool exit = false;
            string c;
            // keep on processing shapes until they quit
            do
            {
                c = getShape();
                Console.WriteLine("");
                switch (c)
                {
                    case "C":
                    case "c":
                        createCircle();
                        break;
                    case "R":
                    case "r":
                        createRectangle();
                        break;
                    case "S":
                    case "s":
                        createSquare();
                        break;
                    case "T":
                    case "t":
                        createTriangle();
                        break;
                    case "Q":
                    case "q":
                        exit = true;
                        break;
                }
            } while (!exit);

            // All of the LINQ section
            Console.WriteLine("PART B\n------\n");
            LINQ l = new LINQ();
            l.DivisibleByTwo();
            Console.WriteLine("");
            l.NumbersInRange();
            Console.WriteLine("");
            l.CityInformation();

            // All of the lists section
            Lists list = new Lists();
            Console.WriteLine("\nStudent Averages:");
            list.displayStudentScore();
            Console.WriteLine("\n\nSubject Averages:");
            list.displaySubjectScore();
            Console.WriteLine("\n");
            list.displayMinMaxStudent();
            Console.WriteLine("");
            list.displayMinMaxSubject();
            Console.ReadLine();
        }

    }
}
