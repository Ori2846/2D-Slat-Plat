using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform firePoint;
    void Start()
    {

    }

    void Update()
    {
        if  (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        Instantiate(BulletPrefab, firePoint.position,firePoint.rotation);
    }
}
