using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace examination_2 
{
    class Program
    {
        static void Main(string[] args)
        {
            

            
            Console.WriteLine("  Figurativ Arv exam \n Choose 2D shapes by pressing [2] \n OR 3d shapes by pressing [3] ");   
            //newshape = inmatning av val (menyval), först sätter vi den till 0
            int newshape = 0;
            //vi kommer inte få något ut om newfalse är it false. just nu får vi ingenting
            bool newfalse = true;
            while (newfalse)
            { 
                String fstring = Console.ReadLine();
                if (int.TryParse(fstring, out newshape))
                {
                    if (newshape < 2 || newshape > 3)
                    {
                        //om värden stämmer inte med inmättning, får vi en meddelande
                        Console.WriteLine("Write 2 or 3 and then press enter");
                    }
                    else
                    {
                        //nu är värden skapat till 2 eller 3 newfalse är av, och nu kan vi köra programmet 
                        newfalse = false;
                    }
                }
            }
            //ny random int
            Random random = new Random();
            //om menyval blev 2..... 
            if (newshape == 2)
            {
                //vi skapar en lista av Shape2D som vi kallar för "figures"
                List<Shape2D> figures = new List<Shape2D>();
                //om int är 0 eller mindre än 10, kommer vi få ut mer ints tills det blir 10
                for (int i = 0; i < 10; i++)
                {
                    //ny random.next (next int av 1-100)
                    int newR = random.Next(1,100);
                    //ny random.nextdouble (next double)Returns a random 
                    //floating-point number that is greater than or equal to 0.0, and less than 1.0.
                    double newdouble = random.NextDouble();
                    //figure2d kommer vara mellan 1 och 4 med ny random
                    int figure2D = random.Next(1, 4);
                    if(figure2D == 1)
                    {
                        //.Add metoden skapar en ny instance av Ellipse, new double och new randon nr multipliceras
                        Console.BackgroundColor = ConsoleColor.Black;
                        figures.Add(new Ellipse(newdouble * newR));
                    }
                    else if (figure2D == 2)
                    {
                        //ny instance av ellipse om random.next blir 2
                        figures.Add(new Ellipse(newdouble * newR, newdouble * newR));
                    }
                    else
                    {
                        // annars (om random.next blir 3-4) ny instance av rectangle till listan
                        //multiplicerar värdena av Rectangle med random.next siffror 
                        figures.Add(new Rectangle(newdouble * newR, newdouble * newR ));
                    }
                }
                //det gör en "order" av ShapeType, sen order av siffror av property "area" till Listan
                List<Shape2D> newfigures = figures.OrderBy(x => x.ShapeType).ThenBy(x => x.Area).ToList();
                Console.BackgroundColor = ConsoleColor.Red;
                //toString "R" format vill vi få första raden av tabellen:
                Console.WriteLine("Shape    |Length|Width|Perimeter|Area|");
                Console.BackgroundColor = ConsoleColor.Black;
                foreach (Shape2D shape in newfigures)
                {
                    //forloop av shapes i listan skapar vi till metoden ToString "R" så att det listar rätt
                    Console.WriteLine(shape.ToString("R"));
                }
            }
            else
            {
                //annars skapar vi en lista av classen Shape3D var figures blir ny list av Shape3D
                List<Shape3D> figures = new List<Shape3D>();
                //om int är 0 men mindre än 10, plus plus tills det blir 10
                for (int i = 0; i < 10; i++)
                {
                    //samma egenskapar som Shape2d, vi vill få en int new Random
                    int newR = random.Next(1,100);
                    //double new next double
                    double newdouble = random.NextDouble();
                    int figure3D = random.Next(1, 4);
                    if (figure3D == 1)
                    {
                        //om ny random landar på 1 skapar vi en ny cuboid
                        Console.BackgroundColor = ConsoleColor.Black;
                        // vi multiplicerar ny värdena för att skapa egenskapernas värde 
                        figures.Add(new Cuboid(newdouble * newR, newdouble * newR, newdouble * newR));
                    }
                    else if (figure3D == 2)
                    {
                        //om det landar på 2 gör vi samma men med Sphere
                        figures.Add(new Sphere(newdouble * newR));
                    }
                    else
                    {
                        // vi får en ny instance av Cylinder i listan annars (3-4)
                        figures.Add(new Cylinder(newdouble * newR, newdouble * newR, newdouble * newR));
                    }
                }
                // sen vill vi att alla figures får en "order" sen till värden Volym, sen till Listan
                List<Shape3D> newfigures = figures.OrderBy(x => x.ShapeType).ThenBy(x => x.Volume).ToList();

                Console.BackgroundColor = ConsoleColor.Red;
                //med toString metoden, vill vi skapa första rad av tabellen så vi vet vad
                //för siffra blir vad
                Console.WriteLine("Shape   |Length|Width|Height|MantelArea|SurfaceArea|Volume");
                Console.BackgroundColor = ConsoleColor.Black;
                //for loop då får vi ut alla "shape" i newfigures
                foreach (Shape3D shape in newfigures)
                {
                    Console.WriteLine(shape.ToString("R"));
                }
            }
            //här läser vi inmatning av användaren
            Console.Read();
        }
    }
}