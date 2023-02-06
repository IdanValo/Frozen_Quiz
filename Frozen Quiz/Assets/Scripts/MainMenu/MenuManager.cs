using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void SelectQuizs()
    {
        SceneManager.LoadSceneAsync("SelectQuiz");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
