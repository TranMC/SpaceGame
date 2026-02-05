using UnityEngine;

public class PlayerHealth : Health
{
    public int defaultHealthPoint;
    private int healthPoint;
    protected override void Die()
    {
        base.Die();
        Debug.Log("Player has died.");
    }
    private void Start() => healthPoint = defaultHealthPoint;

    private void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return;
        healthPoint -= damage;
        if (healthPoint <= 0) Die();
    }

}