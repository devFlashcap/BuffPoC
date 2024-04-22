namespace ConsoleApp1;

public abstract class CharacterBase
{
    protected int _hp;

    protected Stats _stats;
    protected Stats _modifiers;

    protected CharacterBase(Stats stats)
    {
        _stats = stats;
        _modifiers = new Stats();
        _hp = 100;
    }
}
