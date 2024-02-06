using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playeraim : MonoBehaviour
{
    public Transform gun;
    public GameObject projectileprefab;
    public float ProjectileSpeed;
    public float BulletDestroyTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Gundirection = (Input.GetAxis("Horizontal2"));
        Gundirection.z = 0;
        gun.right = Gundirection;

        if (Input.GetButtonDown("ZR"))
        {
            GameObject spawnedProjectile = Instantiate(projectileprefab, gun.position, Quaternion.identity);
            Rigidbody2D rbOnProjectile = spawnedProjectile.GetComponent<Rigidbody2D>();
            rbOnProjectile.velocity = vectorbetweenaimAndPlayer * ProjectileSpeed;
            Destroy(spawnedProjectile, BulletDestroyTime);
        }
    }
}
