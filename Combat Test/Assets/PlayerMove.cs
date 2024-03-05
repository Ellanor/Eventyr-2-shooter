using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    float MoveSpeed = 5f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Vector3.zero;
        pos.x = Input.GetAxis("Horizontal");
        pos.y = Input.GetAxis("Vertical");
        pos = pos.normalized;
        //transform.position += pos * Time.deltaTime * MoveSpeed;
        //Navn.normalized g�r at vektoren altid er samme l�ngde (S�tter den altid til 1) og fikser ekstra speed p� diagonal. 
        //Fordi vektoren er det samme skal man gange med variabel og s�tte navn.y/x til 1.
        pos *= MoveSpeed;
        rb.velocity = pos;
        //husk at bruge en rigidbody hvis movement skal virke
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "projectilePlayer2")
        {
            Destroy(gameObject);
        }

    }
}
