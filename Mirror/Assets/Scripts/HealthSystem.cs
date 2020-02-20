using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] private GameObject hitParticle;

    private void Update()
    {
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Instantiate(hitParticle, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
    }
    
}
