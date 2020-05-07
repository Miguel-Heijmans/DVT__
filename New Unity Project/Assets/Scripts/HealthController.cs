using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthController : HealthMain
{
    public Slider healthBarSlider;

    public Text healthText;

    // Update is called once per frame
    void Update()
    {

        if (playerHp == 0)
        {
            SceneManager.LoadScene(sceneBuildIndex: 1);
        }

        healthBarSlider.maxValue = 100;
        healthBarSlider.value = playerHp;
        healthText.text = playerHp.ToString() + " / " + "100";
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Projectile")
        {
            playerHp -= 10;
        }


    }

     //HealthMain healthMain = new HealthMain();

            
   
}
