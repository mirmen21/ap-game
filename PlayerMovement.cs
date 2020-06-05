using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float jumpHeight = 3f;

    Vector3 velocity;
    public float gravity = -9.81f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask; //to set which objects the GroundCheck considers to be ground

    bool isGrounded;

 
    private void Update()
    {

        //uses the invisible groundCheck object attatched to player to see if it's touchign the ground
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); //true if collision

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; //keeps + forces player on ground 
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //transform is the position + orientation of the object
        Vector3 move = transform.right * x + transform.forward * z; //transform takes direction player is facing

        controller.Move(move * speed * Time.deltaTime); //time.deltatime makes frame rate independent

        velocity.y += gravity * Time.deltaTime;

        //multiply by time once more, for free fall equation 
        controller.Move(velocity * Time.deltaTime);

        //jumping. make sure it's grounded so you can't jump in air 
        if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }


    }
}
