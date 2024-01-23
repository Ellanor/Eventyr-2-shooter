using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        Vector3 newposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newposition.z = 0;

        Vector3 vectorbetweenaimAndPlayer = newposition - gun.position;
        vectorbetweenaimAndPlayer = vectorbetweenaimAndPlayer.normalized;
        gun.right = vectorbetweenaimAndPlayer;

        if (Input.GetMouseButtonDown(0))
        {
            GameObject spawnedProjectile = Instantiate(projectileprefab, gun.position, Quaternion.identity);
            Rigidbody2D rbOnProjectile = spawnedProjectile.GetComponent<Rigidbody2D>();
            rbOnProjectile.velocity = vectorbetweenaimAndPlayer * ProjectileSpeed;
            Destroy(spawnedProjectile, BulletDestroyTime);
        }
    }
}
