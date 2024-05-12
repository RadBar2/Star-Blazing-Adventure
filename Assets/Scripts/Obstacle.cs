using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Obstacle : MonoBehaviour
{
    public float speed = 1000;

    void Update()
    {
        if (Spawner.stop) Destroy(this);

        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x <= -10)
        {
            Destroy(gameObject);
        }
    }

}

