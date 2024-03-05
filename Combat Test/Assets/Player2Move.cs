using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Move : MonoBehaviour
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
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x = -1;
            Debug.Log("works");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x = 1;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.y = 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.y = -1;
        }
        pos = pos.normalized;
        //transform.position += pos * Time.deltaTime * MoveSpeed;
        //Navn.normalized gør at vektoren altid er samme længde (Sætter den altid til 1) og fikser ekstra speed på diagonal. 
        //Fordi vektoren er det samme skal man gange med variabel og sætte navn.y/x til 1.
        pos *= MoveSpeed;
        rb.velocity = pos;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "projectilePlayer1")
        {
            Destroy(gameObject);
        }

    }
}
