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

    void OnTriggerEnter(Collider other)
    {
        realHandgun.SetActive(true);
        pickupHandgun.SetActive(false);
        handgunPickupSound.Play();
        GetComponent<BoxCollider>().enabled = false;
        pickUpDisplay.SetActive(false);
        pickUpDisplay.GetComponent<Text>().text = "HANDGUN";
        pickUpDisplay.SetActive(true);
    }
}
