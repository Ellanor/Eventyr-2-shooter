using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float Speed =4; 
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
        //normalize sætter længden på vectoren til 1
        retning = retning.normalized;
        //transform.position += retning *Time.deltaTime * Speed;
        rb.velocity = retning * Speed;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
