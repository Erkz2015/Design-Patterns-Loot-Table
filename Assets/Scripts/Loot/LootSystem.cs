using UnityEngine;
using System.Collections.Generic;

public class LootSystem
{
    private ItemFactory factory;

    public LootSystem()
    {
        factory = new ItemFactory();
    }

    public void Subscribe(Enemy enemy)
    {
        enemy.OnDeath += () => OnEnemyDeath(enemy);
    }

    private void OnEnemyDeath(Enemy enemy)
    {
        List<string> loot = enemy.GetLoot();

        foreach (string itemType in loot)
        {
            IItem item = factory.CreateItem(itemType);

            Debug.Log(item.GetName());
        }
    }
}