using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float health; 

    // Start is called before the first frame update
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float getHealth()
    {
        return health;
    }

    public void setHealth(float newHealth)
    {
        health = newHealth;
    }
}
