using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (Input.GetKeyDown("space"))
        {
            Jump();
        }
    }

    void Move()
    {
        Vector3 movement = new Vector3();

        movement.z += Input.GetAxis("Vertical");
        movement.x += Input.GetAxis("Horizontal");

        movement.Normalize();

        movement *= Time.deltaTime * speed;

        transform.position += movement;
    }

    void Jump()
    {
        Vector3 impulse = new Vector3(0f, 5.0f, 0.0f);
        GetComponent<Rigidbody>().AddForce(impulse, ForceMode.Impulse);
    }
}
