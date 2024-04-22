namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Character character = new Character(new Stats(10, 10, 10, 10));
        Console.WriteLine($"Initial stats -> {character}");

        character.TakeDamage(20);
        Console.WriteLine($"Take Damage 20 -> {character}");

        character.ApplyBuff("Kurvaeros");
        Console.WriteLine($"Applied buff Kurvaeros -> {character}");

        character.TakeDamage(20);
        Console.WriteLine($"Take Damage 20 -> {character}");

        character.RemoveBuff("Kurvaeros");
        Console.WriteLine($"Removed buff Kurvaeros -> {character}");

        character.TakeDamage(20);
        Console.WriteLine($"Take Damage 20 -> {character}");

        Console.ReadKey();
    }
}
