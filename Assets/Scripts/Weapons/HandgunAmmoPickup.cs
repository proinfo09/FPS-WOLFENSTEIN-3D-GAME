using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandgunAmmoPickup : MonoBehaviour
{
    public GameObject pickupAmmoClip;
    public AudioSource ammoPickupSound;

    void OnTriggerEnter(Collider other)
    {
        pickupAmmoClip.SetActive(false);
        ammoPickupSound.Play();
        GlobaAmmo.handgunAmmo += 10;
    }
}
