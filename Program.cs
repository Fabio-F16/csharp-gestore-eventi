namespace csharp_gestore_eventi
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Evento evento = new Evento("hvv", DateOnly.FromDateTime(DateTime.MaxValue), 1000);
            evento.ToString();
            
        }
    }
}