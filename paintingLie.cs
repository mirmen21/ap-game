using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class paintingLie : MonoBehaviour
{
    private string tagName = "Candy";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == tagName)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
