using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestShooter : MonoBehaviour
{
    public GameObject projectile;
    public GameObject gunOne,gunTwo;
    public RotateToMouse rotateToMouse;

    private float fireRate = 0.3f, firstGunNextShootTime=0.1f,secondGunNextShootTime=0.8f;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if ( Input.GetMouseButton(0) )
        {
            if ( Time.time>firstGunNextShootTime )
            {
                firstGunNextShootTime+=fireRate;
                Shoot(gunOne);

            }
            if ( Time.time>secondGunNextShootTime )
            {
                secondGunNextShootTime+=fireRate;
                Shoot(gunTwo);
            }
        }
    }

    private void Shoot(GameObject gun)
    {
        GameObject VFX=Instantiate(projectile, gun.transform.position, Quaternion.identity);
        if ( rotateToMouse!=null )
        {
            VFX.transform.localRotation=rotateToMouse.GetRotation();
        }
    }
}
