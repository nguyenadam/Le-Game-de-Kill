using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class CameraMover : MonoBehaviour
{

    public Player player;
    int speed;
    Vector3 displacement;

    // Start is called before the first frame update
    void Start()
    {
        speed = player.speed;
        displacement = transform.position - player.transform.position;
        transform.position = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
        LeftClick();
    }

    void FollowPlayer()
    {

        transform.position = player.transform.position + displacement;
    }

    void LeftClick()
    {
        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // the object identified by hit.transform was clicked
                // do whatever you want
                if(hit.transform.tag == "Item")
                {
                    player.AddItem(hit.transform.gameObject.GetComponent<Item>());
                    Destroy(hit.transform.gameObject);
                }
                
            }
        }
    }
}
