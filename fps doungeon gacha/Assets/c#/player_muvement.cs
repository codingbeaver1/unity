using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_muvement : MonoBehaviour
{
    public CharacterController controler;

    public float speed = 12f;
    public float gravity = -9.81f;

    Vector3 velocity;
    bool isGraunded;

    public Transform graundcheck;
    public float groundDistance = 0.4f;
    public LayerMask graundMask;
    public float jumphight = 3f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        isGraunded = Physics.CheckSphere(graundcheck.position, groundDistance, graundMask);
        if (isGraunded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float X = Input.GetAxis("Horizontal");
        float Z = Input.GetAxis("Vertical");


        Vector3 muve = transform.right * X + transform.forward * Z;

        controler.Move(muve * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGraunded)
        {
            velocity.y = Mathf.Sqrt(jumphight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controler.Move(velocity * Time.deltaTime);
    }
}
