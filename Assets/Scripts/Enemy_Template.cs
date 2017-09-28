using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int playerteam;
    public int currenthealth = 5;
    public int enemyhealth = 5;
    public int enemydamage = 2;
    public float attackspeed = 1;
    public float enemyrange = 1.5f;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Movement code should go here
    }

    // Whatever number is fed into this will be taken off
    // of the health of this entity.
    public void TakeDamage(int damage)
    {
        currenthealth = currenthealth - damage;
    }

    // To be called when applying damage to other entities.
    public int DoDamage()
    {
        return enemydamage;
    }
}
