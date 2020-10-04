using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination_2

{
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract will only be base class 
    public abstract class Shape
    {
        /**The abstract keyword enables you to create classes and class members that
         are incomplete and must be implemented in a derived class.An abstract class cannot be instantiated. The purpose of an abstract class
          is to provide a common definition of a base class that multiple derived classes can share
         https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/abstract-and-sealed-classes-and-class-members*/
 
        private ShapeType shapeType;
 
        protected Shape(ShapeType shapeType) 
        {
            /**skapar privat ShapeType some är shapetype "The protected keyword 
            is a member access modifier. A protected member is accessible within
             its class and by derived class instances. Using protected means you can have functionality in a
             class that's available to derived classes, but not to classes that
              just instantiate the object"
              https://stackoverflow.com/questions/3626690/protected-keyword-c-sharp*/
            ShapeType = shapeType;
        }

        public ShapeType ShapeType 
        {
            get
            {
                /**returns shapeType enumerable*/
                return shapeType;
            }
            private set
            {
                /*privat setter, shapeType värde*/
                this.shapeType = value;
            }   
        }
        public bool Is3D
        {
            get
            {
                /**om ShapeType är Cupid, Cylinder, Sphere, då är is3D till boolean true**/ 
                switch (ShapeType)
                {
                    case ShapeType.Cuboid:
                    return true;
                    case ShapeType.Cylinder:
                    return true;
                    case ShapeType.Sphere:
                    return true;
                    default: 
                    return false;
                }
            }
        }

        public abstract override string ToString();
        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-override-the-tostring-method
            //this is what "G" would present if not for "R", is the override ToString of values
            /**When you create a custom class or struct, you should override the 
            ToString method in order to provide information about your type to client code.*/
    }
}