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
        Vector3 pos = Vector3.zero;
        pos.x = Input.GetAxis("HorizontalPlayer2");
        pos.y = Input.GetAxis("VerticalPlayer2");
        pos = pos.normalized;
        //transform.position += pos * Time.deltaTime * MoveSpeed;
        //Navn.normalized g�r at vektoren altid er samme l�ngde (S�tter den altid til 1) og fikser ekstra speed p� diagonal. 
        //Fordi vektoren er det samme skal man gange med variabel og s�tte navn.y/x til 1.
        pos *= MoveSpeed;
        rb.velocity = pos;
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
