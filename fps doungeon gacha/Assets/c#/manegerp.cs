using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manegerp : MonoBehaviour
{
    public static manegerp instance;

    void Awake()
    {
        instance = this;
        
    }
    public GameObject player;
}
