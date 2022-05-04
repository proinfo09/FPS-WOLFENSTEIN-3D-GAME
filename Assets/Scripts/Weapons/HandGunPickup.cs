using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandGunPickup : MonoBehaviour
{
    public GameObject realHandgun;
    public GameObject pickupHandgun;
    public AudioSource handgunPickupSound;
    public GameObject pickUpDisplay;
    public GameObject pistolImage;
    public string pickupNote;

    void OnTriggerEnter(Collider other)
    {
        realHandgun.SetActive(true);
        pickupHandgun.SetActive(false);
        handgunPickupSound.Play();
        GetComponent<BoxCollider>().enabled = false;
        pickUpDisplay.SetActive(false);
        pickUpDisplay.GetComponent<Text>().text = pickupNote;
        pickUpDisplay.SetActive(true);
        pistolImage.SetActive(true);
    }
}
