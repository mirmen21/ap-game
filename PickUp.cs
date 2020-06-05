using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    public Transform player;
    public Transform playerCam;
    public float throwForce = 1;
    bool playerNear = false;
    bool beingCarried = false;
    private bool touchingWall = false;

    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        if(dist <= 4f)
        {
            playerNear = true;
        }
        else
        {
            playerNear = false;
        }

        if (playerNear && Input.GetButtonDown("Use"))
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = playerCam;
            beingCarried = true;
        }

        if (beingCarried)
        {
            if (touchingWall || Input.GetMouseButtonDown(1))
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                
            }

            if (touchingWall)
            {
                touchingWall = false;
            }

        }
    }

    //void OnTriggerEnter()
    //{
    //     if (beingCarried && other.tag == "tagNameIWantedToDetect")
    //    {
    //           touchingWall = true;
    //    }
    //  }

    void OnTriggerEnter(Collider other)
    {
        if(beingCarried && other.tag == "Wall")
        {
            touchingWall = true;
        }
    }

}
