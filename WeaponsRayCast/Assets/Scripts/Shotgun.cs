using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : RayCastWeapons
{

    public Vector3 spread = new Vector3(0.1f, 0, 0);


    public override void Fire(Vector3 FireFromPosition)
    {

        ShootRay(FireFromPosition, transform.forward);
        ShootRay(FireFromPosition, transform.forward + spread);
        ShootRay(FireFromPosition, transform.forward - spread);

        base.Fire(FireFromPosition);
    }


    public void ShootRay(Vector3 position,Vector3 direction)
    {
        if (Physics.Raycast(position,transform.forward, out raycastHit, Range))
        {
            HealthComponent health = raycastHit.collider.GetComponent<HealthComponent>();

            if (health)
            {
                ApplyDamage(health);
            }
        }
    }
}
