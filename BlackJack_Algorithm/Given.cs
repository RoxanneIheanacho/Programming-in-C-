using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination_3
{
    //Given arvar från spelare
    public class Given : Spelare
    {
        private Kortlek givdeck;
        //given har base med id 
        /**In the inheritance hierarchy, always the base class constructor is called first. In c#, 
        the base keyword is used to access the base class constructor as 
        shown below. ... The other base class constructor 
        is executed when we pass parameters while instantiating the object.
        https://vkinfotek.com/oops/base-class-constructor-csharp-net.html#:~:text=Calling%20base%20class%20constructor%20in%20C%23&text=In%20the%20inheritance%20hierarchy%2C%20always,class%20constructor%20as%20shown%20
        below.&text=The%20other%20base%20class%20constructor,parameters%20while%20instantiating%20the%20object./**/
        public Given(string id)
            : base(id, 15)
        {
            //givdeck skapas ett ny kortleck av 52 kort
            givdeck = new Kortlek(true);
        }
        /**kanske inte bästa gramatik, men vi vill skrapa ner kort från kort listan här, vi kasta från givdeck**/
        public void Skrapakort(Kort kort)
        {
            givdeck.kasta(kort);
        }

        //kortleck givdeck som returnerar kortleck 
        //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/default
        //A default value expression produces the default value of a type. There are 
        //two kinds of default value expressions: the default operator call and a default literal.
        public Kortlek Givdeck
        {
            get
            {
                return default(Kortlek);
            } 
            set{}
        }
        //vi vill få ut default Spelare i Given classet 
        public Spelare Spelare
        {
            get => default(Spelare);
            
            set
            {
            }
        }
        //kasthog som har en getter från default Kortlek
        
        public Kortlek Kasthog
        {
            get => default(Kortlek); 
            set
            {
            }
        }
        //har får man en nykort från givdeck som går till nasta kort i kortleken
        public Kort Nykort()
        {
            return givdeck.Nastakort();
        }
        // kastar dealers kort i skräphögen
        
    }
}