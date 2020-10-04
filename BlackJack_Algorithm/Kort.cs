using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination_3
{
    public class Kort
    {
        //deklarerar privat varder för symbol och siffra 
        private string symbol; 
        private string siffra;
        //deklarerar publik Siffra från privat varde siffra
        public string Siffra
        {
            get
            {
                return this.siffra;
            }
            private set
            {
                this.siffra = value;
            }
        }

        //deklarerar publik varde för symbol från privat varden symbol 

        public string Symbol
        {
            get
            {
                return this.symbol;
            }
            set
            {
                this.symbol = value;
            }
        }
        //deklarerar Kort med Siffra och Symbol som värder 
        public Kort(string symbol, string siffra)
        {
            Symbol = symbol;
            Siffra = siffra;
        }
        //override ToString, får fram privat varden till public varden från getter och setters 

        public override string ToString()
        {
            return Siffra + Symbol;
        }
    }
}