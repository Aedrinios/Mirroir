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

    private AudioSource audioSource;
    [SerializeField] private AudioClip shootSound;
    [SerializeField] private AudioClip reloadSound;
    // Update is called once per frame

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (isReloading)
        {
            timer += Time.deltaTime;
            if(timer >= reloadTimer)
            {
                audioSource.clip = reloadSound;
                audioSource.Play();
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
        audioSource.clip = shootSound;
        audioSource.Play();
        Instantiate(bulletPrefab, muzzle.position, Quaternion.LookRotation(transform.right));
        isReloading = true;
    }
}
