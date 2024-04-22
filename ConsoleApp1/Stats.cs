namespace ConsoleApp1;

public class Stats
{
    public int Strength { get; private set; }
    public int Agility { get; private set; }
    public int Intellect { get; private set; }
    public int Stamina { get; private set; }

    public Stats(int strength, int agility, int intellect, int stamina)
    {
        Strength = strength;
        Agility = agility;
        Intellect = intellect;
        Stamina = stamina;
    }

    public Stats()
    {
        Strength = 0;
        Agility = 0;
        Intellect = 0;
        Stamina = 0;
    }

    public static Stats operator+(Stats lhs, Stats rhs)
    {
        return new Stats(
            lhs.Strength + rhs.Strength,
            lhs.Agility + rhs.Agility,
            lhs.Intellect + rhs.Intellect,
            lhs.Stamina + rhs.Stamina);
    }
}
