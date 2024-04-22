namespace ConsoleApp1;

public static class Buffs
{
    private static List<Buff> _buffs = new List<Buff>
    {
        new Buff("Kurvaeros", new Stats(10, 0, 0, 0)),
        new Buff("Kurvaokos", new Stats(0, 0, 10, 0)),
        new Buff("Kurvagyors", new Stats(0, 10, 0, 0)),
        new Buff("Kurvaszivos", new Stats(0, 0, 0, 10))
    };

    public static Buff? GetBuffById(Guid buffId)
    {
        return _buffs.FirstOrDefault(buff => buff.Id == buffId);
    }

    public static Buff? GetBuffByName(string name)
    {
        return _buffs.FirstOrDefault(buff => buff.Name == name);
    }
}
