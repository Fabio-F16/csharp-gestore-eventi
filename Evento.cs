using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    internal class Evento
    {

        // attributi
        private string titolo;
        private DateOnly date;
        private int capienzaMassima;
        public int postiPrenotati { get; private set; }

        public string Titolo { 
            get{
                return this.titolo;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Il titolo non può essere vuoto");
                }

                this.titolo = value;
            }
        }
        public DateOnly Date { 
            get{
               
                return this.date;
            }
            set
            {
                if(value < DateOnly.FromDateTime(DateTime.Now))
                {
                    throw new ArgumentException("La data è passata");
                }
                this.date = value;
            }
        }
        public int CapienzaMassima { 
            get{               
                return this.capienzaMassima;    
            }
            protected set
            {
                if(value < 0)
                {
                    throw new ArgumentException("La capienza non può essere negativa");
                }
                this.capienzaMassima = value;
            }
        }
        
        

        // costruttore
        public Evento(string titolo, DateOnly date, int capienzaMassima)
        {
            this.Titolo = titolo;
            this.Date = date;
            this.CapienzaMassima = capienzaMassima;
        }


        // metodi
        public int PrenotaPosti(int numeroPostiDaPrenotare)
        {
            
            if(this.postiPrenotati > this.getPostiDisponibili())
            {
                throw new ArgumentNullException("Posti esauriti");
            }
            this.postiPrenotati += numeroPostiDaPrenotare;
            return this.postiPrenotati;
        }

        public int DisdiciPosti(int numeroPostiDaPrenotare)
        {
            this.postiPrenotati -= numeroPostiDaPrenotare;
            return this.postiPrenotati;
        }

        public int getPostiDisponibili()
        {
            int postiDisponibili = 0;
            postiDisponibili = this.CapienzaMassima - this.postiPrenotati;
            return postiDisponibili;
        }


        public void ToString()
        {
            Console.WriteLine("Il nome dell'evento è: " + this.Titolo);
            Console.WriteLine("La data dell'evento è: " + this.Date);
            Console.WriteLine("La capienza massima dell'evento è: " + this.capienzaMassima);

           // return base.ToString() + "\n" + "Il nome dell'evento è: " + this.Titolo + "\n" + "La data dell'evento è: " + this.Date + "La capienza massima dell'evento è: " +  this.capienzaMassima;
        }
    }
}
