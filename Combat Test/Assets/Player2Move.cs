using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Move : MonoBehaviour
{
    public static bool GameOverUpdate = false;
    public float HealthUpdate2 = 0f;
    [SerializeField]
    float MoveSpeed = 5f;
    [SerializeField]
    float Health2 = 10f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 retning = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            retning.y = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            retning.y = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            retning.x = 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            retning.x = -1;
        }
        //normalize s�tter l�ngden p� vectoren til 1
        retning = retning.normalized;
        //transform.position += retning *Time.deltaTime * Speed;
        rb.velocity = retning * MoveSpeed;
        if (Health2 == 0)
        {
            GameOverUpdate = true;
            Destroy(gameObject,0.1f);
            
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "projectilePlayer1")
        {
            Health2 -= 1f;
            Destroy(collision.gameObject);
            HealthUpdate2 = 1f;
        }

    }
}
