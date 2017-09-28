using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Tower : MonoBehaviour
{
    public int playerTeam;
    public int enemyHealth = 20;
    public int currentHealth = 20;
    public float enemyRange = 1.5f;


    // Use this for initialization
    void Start()
    {
        GetComponent<SpriteRenderer>().color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        // Simple change colour based on health level
        if (currentHealth < enemyHealth / 4)
        {
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        else if (currentHealth < enemyHealth / 2)
        {

            GetComponent<SpriteRenderer>().color = Color.yellow;
        }
    }

    // Whatever number is fed into this will be taken off
    // of the health of this entity.
    public void TakeDamage(int damage)
    {
        currentHealth = currentHealth - damage;
    }


}
   