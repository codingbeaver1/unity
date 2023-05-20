using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemymanager : MonoBehaviour
{
    manegerp player;

    public float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<manegerp>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
