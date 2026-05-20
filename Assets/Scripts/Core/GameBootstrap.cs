using UnityEngine;

public class GameBootstrap : MonoBehaviour
{
    private LootSystem lootSystem;

    void Start()
    {
        lootSystem = new LootSystem();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnAndKillEnemy();
        }
    }

    private void SpawnAndKillEnemy()
    {
        //Tijdelijke randomizer om te laten zien dat beide versies werken 
        int random = Random.Range(0, 2);
        Debug.Log("Random value: " + random);

        if (random == 0)
        {
            Enemy enemy = new Enemy(new CommonEnemyLoot());
            lootSystem.Subscribe(enemy);
            enemy.Die();
        }
        else
        {
            Enemy enemy = new Enemy(new BossEnemyLoot());
            lootSystem.Subscribe(enemy);
            enemy.Die();
        }
    }
}