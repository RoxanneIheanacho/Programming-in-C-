using System;

namespace examination_2
{
    public abstract class Shape3D : Shape 
    {
        protected Shape2D _baseShape; //association
        protected double _height;
     
        protected Shape3D(ShapeType shapeType, Shape2D baseShape, double height)
            : base(shapeType)
        {
            _baseShape = baseShape; //private baseShape= baseShape 
            _height = height;
        }

        public double Height 
        {
            get
            {
                return _height; //returns private height
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
                    this._height = value;
                }
            }
        }

        public double Length
        {
            get
            {
                return _baseShape.Length;
            }
            set
            {
                _baseShape.Length = value;
            }
        }

        public virtual double MantelArea
        {
            get 
            {
                    return _baseShape.Perimeter * 4; 
            }
        }

        public virtual double TotalSurfaceArea
        {
            get
            {
                    return _baseShape.Area * 2 + MantelArea;
            }

        }

        public double Width 
        {
            get
            {
                return _baseShape.Width;
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
                    this._baseShape.Width = value;
                }
            }
        }

        public virtual double Volume
        {
            get
            {
                return _baseShape.Area * _height;
            }
 
        }

        public override string ToString()
        {
            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-override-the-tostring-method
            //this is what "G" would present if not for "R", is the override ToString of values
            /**When you create a custom class or struct, you should override the ToString method in order to provide information about your type to client code.*/
            string createNew = ""; 
            createNew += "Length : " + Length.ToString() + "\t";
            createNew+= "Width : " + Width.ToString() + "\t";
            createNew += "Height : " + Height.ToString() + "\t";
            createNew += "Mantelarea :" + MantelArea.ToString() + "\t";
            createNew += "SurfaceArea: " + TotalSurfaceArea.ToString() + "\t";
            createNew += "Volume : " + Volume.ToString();

            return createNew;
        }

        public string ToString(string setformat)
        {
            //will return the ints and doubles rounded to first decimal to string as a table
            string L = Math.Round(Length,1).ToString();
            string W = Math.Round(Width, 1).ToString();
            string H = Math.Round(Height, 1).ToString();
            string MA = Math.Round(MantelArea, 1).ToString();
            string TSA = Math.Round(TotalSurfaceArea, 1).ToString();
            string V = Math.Round(Volume, 1).ToString();
            switch (setformat)
            {
                //R returns with ShapeType then values 
                case "R":
                return ShapeType.ToString() + "   |   " + L + "|   " + W + "|   " + H + "|   " +
                    MA + "|   " + TSA + "|   " + V;
                case "G":
                return ToString();
                case "":
                return ToString();
                default: 
                //throws format exception if none of the cases match the if options
                throw new FormatException("Only R, G, or null can call ToSting method");
            }
        
        }
    }
}