using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxEnemy : Enemy //INHERITANCE
{
    protected override void Die() //POLYMORPHISM
    {
        base.Die();
    }
    protected override void SetValues() //POLYMORPHISM
    {
        base.SetValues();
        msg = "Why did u kille me?";
    }
    private new void Awake()
    {
        SetValues();
    }
}
