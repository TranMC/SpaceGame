using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed;
    public int damage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var health = collision.GetComponent<Health>();
        if (health != null)
        {
            health.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
        }
        Destroy(gameObject);
    }
}
