using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPC : MonoBehaviour
{
    [SerializeField] int points = 1;
    [SerializeField] bool loseGame = false;
    GameObject losePanel;
    public bool corona = false, walking = false;

    AudioSource audio;

    private void Start()
    {
        losePanel = GameObject.Find("LosePanel");
        audio = GetComponent<AudioSource>();
        audio.clip = AudioManager.instance.impact;
    }


    private void Update()
    {
        audio.volume = AudioManager.instance.volume;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Bullet>())
        {
            audio.Play();
            if (loseGame)
            {
                GameManager.instance.CitizenKilled();
            }
            else
            {
                GameManager.instance.AddScore(points);
                Destroy(gameObject, 0.05f);
            }
        }
    }
}
