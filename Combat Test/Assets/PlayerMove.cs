using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    
    public Animator animator;
    [SerializeField]
    float MoveSpeed = 5f;
    public float HealthUpdate = 0f;
    [SerializeField]
    float Health = 10f;
    Rigidbody2D rb;
    public static bool GameOverUpdate = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Vector3.zero;
        pos.x = Input.GetAxis("Horizontal");
        pos.y = Input.GetAxis("Vertical");
        pos = pos.normalized;
        //transform.position += pos * Time.deltaTime * MoveSpeed;
        //Navn.normalized gør at vektoren altid er samme længde (Sætter den altid til 1) og fikser ekstra speed på diagonal. 
        //Fordi vektoren er det samme skal man gange med variabel og sætte navn.y/x til 1.
        pos *= MoveSpeed;
        rb.velocity = pos;
        //husk at bruge en rigidbody hvis movement skal virke
        if (Health == 0)
        {
            Destroy(gameObject);
            GameOverUpdate = true;
            
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "projectilePlayer2")
        {
            Health -= 1f;
            Destroy(collision.gameObject);
            HealthUpdate = 1f;
            animator.SetTrigger("dmg");
        }

    }
}

