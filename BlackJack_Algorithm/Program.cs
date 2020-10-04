using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examination_3
{
    public class Tjugoett
    {
        List<Spelare> spelarer = new List<Spelare>();
        Given given;
        //initierar Tjugoett, välj antal spelare
        public void initTjugoett()
        {
            /**Vi behöver OutputEncoding för att förstå värder av symboler**/
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Välkommen till Tjugoett Spelet");
            given = new Given("Given");
            /**välj antal spelare blir en int, och detta definerar vi som Spelval**/
            int Spelval = valjAntalSpelare();
            /**om det är mer än en spelare, aktiverar merSpelarer från int Spelval**/
            merSpelare(Spelval);
            /**vi kör alla spelare här */
            korAntalSpelare();
            Console.Read();
        }
        private void korAntalSpelare()
        {
            /**räknar hur många gånger körTjogoettAlgoritm kör beroende på spelare**/
            if (spelarer.Count == 1)
            {
            
                for (int i = 0; i < 10; i++)
                {
                    korTjugoettAlgoritm();
                }
            }
            else
            {
                korTjugoettAlgoritm();
            }
        }

        private int valjAntalSpelare()
        {
            int nr = 0;
            bool ingenval = true;
            while (ingenval)
            {
                Console.WriteLine("Välj nr av spelare du önskar: ");
                String Spelval = Console.ReadLine();
                if (int.TryParse(Spelval, out nr))
                {

                    if (nr < 1 || nr > 5)
                    {
                        /**om inmatning är fel, skriv ut följande:  **/
                        Console.Write("nr av spelare ska vara mellan 1 och 5.");
                    }
                    else
                    {
                        ingenval = false;
                    }
                }
            }
            return nr;
        }
        
        /**om vi får mer än 1 spelare då är det i++ */
        private void merSpelare(int plusSpelare)
        {
            for (int i = 1; i <= plusSpelare; i++)
            {
                spelarer.Add(new Spelare("spelare nr" + i, 13 + i));
            }
        }
        
        /**ny spel som initierar, vi får tillbaka alla korter i korthogen**/
        public void nyInitSpel()
        {
            foreach(Spelare spelare in spelarer)
            {
                List<Kort> korter = spelare.Sattikasthog();
                foreach(Kort kort in korter)
                {
                    given.Skrapakort(kort);
                }
                spelare.Instans.Varde = 0;
                spelare.Instans.Avarde = 0;
            }
            skrapaInstans();
        }
        //**nollställs allar värder, återvining av kortleken*//
        public void skrapaInstans()
        {
            List<Kort> korter = given.Sattikasthog();
            foreach (Kort kort in korter)
            {
                given.Skrapakort(kort);
            }
            given.Instans.Varde = 0;
            given.Instans.Avarde = 0;
        }

        /**algoritm för alla spelare**/ 
        public void korTjugoettAlgoritm()
        {
            foreach (Spelare spelare in spelarer)
            {
                while (spelare.Instans.Varde < spelare.StorstaVarde)
                {
                    spelare.Instans.Sattpakort(given.Nykort());
                }

                if (spelare.Sprukit())
                {
                    Console.WriteLine(spelare.Id + ": " + spelare.Instans.ToString() + " (" + spelare.Instans.Varde + ") sprukit--" );
                }
                else
                {
                    Console.WriteLine(spelare.Id + ": " + spelare.Instans.ToString() + " (" + spelare.Instans.Varde + ")");
                }
                if (spelare.Sprukit() == false)
                {
                    while (given.Instans.Varde < given.StorstaVarde)
                    {
                        given.Instans.Sattpakort(given.Nykort());
                    }
                    if (given.Sprukit())
                    {
                        Console.WriteLine(given.Id + "     : " + given.Instans.ToString() + " (" + given.Instans.Varde + ") sprukit --");
                    }
                    else
                    {
                        Console.WriteLine(given.Id + "     : " + given.Instans.ToString() + " (" + given.Instans.Varde + ")");
                    }
                }
                else
                {
                    Console.WriteLine(given.Id + "     : -");
                }    

                if (spelare.Instans.Varde >21)
                {
                    Console.WriteLine("given vinner");
                }
                else if ( given.Instans.Varde >21)
                {
                    Console.WriteLine("spelaren vinner");
                }
                else if (spelare.vinner())
                {
                    Console.WriteLine("spelaren vinner med alla kort");
                }
                else if (spelare.Instans.Varde > given.Instans.Varde)
                {
                    Console.WriteLine("spelaren vinner");
                }
                else
                {
                    Console.WriteLine("given vinner");
                }
                Console.WriteLine();
                nyInitSpel();
            }
        }
    }
    class Program
    {   
        static void Main(string[] args)
        {      
            /**definerar en ny Tjugoett kallad Tjugoett, sen kallar vi initTjugoett**/
            Tjugoett Tjugoett = new Tjugoett();
            Tjugoett.initTjugoett();
        }
    }
}