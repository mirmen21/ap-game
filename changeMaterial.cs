using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeMaterial : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    private Renderer meshRenderer;
    private int matNumber = 1;
    public Material[] materialList = new Material[3];

    void Start()
    {
        meshRenderer = GetComponent<Renderer>();
        meshRenderer.enabled = true;
        ray.origin = transform.position;
        ray.direction = transform.right;
    }

    void Update()
    {
        
        //Debug.DrawRay(ray.origin, ray.direction * 100, Color.red);
      

        if (Physics.Raycast(ray.origin, ray.direction, out hit, 4) && hit.transform.gameObject.tag == "Player")  //out confirms that something will be returned by the function
        {
            matNumber = (matNumber) % 3 + 1;

            if (matNumber == 1)
                meshRenderer.sharedMaterial = materialList[0];
            if (matNumber == 2)
                meshRenderer.sharedMaterial = materialList[1];
            if (matNumber == 3)
                meshRenderer.sharedMaterial = materialList[2];

        }
    }
}
