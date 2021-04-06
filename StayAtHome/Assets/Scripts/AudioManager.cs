using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioClip ambient;
    public AudioClip shot;
    public AudioClip impact;
    public AudioClip score;
    public AudioClip reload;

    public float volume = 0;

    public AudioSource audio;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(this);
    }

    public void RestartAudio()
    {
        audio.Stop();
        audio.Play();
    }

    private void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Play();
    }

    public void ChangeVolume(float vol)
    {
        volume = vol;
        audio.volume = volume;
    }
}
