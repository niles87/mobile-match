using System.Collections.Generic;
using UnityEngine;

public class DamageGenerator
{
    public float Damage(string weaponType)
    {
        var baseDamage = weaponType switch
        {
            "UpgradedWeapon" => Random.Range(10f, 30f),
            "LegendaryWeapon" => Random.Range(20f, 60f),
            "EnemyMelee" => Random.Range(5f, 15f),
            "EnemyAdvanced" => Random.Range(10f, 30f),
            "EnemyRanged" => Random.Range(10f, 20f),
            _ => Random.Range(5f, 20f),
        };

        float criticalHitChance = Random.Range(0f, 100f);

        if (criticalHitChance > 90f)
        {
            baseDamage *= Random.Range(1.1f, 2f);
        }

        return baseDamage > 100f ? 100 : baseDamage;
    }
}
