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
        Vector2 Gundirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        gun.right = Gundirection;

        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("over 0");
            GameObject spawnedProjectile = Instantiate(projectileprefab, gun.position, Quaternion.identity);
            Rigidbody2D rbOnProjectile = spawnedProjectile.GetComponent<Rigidbody2D>();
            rbOnProjectile.velocity = Gundirection * ProjectileSpeed;
            Destroy(spawnedProjectile, BulletDestroyTime);
        }
    }
}
