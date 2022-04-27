using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecycleGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GlobalLife.lifeValue -= 3;
        SceneManager.LoadScene("Level001");
    }
}
