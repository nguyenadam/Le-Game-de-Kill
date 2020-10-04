using System.Collections;
using System.Collections.Generic;
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

    }

    void FollowPlayer()
    {

        transform.position = player.transform.position + displacement;
    }
}
