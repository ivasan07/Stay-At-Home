using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static public GameManager instance;
    public int score = 0;
    public GameObject pausePanel;

    public GameObject losePanel;
    public TextMeshProUGUI mensaje;


    void Awake()
    {
        instance = this;

    }

    public void AddScore(int points)
    {
        score += points;
    }

    public void ChangeScene(string scene)
    {
        Time.timeScale = 1;
        score = 0;
        SceneManager.LoadScene(scene);
    }

    public void ShowMenu()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }

    public void HideMenu()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }

    public void CitizenKilled()
    {
        Time.timeScale = 0;
        losePanel.SetActive(true);
        mensaje.text = "Mataste a un civil inocente, por lo que fuiste despedido. Vuelve a intentarlo.";
    }
}
