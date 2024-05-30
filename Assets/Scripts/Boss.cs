using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    bool shootingMode = false;

    public GameObject deathLaser;

    void Update()
    {
        if (shootingMode)
        {
            Shoot();
        }

        var ownHealth = this.gameObject.GetComponent<Health>();

        if (ownHealth.hp <= 0.5 * ownHealth.maxHealt)
        {
            shootingMode = true;
        }
    }

    void Shoot()
    {
        Instantiate(deathLaser, transform.position, Quaternion.Euler(0, 0, 180));
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(gameObject.CompareTag("Player"))
        {
            var health = collision.gameObject.GetComponent<Health>();

            if (health != null)
            {
                health.TakeDamage(20);
            }

            Destroy(this.gameObject);
        }
    }
}
