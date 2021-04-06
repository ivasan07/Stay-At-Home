using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Deathzone : MonoBehaviour
{
    public TextMeshProUGUI texto;
    public GameObject panel;

    AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.clip = AudioManager.instance.score;
    }

    private void Update()
    {
        audio.volume = AudioManager.instance.volume;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        NPC npc = collision.GetComponent<NPC>();
        Bullet bullet = collision.GetComponent<Bullet>();

        if (npc)
        {
            if (npc.corona)
            {
                panel.SetActive(true);
                Time.timeScale = 0;
                texto.text = "Fuiste infectado. Vuelve a intentarlo.";
            }
            else if (npc.walking)
            {
                panel.SetActive(true);
                Time.timeScale = 0;
                texto.text = "Dejaste que un civil se salte la cuarentena, por lo que fuiste despedido. Vuelve a intentarlo.";
            }
            else
            {
                audio.Play();
                GameManager.instance.AddScore(1);
                Destroy(collision.gameObject);
            }
        }

        if (bullet) Destroy(collision.gameObject);
    }
}
