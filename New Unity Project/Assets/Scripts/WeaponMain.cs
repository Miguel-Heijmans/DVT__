using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMain : MonoBehaviour
{

    protected int ammoS = 200;

    public int selectedWeapon = 0;

    protected int ammoM = 100;

    public int shotgunAmmo
    {
        get { return ammoS ; }
        set { ammoS = value; }
    }

    public int machinegunAmmo
    {
        get { return ammoM; }
        set { ammoM = value; }
    }



    // void OnCollisionEnter(Collision collision)
    // {

    //     if (collision.gameObject.tag == "Ammo")
    //     {
    //         machinegunAmmo += 100;
    //         shotgunAmmo += 25;
    //     }


    // }

    // Start is called before the first frame update
    void Start()
    {
       selectWeapon(); 
    }

    void selectWeapon()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == selectedWeapon)
            {weapon.gameObject.SetActive(true);}
            else
            {weapon.gameObject.SetActive(false);}

            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        int previousSelectedWeapon = selectedWeapon;

        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (selectedWeapon >= transform.childCount -1)
            {selectedWeapon = 0;}
            else
            {selectedWeapon++;}
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (selectedWeapon <= 0)
            { selectedWeapon = transform.childCount - 1; }
            else
            { selectedWeapon--; }
        }

        if (previousSelectedWeapon != selectedWeapon)
        {selectWeapon();}

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {selectedWeapon = 0;}
        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2)
        { selectedWeapon = 1; }

        
    }
}
