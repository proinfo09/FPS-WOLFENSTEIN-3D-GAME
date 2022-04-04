using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunPickup : MonoBehaviour
{
    public GameObject realHandgun;
    public GameObject pickupHandgun;
    public AudioSource handgunPickupSound;

    void OnTriggerEnter(Collider other)
    {
        realHandgun.SetActive(true);
        pickupHandgun.SetActive(false);
        handgunPickupSound.Play();
    }
}
