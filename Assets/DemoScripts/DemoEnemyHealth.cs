using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{

    protected override void Die()
    {
        base.Die();
        Debug.Log("Enemy has died!");
        LivingEnemyCount--;
    }

    public static int LivingEnemyCount;

    private void Awake() => LivingEnemyCount++;
}