using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int speed = 5;
    ArrayList inventories = new ArrayList();
    ArrayList mainInventory = new ArrayList();
    

    // Start is called before the first frame update
    void Start()
    {
        inventories.Add(mainInventory);
    }

    // Update is called once per frame
    void Update()
    {
        Move();

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

    public Boolean AddItem(Item item)
    {
        ArrayList hands = (ArrayList)inventories[0];     
        hands.Add(item);
        Debug.Log(item + " was added to inventory.");
        return true;
    }
}
