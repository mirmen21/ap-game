using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnswerInput : MonoBehaviour
{
    public string answer;
    public GameObject inputField;
    public string correctAns = "589";


    public void checkName()
    {
        answer = inputField.GetComponent<Text>().text;
        if (answer.Equals(correctAns))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene("GameOver");
        }
        
    }
}
