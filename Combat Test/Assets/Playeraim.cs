using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    public float bulletSpeed;
    public Transform gun;
    public GameObject bulletprefab;
    public Transform Spawner;
    public float BulletDestroyTime;

    // Update is called once per frame
    void Update()
    {
        Vector3 newposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newposition.z = 0;
        Vector3 vecBetweenAimAndPlayer = newposition - gun.position;
        vecBetweenAimAndPlayer = vecBetweenAimAndPlayer.normalized;
        gun.right  = vecBetweenAimAndPlayer;

        if (Input.GetMouseButtonDown(0))
        {
           //Debug.Log("jeg skyder");
            GameObject spawnedBullet = Instantiate(bulletprefab, Spawner.position, Quaternion.identity);
            Rigidbody2D rbOnBullet = spawnedBullet.GetComponent<Rigidbody2D>();
            rbOnBullet.velocity = vecBetweenAimAndPlayer * bulletSpeed;
            spawnedBullet.AddComponent<Projectile2>();
            Destroy(spawnedBullet, BulletDestroyTime);
        }

    }
}
