using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float health = 30f;
    public animation script;
    
    public void Takedamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
        Debug.Log("enemy_Die");

        if (gameObject.CompareTag("Enemy"))
        {
            script.anistart();
            Debug.Log("enemy_here");

        }
    }   
  
}
