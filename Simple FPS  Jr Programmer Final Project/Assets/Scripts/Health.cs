using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] protected float maxHealth;
    [SerializeField] public float currentHealth { get; private set; } //ENCAPSULATION

    public void TakeDamage(float damage) //ABSTRACTION
    {
        currentHealth -= damage;
    }
    void SetValues() //ABSTRACTION
    {
        currentHealth = maxHealth;
    }
    private void Start()
    {
        SetValues();
    }
}
