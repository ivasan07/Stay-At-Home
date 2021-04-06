using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{
    public GameObject howToPlay;
    public GameObject menu;

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void ShowInstructions()
    {
        menu.SetActive(false);
        howToPlay.SetActive(true);
    }

    public void HideInstructions()
    {
        menu.SetActive(true);
        howToPlay.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
