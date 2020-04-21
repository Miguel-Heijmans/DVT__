using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunController : MonoBehaviour
{

    public bool isFiring;

    public BulletController bullet;

    public float bulletSpeed;

    public float timeBetweenShots;

    private float shotCounter;

    public Transform firePoint;

    public Text ammoCounterM;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isFiring)
        {
            shotCounter -= Time.deltaTime;
            if(shotCounter <0)
            {
               shotCounter = timeBetweenShots;
               BulletController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as BulletController;
               newBullet.speed -= bulletSpeed;
               weaponMain.machinegunAmmo -= 1;

            }
        } 
        else 
        {
            shotCounter = 0;
        }

        if(weaponMain.machinegunAmmo >= 0)
        {
            if (Input.GetMouseButtonDown(0))
            { isFiring = true; }
        }
        else
        {isFiring = false;}

        if (Input.GetMouseButtonUp(0))
        { isFiring = false; }


        ammoCounterM.text = "ammoM: " + weaponMain.machinegunAmmo;






        if (Input.GetKeyDown(KeyCode.Space))
        { 
            weaponMain.machinegunAmmo += 100;
        }
    } 


    WeaponMain weaponMain = new WeaponMain();
}

