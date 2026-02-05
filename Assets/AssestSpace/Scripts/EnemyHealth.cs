using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject explosionFX;
    private void OnTriggerEnter(Collider other) => Die();
    private void Die()
    {
        var explosion = Instantiate(explosionFX, transform.position, Quaternion.identity);
        Destroy(explosion, 2f);
        Destroy(gameObject);
    }
}
