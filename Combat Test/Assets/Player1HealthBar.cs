using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1HealthBar : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 10f;
    private PlayerMove movement;

    // Start is called before the first frame update
    void Start()
    {
        movement = FindObjectOfType<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if (movement.HealthUpdate == 1)
        {
            TakeDamage(1);
            movement.HealthUpdate = 0f;
        }

    }

    public void TakeDamage(float damage)
    {
        healthAmount -= damage;
        healthBar.fillAmount = healthAmount / 10f;
    }

    public void Heal(float healingAmount)
    {
        healthAmount += healingAmount;
        healthAmount = Mathf.Clamp(healthAmount, 0, 10);

        healthBar.fillAmount = healthAmount / 10f;
    }


}
