using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhealth : MonoBehaviour
{
    
    public float enemy_health = 200;

    public void EnemyTakesDamage(float amount)
    {
        enemy_health -= amount;
        if (enemy_health <= 0f)
        {
            Die();
        }
        void Die()
        {
            Destroy(gameObject);
        }
    }
}
