using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdateScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;


    void Update()
    {
        GameManager gm = GameManager.instance;
        scoreText.text = gm.score.ToString();
    }
}
