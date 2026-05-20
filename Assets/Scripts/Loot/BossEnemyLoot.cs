using System.Collections.Generic;

public class BossEnemyLoot : ILoot
{
    public List<string> GenerateLoot()
    {
        return new List<string>
        {
            "weapon",
            "gold"
        };
    }
}