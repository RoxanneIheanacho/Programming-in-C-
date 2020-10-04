using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination_2
{ 
    
    public class Sphere : Shape3D 
    {
         
        public Sphere(double diameter) 
        //base class är instance av sphere
            : base(ShapeType.Sphere, new Ellipse(diameter),0) 
        { 
            Diameter = diameter;
        }
        public double Diameter 
        {
            get
            {
                return Width *2;            
            }
            set
            {//sets value of base class Width, Length Height
                base.Width = value;
                base.Length = value;
                base.Height = value;
            }
        }  
        public override double MantelArea

        {
            get
            { //returns private baseshape of subclass base 
                return base._baseShape.Area * 4;
            }
        }

        //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/override
        //The override modifier is required to extend or modify the abstract or virtual 
        //implementation of an inherited method, property, indexer, or event.
        public override double TotalSurfaceArea
        {
            get
            {
                return MantelArea;
            }
        }
        
        //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/override
        //vi behöver override när en värde är skapat av en "abstract class"
        public override double Volume
        {
            get
            {
                return base._baseShape.Area * base.Width * 4 / 3;
            }
        }

    
    }
}