using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    protected float damage { get; private set; } //ENCAPSULATION
    protected float range { get; private set; } //ENCAPSULATION
    protected float fireRate { get; private set; } //ENCAPSULATION
    protected float nextTimeToFire { get; private set; } //ENCAPSULATION
    public ParticleSystem muzzleFlash;

    protected Camera cam;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            muzzleFlash.Play();
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }
    }

    protected void Shoot() //ABSTRACTION
    {
        RaycastHit hitInfo;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, range))
        {
            Health target = hitInfo.transform.GetComponent<Health>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
    protected void Start()
    {
        SetValues();
        cam = Camera.main;
    }
    protected virtual void SetValues() //ABSTRACTION
    {
        damage = 10f;
        range = 100f;
        fireRate = 15f;
    }
}