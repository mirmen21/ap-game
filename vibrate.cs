using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vibrate : MonoBehaviour
{
    private Vector3 originPosition;
    private bool vib;

    void Update()
    {
        // float x = Input.GetAxis("Horizontal");
        //transform.position.x = Mathf.Sin(Time.deltaTime * speed) * amount;
        vib = !vib;

        if (vib)
            //transform.Translate(Vector3.forward);
            transform.position += Vector3.forward * .25f;
        else
            transform.position += Vector3.forward * -.25f;
            //transform.Translate(Vector3.forward * -1);

    }
}
