using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination_3
{

    public class Instans
    {
        //två värderingar, en för att få ut värde av "siffra"
        private int varde;
        //den andra för att få A värden (det kan vara 13 eller 1 beroende på Instans)
        private int avarde; //A värdering  
        //lista av korter blir kortinstans 
        private List<Kort> kortinstans = new List<Kort>();

        //har är public int, public värden av siffra beroende på "A" värden och alla andra siffror i listan
        
        public int Varde
        {
            get
            {
                if(varde >21 && Avarde >0)
                {
                    varde -= 13;
                    Avarde -= 1;
                }
                return varde;
            }
            set
            {
                this.varde = value;
            }
        }
        /**publik lista av kort för en Kortinstans som kommer delas ut för varsin spelare**/
        public List<Kort> Kortinstans
        {
            get
            {
                return kortinstans;
            }
            set
            {
                this.kortinstans = value;
            }
        }
        /**getter setter av public A vardering**/
        public int Avarde
        { get => avarde; set =>avarde = value; }
        public void bestamvarde(Kort kort)
        {
            /** på första hand ska A vara en 14 som varde av siffran **/

           if(kort.Siffra == "A")
            {
                varde += 14;
                Avarde++;
            }
            else if (kort.Siffra == "J")
            {
                varde += 11;
            }
            else if (kort.Siffra == "Q")
            {
                varde += 12;
            }
            else if (kort.Siffra == "K")
            {
                varde += 13;
            }
            else
            {
                //vi använder Parse metoden för att parsa alla andra sträng till en nummer som C# förstår
                varde += int.Parse(kort.Siffra);
            }
        }
        //**set på en kort i Instansen **/
        public void Sattpakort(Kort kort) //Satta på kort i värdering 
        {
            kortinstans.Add(kort);
            bestamvarde(kort);
        }
        /**det här är vår bool när Instansen blir högre en 21, då har spelaren sprukit., annars falsk**/
        public bool Sprukit()
        {
            
            if (varde > 21)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Om man har en sträng som returnerar en bokstav bestämmer vi siffra värden här 
        
        //räknar om hand instansen vinner, annars returnerar falsk
        public bool vinner()
        {
            if (kortinstans.Count >=5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            //här får vi till sträng metod för att sifta genom kort i kortinstans som returnerar Siffra plus Symbol
            string nyinstans = "";
            foreach(Kort kort in kortinstans)
            {
                nyinstans += kort.Siffra + kort.Symbol + " ";
            }
            return nyinstans;
        }
    }
}