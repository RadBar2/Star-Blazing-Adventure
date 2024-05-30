using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Projectile : MonoBehaviour
{
    public Counter counter;
    public float speed = 20000;
    public float lifetime = 1;
    public int damage = 5;


    void Start()
    {
        counter = (Counter)FindObjectOfType(typeof(Counter));
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            Destroy(collision.gameObject);
            if(counter != null) counter.scoreText.text = $"Asteroids Destroyed: {++counter.score}/10";
            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("Missile"))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }

        if(collision.gameObject.CompareTag("Boss"))
        {
            var health = collision.gameObject.GetComponent<Health>();

            if (health != null)
            {
                health.TakeDamage(damage);

                if (health.hp <= health.maxHealt) 
                { 
                    damage += (health.maxHealt - health.hp) / 10;
                }
            }
            Destroy(this.gameObject);
        }
    }

}
