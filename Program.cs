using constructeurs;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenue dans le programme de gestion des bâtiments!");

        Building BatA = new Building(40);

        Console.WriteLine("Batiment A");
        BatA.display();

    }

}