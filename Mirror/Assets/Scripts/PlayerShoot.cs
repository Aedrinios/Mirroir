using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform muzzle;
    private bool isReloading;
    [SerializeField] private float reloadTimer;
    private float timer = 0f;
    // Update is called once per frame

    void Update()
    {
        if (isReloading)
        {
            timer += Time.deltaTime;
            if(timer >= reloadTimer)
            {
                timer = 0;
                isReloading = false;
            }
        }
        if (Input.GetButtonDown("Fire1") && !isReloading)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, muzzle.position, Quaternion.LookRotation(transform.right));
        isReloading = true;
    }
}
