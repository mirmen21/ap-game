using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAccept : MonoBehaviour
{
    //Both GameObjects must contain a Collider component. One must have Collider.isTrigger enabled, 
    //and contain a Rigidbody. If both GameObjects have Collider.isTrigger enabled, 
    //no collision happens. 

    public string tagName;
    private Renderer meshRenderer;
    public Material newMat;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<Renderer>();
        meshRenderer.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == tagName)
        {
            meshRenderer.sharedMaterial = newMat;
            Destroy(other.gameObject);
        }
    }
}
