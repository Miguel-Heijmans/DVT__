using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponShotgun : WeaponMain
{
    public bool isFiring;

    public BulletController bullet;

    public float bulletSpeed;

    public float timeBetweenShots;

    private float shotCounter;

    public Transform firePoint;
    public Transform firePoint1;
    public Transform firePoint2;

    public Text ammoCounterS;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isFiring)
        {
            shotCounter -= Time.deltaTime;
            if (shotCounter <=0)
            {
                shotCounter = timeBetweenShots;
                BulletController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as BulletController;
                BulletController newBullet1 = Instantiate(bullet, firePoint1.position, firePoint1.rotation) as BulletController;
                BulletController newBullet2 = Instantiate(bullet, firePoint2.position, firePoint2.rotation) as BulletController;
                newBullet.speed -= bulletSpeed;
                newBullet1.speed -= bulletSpeed;
                newBullet2.speed -= bulletSpeed;
                shotgunAmmo -= 1;

            }
            
            
        }


        if (shotgunAmmo >= 0)
        {
            if (Input.GetMouseButtonDown(0))
            { isFiring = true; 
            Shoot();}
        }
        else 
        {isFiring = false;}

        if (Input.GetMouseButtonUp(0))
        { isFiring = false; }

        

        ammoCounterS.text = "ammoS: " + shotgunAmmo;

        if (Input.GetKeyDown(KeyCode.Space))
        {

            shotgunAmmo += 50;
        }
    }
    private void Shoot(){

    }


    // WeaponMain weaponMain = new WeaponMain();
}
