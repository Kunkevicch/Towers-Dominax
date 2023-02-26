using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestShooter : MonoBehaviour
{
    public GameObject projectile;
    public GameObject gunOne,gunTwo;
    public RotateToMouse rotateToMouse;
    private bool isFirstGunShooting = true;

    private float fireRate = 0.5f, nextShootTime=0.0f;

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetMouseButton(0) )
        {
            if(Time.time>nextShootTime)
            {
                nextShootTime +=fireRate;
                if ( isFirstGunShooting==true )
                {
                    Shoot(gunOne);
                }
                else
                {
                    Shoot(gunTwo);
                }
                
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
        isFirstGunShooting=!isFirstGunShooting;
    }
}
