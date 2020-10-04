using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination_3
{
    public class Kortlek
    {
        //vill ha en list av kort och sen en med en kasthog
        /**Represents a strongly typed list of objects that can be accessed by index.
         Provides methods to search, sort, and manipulate lists.
         https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netcore-3.1 **/
        private List<Kort> korter = new List<Kort>();
        private List<Kort> kasthog = new List<Kort>();

        //alla värder av en kort (siffror)
        private string[] siffror = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        
        //symbol till kort spel som anpasssar med siffror

        //** det här är unicode av symboler man vill ha för kortspel https://www.youtube.com/watch?v=eGKQhr1HxzU**/
        private string[] symboler = { "\u2660","\u2666", "\u2663", "\u2665"  };

        /**det här är en lista med fler kort**/
        public List<Kort> Korter 
        { get  => korter; set => korter = value;}

        /** det här kommer vara getter setter av public Kasthogen som vi vill ha getter setter av alla kort som kan 
        varas med **/ 
        public List<Kort> Kasthog 
        { get => korter; set => korter = value;}
        
        //fisher yates blandning av kortspel
        
        public void Blandakort()
        {
            Random random = new Random();
            for (int i = korter.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                Kort temporary = korter[i];
                korter[i] = korter[j];
                korter[j] = temporary;
            }
        }
        /** hur c# ska tänka om alla symboler och siffror 

        You use void as the return type of a method (or a local function)
         to specify that the method doesn't return a value. **/
        public void init()
        {
            foreach(string symbol in symboler)
            {
                foreach (string siffra in siffror)
                {
                    Korter.Add(new Kort(symbol, siffra));
                }
            }
        }
        /** initierar kortlek med parameter boolean givdeck**/

        public Kortlek(bool givdeck)
        {
            if (givdeck)
            {
                init();
            }
            Blandakort();
        }
        //kasta kort till kasthog
        public void kasta(Kort kort)
        {
            kasthog.Add(kort);
        }

        //skapar kortlek från kasthog
         public void initkortlek()
        {
            foreach(Kort kort in kasthog)
            {
                korter.Add(kort);
            }
            kasthog = new List<Kort>();
        }
        //får fram nästa kort 
        public Kort Nastakort()
        {
            if (korter.Count < 1)
            {
                initkortlek();
                Blandakort();
            }
            /**index av kort i korter**/
            Kort nk = korter[0];
            korter.RemoveAt(0);
            return nk;
        }
    }
}