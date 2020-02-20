using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float bulletDamage;
    [SerializeField] private float bulletLifeTime;

    // Update is called once per frame
    void Update()
    {
        bulletLifeTime -= Time.deltaTime;
        if(bulletLifeTime <= 0)
        {
            DestroyBullet();
        }

        transform.position +=  transform.forward * Time.deltaTime * bulletSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("hit");
            other.GetComponent<HealthSystem>().TakeDamage(bulletDamage);
        }
    }

    void DestroyBullet()
    {
        Destroy(this.gameObject);
    }
}
