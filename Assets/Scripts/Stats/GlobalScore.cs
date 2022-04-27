using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour
{
    public GameObject scoreDisplay;
    public static int scoreValue = 0;
    public int interalScore;

    // Update is called once per frame
    void Update()
    {
        interalScore = scoreValue;
        scoreDisplay.GetComponent<Text>().text = "" + scoreValue;
    }
}
