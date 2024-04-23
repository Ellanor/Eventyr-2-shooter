using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2HealthBar : MonoBehaviour
{
    public Image healthBar2;
    public float healthAmount2 = 10f;
    private Player2Move movement;

    // Start is called before the first frame update
    void Start()
    {
        movement = FindObjectOfType<Player2Move>();
    }

    // Update is called once per frame
    void Update()
    {
        if (movement.HealthUpdate2 == 1)
        {
            TakeDamage2(1);
            movement.HealthUpdate2 = 0f;
        }

    }

    public void TakeDamage2(float damage)
    {
        healthAmount2 -= damage;
        healthBar2.fillAmount = healthAmount2 / 10f;
    }

    public void Heal2(float healingAmount)
    {
        healthAmount2 += healingAmount;
        healthAmount2 = Mathf.Clamp(healthAmount2, 0, 10);

        healthBar2.fillAmount = healthAmount2 / 10f;
    }

    

}
