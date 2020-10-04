using System;


namespace examination_2
{
    public abstract class Shape2D : Shape
    {
        /**privat värde _length, width som är i abstract class Shape2D som används
        av Rectangle och Ellipse*/
        private double _length;
        private double _width;
        protected Shape2D(ShapeType shapeType, double length, double width)
            : base(shapeType)
        {
            //sets Length and Width as values of length and width 
            Length = length;
            Width = width;
        }  
        public abstract double Area
        {
            //gets abstract double Area 
            get;
        }        
        public double Length 
        {
            //returns private value of length 
            get 
            {
                return _length;
            }

            set
            {
                //sets the value and throws new exception argument to it 
               if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                else
                {
                    this._length = value;
                }
            }
        }

        public abstract double Perimeter
        /**abstract double perimeter, en värden som kan användas som "common definition"
         av abstract class*/
        
        {
            get;
        }

        public double Width
        {
            get
            {
                return _width;
            }

            set
            {
                if (value <= 0)
                {
                     //sets the value and throws new exception argument to it 
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                else
                {
                    //global privat width är värden
                    this._width = value;
                }
            }
        }
       
        public override string ToString()
        {
            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-override-the-tostring-method
            //this is what "G" would present if not for "R", is the override ToString of values
            /**When you create a custom class or struct, you should override the ToString 
            method in order to provide information about your type to client code.*/
            string createNew = "";
            //the values of L, W, P, A toString 
            createNew += "Length : " + Length.ToString() + "\t";
            createNew += "Width : " + Width.ToString() + "\t";
            createNew += "Perimeter: " + Perimeter.ToString() + "\t";
            createNew += "Area : " + Area.ToString();

            return createNew;
        }
        public string ToString(string setformat)
        {
            //will return the ints and doubles rounded to first decimal to string as a table
            string L = Math.Round(Length, 1).ToString();
            string W = Math.Round(Width,1).ToString();
            string P = Math.Round(Perimeter,1).ToString();
            string A = Math.Round(Area,1).ToString();
            switch (setformat)
            {
                case "R": 
                return ShapeType.ToString() + "  |" + L + "   |" + W + "   |" + P + "   |" + A;
                case "G":
                return ToString();
                case null: 
                return ToString();
                default:
                 //sets throws new exception argument if setformat does not equal any of the cases 
                throw new FormatException("Only R, G, or null calls the ToString method");
            }
        }
    }
}