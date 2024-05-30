using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathLaser : MonoBehaviour
{
    public float speed = 250;
    public int damage = 25;

    AudioSource audio;
    public AudioClip shoot;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.PlayOneShot(shoot);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.forward * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            var health = collision.gameObject.GetComponent<Health>();

            if (health != null) health.TakeDamage(damage);

            Destroy(this.gameObject);
        }
    }

}
