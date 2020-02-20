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

    void DestroyBullet()
    {
        Destroy(this.gameObject);
    }
}
