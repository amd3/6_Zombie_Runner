﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] float damage = 10f;
    [SerializeField] float range = 100f;
    [SerializeField] Camera FPCamera;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    private void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(FPCamera.transform.position,FPCamera.transform.forward, out hit, range));
        {
            Health target = hit.transform.GetComponent<Health>();
            if (target == null) return;
            target.TakeDamage(damage);
            print("I hit: " + hit.transform.name + "for " + damage);
        }
    }
}
