using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination_2
{
    public class Cuboid : Shape3D
    {
        //Cuboid consists of 3 doubles L, W ,H and then the base class is that it is a ShapeType Cuboid, and new Rectangle
        public Cuboid(double length, double width, double height)
            :base(ShapeType.Cuboid, new Rectangle(length, width), height)
        {
          
        }
    }
}