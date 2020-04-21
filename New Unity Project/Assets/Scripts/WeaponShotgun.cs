using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponShotgun : MonoBehaviour
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
            
            if (shotCounter <=0)
            {
                shotCounter = timeBetweenShots;
                BulletController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as BulletController;
                BulletController newBullet1 = Instantiate(bullet, firePoint1.position, firePoint1.rotation) as BulletController;
                BulletController newBullet2 = Instantiate(bullet, firePoint2.position, firePoint2.rotation) as BulletController;
                newBullet.speed -= bulletSpeed;
                newBullet1.speed -= bulletSpeed;
                newBullet2.speed -= bulletSpeed;
                weaponMain.shotgunAmmo -= 1;

            }
            else
            {
                shotCounter = 0;
            }
            
        }


        if (weaponMain.shotgunAmmo >= 0)
        {
            if (Input.GetMouseButtonDown(0))
            { isFiring = true; }
        }
        else 
        {isFiring = false;}

        if (Input.GetMouseButtonUp(0))
        { isFiring = false; }

        

        ammoCounterS.text = "ammoS: " + weaponMain.shotgunAmmo;

        if (Input.GetKeyDown(KeyCode.Space))
        {

            weaponMain.shotgunAmmo += 50;
        }
    }


    WeaponMain weaponMain = new WeaponMain();
}
