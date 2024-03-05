using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playeraim : MonoBehaviour
{
    public Transform Spawner;
    public Transform Gun;
    public GameObject projectileprefab;
    public float ProjectileSpeed;
    public float BulletDestroyTime;

    Vector2 Gundirection = Vector2.one;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal2") != 0 || Input.GetAxis("Vertical2") != 0)
            Gundirection = new Vector2(Input.GetAxis("Horizontal2"), Input.GetAxis("Vertical2"));
        Gun.right = Gundirection;

        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("over 0");
            GameObject spawnedProjectile = Instantiate(projectileprefab,Spawner.position, Quaternion.identity);
            Rigidbody2D rbOnProjectile = spawnedProjectile.GetComponent<Rigidbody2D>();
            rbOnProjectile.velocity = Gundirection.normalized * ProjectileSpeed;
            Destroy(spawnedProjectile, BulletDestroyTime);
        }
    }
}
