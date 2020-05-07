using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    public float speed;

    public float stoppingDistance;

    public float retreatDistance;

    private Transform player;

    private float timeBtwnShots;
    
    public float startTimeBetweenShots;

    public BulletController bullet;

    public Transform firePoint;

    public float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        timeBtwnShots = startTimeBetweenShots;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            
        }
        else if(Vector3.Distance(transform.position, player.position) < stoppingDistance && (Vector3.Distance(transform.position, player.position) > retreatDistance))
        {
            // transform.position = this.transform.position;
        }
        else if(Vector3.Distance(transform.position, player.position) < retreatDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }
        transform.LookAt(player.transform);

        if(timeBtwnShots <= 0){
            
            BulletController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as BulletController;
            timeBtwnShots = startTimeBetweenShots;
            newBullet.speed = bulletSpeed;

        } else {
            
            timeBtwnShots -= Time.deltaTime;
        }
    }
}
