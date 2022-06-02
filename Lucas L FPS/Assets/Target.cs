using UnityEngine;

public class Target : MonoBehaviour
{   // ställer in health och tar bort item när den "dör"
    public float health = 50f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}