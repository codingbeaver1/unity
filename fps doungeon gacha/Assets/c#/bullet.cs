using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {

        void Update()
        {
            if (collision.gameObject.name == "Player")
            {
                Debug.Log("Hit player");
            }

        }



        


    }
}
