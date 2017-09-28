using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

    List<Collider2D> enemiesInRangeList = new List<Collider2D>();//list of enemies in range
    GameObject enemyGameObject; //gameobject of the enemy
    Tower tower;

    public int enemyDamage = 2;
    public float attackSpeed = 1;


    void Start()
    {
        tower = GetComponent<Tower>(); //Currently getting a reference for the tower because of the way project is set up (will become a health reference)
    }

/// <summary>
/// When a collider enters the trigger, check it's an enemy and then add to a list of enemies 
/// so they can be attacked one by one. enemyInRange is the object that has entered the trigger
/// </summary>
/// <param name="enemyInRange"></param>
    void OnTriggerEnter(Collider2D enemyInRange)
    {
        enemyGameObject = enemyInRange.transform.gameObject;
        Movement enemyMovment = enemyInRange.GetComponent<Movement>();

        if (int.Parse(enemyMovment.playerNumber) != tower.playerTeam)
        {
            if (!enemiesInRangeList.Contains(enemyInRange))
            {
                enemiesInRangeList.Add(enemyInRange);
            }
        }

        foreach (Collider2D enem in enemiesInRangeList)
        {
            GameObject enemyToHit = enem.transform.gameObject;
            //TODO: when players/creeps have health reduce it here with set damage
        }
    }
    /// <summary>
    /// Remove the enemy from the list of enemies
    /// </summary>
    /// <param name="enemyLeavingRange"></param>
    void OnTriggerExit(Collider2D enemyLeavingRange)
    {
        if (enemiesInRangeList.Contains(enemyLeavingRange))
        {
            enemiesInRangeList.Remove(enemyLeavingRange);
        }
    }

    // To be called when applying damage to other entities.
    public int DoDamage()
    {
        return enemyDamage;
    }
}

