using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDetection : MonoBehaviour
{
    public float speed;
    public float FOV;
    private Transform player;

    //Shooting
    public float shootingRange;
    public GameObject bulletPrefab;

    //Fire Rate
    public float fireRate = 1;
    private float nextFire;

    //Values
    public EnemyCounter enemyValues;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);
        if (distanceFromPlayer < FOV && distanceFromPlayer > shootingRange && !StealthSquare.stealthOn)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
        }
        else if (distanceFromPlayer <= shootingRange && nextFire < Time.time && !StealthSquare.stealthOn)
        {
            Instantiate(bulletPrefab, gameObject.transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
        else if (StealthSquare.stealthOn)
        { 
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            enemyValues.EnemiesKilled++;
            Destroy(gameObject);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, FOV);
        Gizmos.DrawWireSphere(transform.position, shootingRange);
    }
}
