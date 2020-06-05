using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 50f;
    public Transform playerBody;
    float xRotation = 0f;

    //Start is called before the first frame update
    void Start()
    {
        //lock cursor at center
        Cursor.lockState = CursorLockMode.Locked;
    }

    //Update called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;

        //clamping rotation so the player can't look down until they see behind them
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //quaternion returns a rotation around z, x, y axis (camera)
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        //rotate the physical player
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
