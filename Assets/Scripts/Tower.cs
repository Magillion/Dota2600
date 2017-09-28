using System.Collections;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public int playerteam;
    public int enemyhealth = 20;
    public int currenthealth = 20;
    public int enemydamage = 2;
    public float attackspeed = 1;
    public float enemyrange = 1.5f;

    // Use this for initialization
    void Start()
    {
        GetComponent<SpriteRenderer>().color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        // Simple change colour based on health level
        if (currenthealth < enemyhealth / 4)
        {
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        else if (currenthealth < enemyhealth / 2)
        {

            GetComponent<SpriteRenderer>().color = Color.yellow;
        }
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
