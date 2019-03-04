﻿using System.Collections;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    public float bulletX = 0f;
    public float bulletY = 0f;

    Rigidbody2D rB;

    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rB.velocity = new Vector2(bulletX, bulletY);
        void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    }
}