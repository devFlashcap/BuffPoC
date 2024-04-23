namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Character character = new Character();
        var maxHealth = character.Stats.GetResourceValue(CharacterResourceType.Health)?.Max;

        Console.ReadKey();
    }
}
