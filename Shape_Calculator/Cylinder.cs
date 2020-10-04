using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination_2
{
    public class Cylinder : Shape3D
    {
        //Cylinder consists of the hdiameter, vdiameter, height and then the base class that includes the 2d Ellipse as its element
        public Cylinder(double hdiameter, double vdiameter, double height)
        /**base arver från public cylinder, där får vi ShapeType, och Ellipse */
            :base(ShapeType.Cylinder, new Ellipse(hdiameter, vdiameter), height)
        {
        }
    }
}