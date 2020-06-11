using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MultipleTalk : MonoBehaviour
{

    public Transform player;
    public GameObject popUpBox;
    public Material newMat;
    private bool isActive;
    private Renderer meshRenderer;

    public string[] dialogue = new string[5];
    private int currentNum;

    public TMP_Text popUpText;
    public int popUpTime = 0;

    void Start()
    {
        meshRenderer = GetComponent<Renderer>();
        meshRenderer.enabled = true;
        currentNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        if (dist <= 4f && Input.GetMouseButtonDown(0))
        {
            PopUp(dialogue[currentNum]);
            currentNum++;
        }
        if(currentNum == 5)
        {
            currentNum = 0;
        }
        if (isActive)
        {
            popUpTime++;
        }
        if (popUpTime >= 450) //change time with experimentation
        {
            isActive = false;
            popUpTime = 0;
            popUpBox.SetActive(false);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Glasses")
        {
            meshRenderer.sharedMaterial = newMat;
            Destroy(other.gameObject);
            dialogue[3] = "''I remember the last person who came into this gallery.. said something about an illusion?''";
            dialogue[4] = "''Please take me out with you''";

         }
    }

    private void PopUp(string text)
    {
        popUpBox.SetActive(true);
        isActive = true;
        popUpText.text = text;

    }
}
