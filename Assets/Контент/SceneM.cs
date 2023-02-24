using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneM : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }

    public void Game()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
