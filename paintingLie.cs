using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class paintingLie : MonoBehaviour
{
    private string tagName = "Light";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == tagName)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("GameOver");
        }
    }
}
