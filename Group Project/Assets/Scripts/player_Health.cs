using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Health : MonoBehaviour
{
    public int maxHealth = 3;
    public static int currentHealth;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            animator.SetBool("IsDead", true);
        }
    }

}
