using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBack : MonoBehaviour
{

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void goBack()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
