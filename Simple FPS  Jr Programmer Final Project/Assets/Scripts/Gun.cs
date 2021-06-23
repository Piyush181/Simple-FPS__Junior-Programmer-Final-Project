using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    protected float damage { get; private set; } //ENCAPSULATION
    protected float range { get; private set; } //ENCAPSULATION
    protected float fireRate { get; private set; } //ENCAPSULATION
    protected float nextTimeToFire { get; private set; } //ENCAPSULATION
    public ParticleSystem muzzleFlash;
    protected GunControls controls;

    protected Camera cam;

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
    protected void Awake()
    {
        SetValues();
        cam = Camera.main;
        controls = new GunControls();
        controls.AK47.Shoot.performed += _ => PreShoot();
        controls.AK47.Shoot.performed += _ => Shoot();
    }
    protected virtual void SetValues() //ABSTRACTION
    {
        damage = 10f;
        range = 100f;
        fireRate = 15f;
    }
    protected void OnEnable()
    {
        controls.Enable();
    }
    protected void PreShoot() //ABSTRACTION
    {
        Debug.Log("Shot!");
        muzzleFlash.Play();
        nextTimeToFire = Time.time + 1f / fireRate;
    }
}