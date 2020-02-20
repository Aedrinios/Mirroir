using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform muzzle;
    // Update is called once per frame

    void Update()
    {
        Debug.Log("i'm here");
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("I shoot");
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, muzzle.position, Quaternion.LookRotation(transform.right));
    }
}
