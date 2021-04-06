using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammo : MonoBehaviour
{
    public Image bullet1;
    public Image bullet2;
    public Image bullet3;

    public Fire fire;

    void Update()
    {
        int ammo = fire.ammo;

        if (ammo == 3)
        {
            bullet1.enabled = true;
            bullet2.enabled = true;
            bullet3.enabled = true;
        }
        else if (ammo == 2)
        {
            bullet1.enabled = true;
            bullet2.enabled = true;
            bullet3.enabled = false;
        }
        else if (ammo == 1)
        {
            bullet1.enabled = true;
            bullet2.enabled = false;
            bullet3.enabled = false;
        }
        else if (ammo == 0)
        {
            bullet1.enabled = false;
            bullet2.enabled = false;
            bullet3.enabled = false;
        }
    }
}
