using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;

    // Update is called once per frame
    private void Start()
    {
        transform.LookAt(transform.parent.forward);
    }

    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }
}
