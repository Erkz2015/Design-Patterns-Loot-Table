using System.Collections.Generic;

public class CommonEnemyLoot : ILoot
{
    public List<string> GenerateLoot()
    {
        return new List<string>
        {
            "gold"
        };
    }
}