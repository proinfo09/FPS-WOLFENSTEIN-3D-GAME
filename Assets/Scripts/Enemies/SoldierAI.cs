using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierAI : MonoBehaviour
{
    public string hitTag;
    public bool lookingAtPlayer = false;
    public GameObject theSoldier;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            hitTag = hit.transform.tag;
            
        }
        if(hitTag == "Player")
        {
            theSoldier.GetComponent<Animator>().Play("demo_combat_shoot");
            lookingAtPlayer = true;
        }
        else
        {
            theSoldier.GetComponent<Animator>().Play("demo_combat_idle");
            lookingAtPlayer = false;
        }
    }
}
