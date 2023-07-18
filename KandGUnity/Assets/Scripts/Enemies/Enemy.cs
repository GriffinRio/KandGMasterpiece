using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float health;
    void Start()
    {
        health = 100f;
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
