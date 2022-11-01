using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartAndFinish : MonoBehaviour
{
    public void StartLevel()
    {
        SceneManager.LoadScene("Experiment");
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("Start Scene");
    }

    public void EndLevel()
    {
        Application.Quit();
    }
}
