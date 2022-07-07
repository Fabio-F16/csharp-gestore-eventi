namespace csharp_gestore_eventi
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Console.WriteLine("Inserisci il nome del nuovo evento: ");
            string titoloEvento = Console.ReadLine();

            Console.WriteLine("Inserisci la data dell'evento (gg/mm/yyy): ");
            DateOnly dataEvento = System.DateOnly.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci il numero dei posti totali: ");
            int postiTotali = Int32.Parse(Console.ReadLine());
            

            Evento evento = new Evento(titoloEvento, dataEvento, postiTotali);
            Console.WriteLine(evento.ToString());
            
        }
    }
}