using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public Animator animator;
    public int ammo = 3;
    public float fireRate = 3;
    public float reloadTime = 3;
    public GameObject bulletPrefab;
    public Transform spawnPoint;

    float lastShot = 0;
    SniperRotation sniperRot;

    GameObject laser;
    AudioSource audio;

    private void Start()
    {
        laser = transform.GetChild(0).gameObject;
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Ended && ammo > 0 && Time.time > lastShot + 1 / fireRate)
            {
                lastShot = Time.time;
                CreateBullet();
            }
        }

        audio.volume = AudioManager.instance.volume;
    }

    void CreateBullet()
    {
        if (Time.timeScale != 0)
        {
            ammo -= 1;
            Instantiate(bulletPrefab, spawnPoint.position, transform.rotation);
            audio.clip = AudioManager.instance.shot;
            audio.Play();


            if (ammo <= 0)
            {
                sniperRot = GetComponent<SniperRotation>();
                sniperRot.enabled = false;
                laser.SetActive(false);
                Invoke("PlaySound", 0.1f);
                Invoke("ReloadAmmo", reloadTime);
            }
        }
    }

    void ReloadAmmo()
    {
        sniperRot.enabled = true;
        laser.SetActive(true);
        ammo = 3;
    }

    void PlaySound()
    {
        audio.clip = AudioManager.instance.reload;
        audio.Play();
    }
}
