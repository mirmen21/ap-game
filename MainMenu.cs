using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("game1");
        //SceneManager.GetActiveScene().buildIndex + 1 in place of game1 if it doesnt work
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit(); 
    }
}
