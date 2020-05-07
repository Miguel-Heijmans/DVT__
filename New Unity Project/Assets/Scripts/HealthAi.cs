using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HealthAi : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {

        if (healthMain.enemyHp <= 0)
        {
            Destroy(gameObject);
        }

    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Projectile")
        {
            healthMain.enemyHp -= 10;
        }


    }

    HealthMain healthMain = new HealthMain();
}
