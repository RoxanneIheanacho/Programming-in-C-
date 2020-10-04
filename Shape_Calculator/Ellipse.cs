using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination_2
{ 

    public class Ellipse : Shape2D 
    {
        //determining Ellipse with double diameter 
        public Ellipse(double diameter) 
            :base(ShapeType.Ellipse, diameter, diameter)
        {
          
        }
        //determining Ellipse class with double diameter, hdiameter and vdiameter
        public Ellipse(double hdiameter, double vdiameter)
            : base(ShapeType.Ellipse, hdiameter, vdiameter)
        {

        }
        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords
        public override double Area
        {
            get
            {//area is Math.PI 3.14etc, and then the base length and base width (base class is base)
                return  Math.PI * base.Length * base.Width;
            } 
        }

        public override double Perimeter
        {
            get 
            {
                //calculation of perimeter using Math.Sqrt for square root and Math.pow = power 
                return Math.Sqrt(Math.Pow(base.Length, 2)*2 + Math.Pow(base.Width, 2)*2)*Math.PI ;
            }
        }
        /**https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/user-defined-conversion-operators
        Use the operator and implicit or explicit keywords to define an implicit or explicit conversion, respectively. The type that defines a conversion must be either a source type or a target type of 
        that conversion. A conversion between two user-defined types can be defined in either of the two types.*/
        public static implicit operator double(Ellipse v)
        { //implementation exception is thrown here  if its not implemented then it throws an exception
            throw new NotImplementedException();
        }
    }
}