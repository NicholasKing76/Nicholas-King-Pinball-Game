using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void StartPlay()
    {
        SceneManager.LoadScene("Starter Scene");
    }
    public void QuitPlay()
    {
        SceneManager.LoadScene("Exit");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Intro");
    }
    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
