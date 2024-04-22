namespace ConsoleApp1;

class Character : CharacterBase
{
    private List<Guid> _buffs;

    public Character(Stats stats) : base(stats)
    {
        _buffs = new List<Guid>();
    }

    public void ApplyBuff(string buffName)
    {
        Buff? buff = Buffs.GetBuffByName(buffName);
        if(buff != null)
        {
            _buffs.Add(buff.Id);
            _modifiers = BuffCalculator.CalculateModifiers(_buffs);
        }
    }

    public void RemoveBuff(string  buffName)
    {
        Buff? buff = Buffs.GetBuffByName(buffName);
        if (buff != null)
        {
            _buffs.Remove(buff.Id);
            _modifiers = BuffCalculator.CalculateModifiers(_buffs);
        }
    }

    public void TakeDamage(int damage)
    {
        _hp -= damage - _modifiers.Strength;
    }

    public override string ToString()
    {
        return $"HP: {_hp}, Strength: {_stats.Strength}+{_modifiers.Strength}, Agility: {_stats.Agility}+{_modifiers.Agility}, Intellect: {_stats.Intellect}+{_modifiers.Intellect}, Stamina: {_stats.Stamina}+{_modifiers.Stamina}";
    }
}
