using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public int enemyHeath = 20;
    public bool enemyDead = false;
    public GameObject enemyAI;

    void DamageEnemy (int damageAmount)
    {
        enemyHeath -= damageAmount;
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyHeath <= 0 && enemyDead == false)
        {
            enemyDead = true;
            this.GetComponent<Animator>().Play("Death");
            enemyAI.SetActive(false);
        }
    }
}
