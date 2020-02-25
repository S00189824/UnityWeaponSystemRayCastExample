using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastWeapons : Weapon
{
    protected RaycastHit raycastHit;
    public float Range;
    public float DamagePerHit;


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}


    protected void ApplyDamage(HealthComponent healthComponent)
    {
        healthComponent.ApplyDamage(DamagePerHit);
    }
}
