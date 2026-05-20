using System;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    public Action OnDeath;

    private ILoot lootStrategy;

    public Enemy(ILoot strategy)
    {
        lootStrategy = strategy;
    }

    public List<string> GetLoot()
    {
        return lootStrategy.GenerateLoot();
    }

    public void Die()
    {
        Debug.Log("Enemy died");
        OnDeath?.Invoke();
    }
}