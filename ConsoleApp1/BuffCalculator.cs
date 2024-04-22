namespace ConsoleApp1;

public static class BuffCalculator
{
    public static Stats CalculateModifiers(List<Guid> buffIds)
    {
        Stats modifiers = new Stats();
        foreach (Guid buffId in buffIds)
        {
            Buff? buff = Buffs.GetBuffById(buffId);
            if (buff == null) continue;
            modifiers += buff.Modifiers;
        }

        return modifiers;
    }
}
