using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour
{
    
    private Transform target;
    private string enemyTag;
    // private Enemy targetEnemy;

    [Header("Attributes")] // useful when public properties
    private float range; 
    private float fireRate; 
    private float fireCountdown;

    [Header("Setup")]
    public Transform firePoint;
    public GameObject bulletPrefab;

    void Start() {
        range = 3.0f; // tower shooting range
        fireRate = 3.0f; // bullet number shooted per second
        fireCountdown = 0.0f; // timer
        enemyTag = "Minion";
        InvokeRepeating("UpdateTarget", 0.0f, 0.5f); // invoke UpdateTarget() every 0.5 seconds starts from 0 second
    }

    void Update()
    {
        if (target == null) {
            return;
        } 

        if (fireCountdown <= 0.0f) {
            Shoot();
            fireCountdown = 1.0f / fireRate;
        }

        fireCountdown -= Time.deltaTime;
    }

    // locate enemy
    void UpdateTarget() {
           GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
           float shortestDistance = Mathf.Infinity;
           GameObject nearestEnemy = null;
           foreach (GameObject enemy in enemies)
           {
               float distanceToEnemy = Vector2.Distance(transform.position, enemy.transform.position);
               if (distanceToEnemy < shortestDistance) {
                    shortestDistance = distanceToEnemy;
                    nearestEnemy = enemy;
               }   
           }

           if (nearestEnemy != null && shortestDistance < range) {
               target = nearestEnemy.transform;
               // targetEnemy = nearestEnemy.GetComponent<Enemy>();
               
           } else {
               target = null;
           }
    }

    public void Shoot() {
        // "object casting": create a temporary gameObject for Instantiate object
        GameObject bulletInst = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletInst.GetComponent<Bullet>();

        if (bullet != null) {
            bullet.LocateTarget(target);
        }
    }


    // show tower shooting range | red line | will disappear when un-select the tower gameObject
    private void OnDrawGizmosSelected() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
        
    }

}

