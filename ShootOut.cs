using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootOut : MonoBehaviour
{
    
    public GameObject player;
    public float scaleVal;
    public float posVal;

    private int ensureOnce; 
    private Vector3 scaleChange;
    private Vector3 positionChange; //to deal with the item expanding on both sides

    // Start is called before the first frame update
    void Start()
    {
       scaleChange = new Vector3(scaleVal, 0f, 0f);
       positionChange = new Vector3(posVal, 0f, 0f);
       ensureOnce = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (ensureOnce == 0 && (this.transform.position - player.transform.position).magnitude < 7.0f)
        {
            transform.localScale += scaleChange;
            transform.position += positionChange;
            ensureOnce++;
        }
    }
}
