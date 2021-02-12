using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minion : MonoBehaviour
{
    private int maxHealth;
    private int value;
    public float startSpeed;
    [HideInInspector]
    public float speed;
    private int currentHealth;
    public HealthBar healthbar;

    void Start()
    {
        maxHealth = 100;
        value = 10;
        startSpeed = 1.5f;
        speed = startSpeed;
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.SetCurrentHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void SlowDown(float slowPercent)
    {
        speed = startSpeed * (1f - slowPercent);
    }

    void Die()
    {
        PlayerStatus.money += value;
        Destroy(gameObject);
    }
}
