using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    internal class ProgrammaEventi
    {
        public string Titolo { get; set; }
        public List<Evento> Eventi { get; private set; }


        public ProgrammaEventi(string titolo)
        {
            this.Titolo = titolo;  
            this.Eventi = new List<Evento>();
        }   

        // aggiungi evento alla lista
        public void AddEvent(Evento evento)
        {
            this.Eventi.Add(evento);
        }


        // ricerca per data
        public void SearchEventByDate()
        {
            List<Evento> tempEvents = new List<Evento>();
            Console.WriteLine("Inserire data per cercare eventi: ");
            string SDate = Console.ReadLine();
            DateTime date = Convert.ToDateTime(SDate);

            foreach (Evento evento in this.Eventi)
            {
                if(evento.Date == date)
                {
                    tempEvents.Add(evento);
                }
            }
            Console.WriteLine("Gli eventi presenti in data: " + date);
            foreach(Evento evento in tempEvents)
            {
                Console.WriteLine("Nome Evento" + evento.Titolo);
            }
        }


        // stampa lista
        public static void StampEventsList(List<Evento> eventi)
        {
            foreach (Evento eventItem in eventi)
            {
                eventItem.ToString();
            }
        }

        // conteggio eventi
        public void CountEvents()
        {
           Console.WriteLine("Numero eventi in programma: " + this.Eventi.Count());
        }


        // svuota lista eventi
        public void EmptyListEvent()
        {
            this.Eventi.Clear();
        }


        // mostra programma eventi
        public string ShowProgramEvents()
        {
            string program = "Nome programma eventi " + this.Titolo;
            foreach(Evento evento in this.Eventi)
            {
                program += evento.ToString();
            }
            return program;
        }
    }
}
