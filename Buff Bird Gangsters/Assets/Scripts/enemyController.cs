using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    public float speed;
    public Transform player;

    Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector2 direction = player.position - transform.position;
        transform.Translate(direction * speed * Time.deltaTime);
    }
} 