using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionFX;
    public void OnTriggerEnter2D(Collider2D collision) => Die();

    protected virtual void Die()
    {
        var explosion = Instantiate(explosionFX, transform.position, Quaternion.identity);
        Destroy(explosion, 2f);
        Destroy(gameObject);
    }
}