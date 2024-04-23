namespace ConsoleApp1;

struct CharacterStats
{
    public Dictionary<CharacterResourceType, ResourceValues> characterResources;

    public CharacterStats()
    {
        this.characterResources = new Dictionary<CharacterResourceType, ResourceValues>
        {
            {
                CharacterResourceType.Health,
                new ResourceValues
                {
                    Current = 100,
                    Max = 100
                }
            }
        };
    }

    public ResourceValues? GetResourceValue(CharacterResourceType resource)
    {
        if (!this.characterResources.ContainsKey(resource)) return null;
        return this.characterResources[resource];
    }
}
