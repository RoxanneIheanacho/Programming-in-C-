using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination_2
{
    public class Rectangle : Shape2D 
    {
        //rectangle is 2d so it consists of double L and W, with baseclass determining shapetype and L W 
        public Rectangle(double length, double width)
            :base(ShapeType.Rectangle, length, width)
        {
        }

        public override double Perimeter
        {
            get
            {
                /** 2 gånger base class property Length + 2 gånger base class property Width*/
                return 2 * base.Length + 2 * base.Width;
            }
        }
        public override double Area
        {
            get
            {
                /** base classes Length property times base classes width property for area*/
                return base.Length * base.Width;
            }
        }
    }
}
