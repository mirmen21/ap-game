using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopUpSystem : MonoBehaviour
{
    public Transform player;
    public GameObject popUpBox;
    private bool isActive;
    public string dialogue;
    public TMP_Text popUpText;
    public int popUpTime = 0;



    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        if (dist <= 4f && Input.GetMouseButtonDown(0))
        {
            PopUp(dialogue);
        }
        if (isActive)
        {
            popUpTime++;
        }
        if(popUpTime >= 450) //change time with experimentation
        {
            isActive = false;
            popUpTime = 0;
            popUpBox.SetActive(false);
        }
        
    }

    public void PopUp(string text)
    {
        popUpBox.SetActive(true);
        isActive = true;
        popUpText.text = text;
       
    }
}
