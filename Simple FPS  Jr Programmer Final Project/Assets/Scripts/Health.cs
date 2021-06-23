using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    protected float maxHealth { get; private set; } //ENCAPSULATION
    protected float currentHealth { get; private set; } //ENCAPSULATION

    protected virtual void SetValues() //ABSTRACTION
    {
        maxHealth = 100f;
        currentHealth = maxHealth;
    }
    public void TakeDamage(float damage) //ABSTRACTION
    {
        currentHealth -= damage;
    }
    private void Start()
    {
        SetValues();
    }
}
