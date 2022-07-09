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
        public List<Evento> eventi;

        public ProgrammaEventi(string titolo)
        {
            Titolo = titolo;  
        }   


        public void AddEvent(Evento evento)
        {
            this.eventi.Add(evento);
        }

        public void SearchEventByDate()
        {
            List<Evento> tempEvents = new List<Evento>();
            Console.WriteLine("Inserire data per cercare eventi: ");
            string SDate = Console.ReadLine();
            DateTime date = Convert.ToDateTime(SDate);

            foreach (Evento evento in this.eventi)
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

        public static void StampEventsList(List<Evento> eventi)
        {
            foreach (Evento eventItem in eventi)
            {
                eventItem.ToString();
            }
        }


        public void CountEvents()
        {
            Console.WriteLine("Numero eventi in programma: " + this.eventi.Count());
        }

        public void EmptyListEvent()
        {
            this.eventi.Clear();
        }

        public string ShowProgramEvents()
        {
            string program = "Nome programma eventi" + this.Titolo;
            foreach(Evento evento in this.eventi)
            {
                program += evento.ToString();
            }
            return program;
        }
    }
}
