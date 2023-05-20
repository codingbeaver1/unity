using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plaeyerhelth : MonoBehaviour
{
    Transform human;
    public float playerhelth1;

    public void playertakesdamage (float damage)
    {
        playerhelth1 -= damage;
        if (playerhelth1 <= 0f)
        {
            die();
        }
        void die()
        {
            Destroy(gameObject);
        }
    }
}
