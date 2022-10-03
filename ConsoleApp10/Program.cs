using ConsoleApp10.Lesson5;

namespace MyApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Bmw bmw1 = new Bmw("BMW", new Engine(4, 2), Colors.Gray, false);
            Lada lada = new Lada("LADA", new Engine(3, 2), Colors.Gray, false);
            Lada lada2 = new Lada("VAZ 21 x6", new Engine(6, 2), Colors.Gray, false);
            Lada lada3 = new Lada("GEASD", new Engine(6, 2), Colors.Gray, false);

            Race race = new Race();
            Menu menu = new Menu();
            
            IMovable[] movables = menu.MenuRaceSummary(new IMovable[]{bmw1, lada, lada2, lada3});
            int[] places = await race.StartRace(movables, 1f);

            for (int i = 0; i < places.Length; i++)
            {
                Console.WriteLine(((Car)movables[places[i]]).Name);
                ((Car)movables[places[i]]).GetIndividualInfo();
            }
            
            Console.WriteLine(Race.cout);
        }
    }
}
