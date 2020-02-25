using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : RayCastWeapons
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public override void Fire(Vector3 FireFromPosition)
    {
        if(Physics.Raycast(FireFromPosition,transform.forward,out raycastHit,Range))
        {
            HealthComponent health = raycastHit.collider.GetComponent<HealthComponent>();

            if(health)
            {
                ApplyDamage(health);
            }
        }

        base.Fire(FireFromPosition);
    }
}
