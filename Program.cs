namespace csharp_gestore_eventi
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            
           Evento evento = CreaEvento();
           Prenotazioni(evento);











            // metodi 


            // prenota posti
            void Prenotazioni(Evento evento)
            {
                bool validator = true;

                Console.WriteLine();
                Console.WriteLine("*** PRENOTA POSTI ***");
                Console.Write("Inserire quanti posti si vogliono prenotare: ");
                int posti = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Posti prenotati: " + posti.ToString());
                evento.PrenotaPosti(posti);
                Console.WriteLine("Posti disponibili: " + evento.getPostiDisponibili());

                while (validator)
                {
                    Console.WriteLine("Vuoi disdire dei posti? (si/no)");
                    string risposta = Console.ReadLine();

                    if(risposta == "si")
                    {
                        Console.WriteLine("Quanti posti vuoi disdire?");
                        int numero = Int32.Parse(Console.ReadLine());
                        evento.DisdiciPosti(numero);
                        Console.WriteLine("Posti disponibili: " + evento.getPostiDisponibili());
                        validator = true;
                    }
                    else
                    {
                        Console.WriteLine("Ok va bene!");
                        validator = false;
                    }
                }
            }



            // creazione evento
            Evento CreaEvento()
            {
                Console.WriteLine("Inserisci il nome del nuovo evento: ");
                string titoloEvento = Console.ReadLine();

                Console.WriteLine("Inserisci la data dell'evento (gg/mm/yyy): ");
                DateTime dataEvento = System.DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Inserisci il numero dei posti totali: ");
                int postiTotali = Int32.Parse(Console.ReadLine());

                Evento evento = new Evento(titoloEvento, dataEvento, postiTotali);
                Console.WriteLine(evento.ToString());

                return evento;
            }

        }     
    }
}