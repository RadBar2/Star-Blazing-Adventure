using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float speed = 10;

    public GameObject bulletPrefab;
    public float projectiles = 3;
    public Transform firepoint;

    Rigidbody2D rb;
    AudioSource audio;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
    }
    void Update()
    {
        var x = Input.GetAxisRaw("Horizontal");
        var y = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(x * speed * Time.deltaTime, y * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && --projectiles >= 0)
        {
            Instantiate(bulletPrefab, firepoint.position, transform.rotation);
            audio.Play();
            projectiles--;
        }
        else if (projectiles <= 3)
        {
            projectiles += 0.5f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Asteroid")) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
