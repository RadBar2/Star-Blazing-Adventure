using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Projectile : MonoBehaviour
{
    public Counter counter;
    public float speed = 20000;
    public float lifetime = 1;


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
            counter.scoreText.text = $"Asteroids Destroyed: {++counter.score}/100";
            Destroy(this.gameObject);
        }
    }

}
