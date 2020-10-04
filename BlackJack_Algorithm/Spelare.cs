using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination_3
{
    public class Spelare
    {
        /**vi behöver en privat Instans för Spelare för varsin spelare**/
        private Instans nyinstans;
        /**varje instans har en storstaVarde, och det behöver definera här med**/
        private int storstaVarde;

        /** detta kommer vara id av spelare..är det spelare 1 2 3 4 eller 5?**/

        private String id;
        
        public Spelare(string id, int storstaVarde)
        {
            this.Id = id;
            this.nyinstans = new Instans();
            this.storstaVarde = storstaVarde;
        }

        /**publik int av privat storstaVarde**/
        public int StorstaVarde
        {
            get 
            {
                return storstaVarde;
            }
        }
        public string Id { get => id;set => id = value;}

        /**här får vi public Instans som blir Instans från privata nyinstans**/
        public Instans Instans { get => nyinstans; }

        /**spelarens kod behöver veta vad Sprukit betyder, då vi returnerar koden från Instans**/ 
         public bool Sprukit()
        {
            return Instans.Sprukit();
        }
        /**återvinning av kort, vi sätter kort i kasthog*/
         public List<Kort> Sattikasthog()
        {
            List<Kort> atervining = new List<Kort>();
            foreach (Kort kort in nyinstans.Kortinstans)
            {
                atervining.Add(kort);
            }
            nyinstans.Kortinstans = new List<Kort>();
            return atervining;
        }

        //boolean som deklarerar om man vinner från class Instans
        public bool vinner()
        {
            return Instans.vinner();
        }
        
    }
}