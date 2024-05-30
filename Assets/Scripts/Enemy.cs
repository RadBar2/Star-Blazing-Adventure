using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 1;
    public GameObject missile;

    void Start () 
    {
        InvokeRepeating(nameof(Shoot), 0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    void Shoot()
    {
        Instantiate(missile, transform.position, Quaternion.Euler(0, 0, 180));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            var health = collision.gameObject.GetComponent<Health>();

            if (health != null) health.TakeDamage(5);

            Destroy(this.gameObject);
        }
    }
}
