namespace ConsoleApp1;

public class Buff
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public Stats Modifiers { get; private set; }

    public Buff(string name, Stats modifiers)
    {
        Id = Guid.NewGuid();
        Name = name;
        Modifiers = modifiers;
    }
}
