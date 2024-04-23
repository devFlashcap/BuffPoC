namespace ConsoleApp1;

class Character
{
    public CharacterStats Stats { get; private set; }

    public Character()
    {
        Stats = new CharacterStats();
    }
}
