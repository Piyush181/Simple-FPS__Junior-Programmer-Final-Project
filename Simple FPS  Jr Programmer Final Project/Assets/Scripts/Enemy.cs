using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    [SerializeField] ParticleSystem explosionParticle;
    [SerializeField] Health health;
    [SerializeField] TextMeshProUGUI msgtxt;
    [SerializeField] protected string msg { get; set; }

    protected void Awake()
    {
        SetValues();
    }
    protected virtual void SetValues() //ABSTRACTION
    {
        health = GetComponent<Health>();
    }
    protected virtual void Die() //ABSTRACTION
    {
        Destroy(gameObject);
        explosionParticle.Play();
        msgtxt.text = msg;
    }
    protected void Update()
    {
        if (health.currentHealth <= 0)
        {
            Die();
        }
    }
}