using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{

    public float offset;

    public GameObject Bullet;
    public Transform ShootPoint;

    private float TimeBtwShoots;
    public float StartTimeBtwShoots;

    void Start()
    {

    }

    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        if (TimeBtwShoots <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(Bullet, ShootPoint.position, transform.rotation);
                TimeBtwShoots = StartTimeBtwShoots;
            }
        }
        else
        {
            TimeBtwShoots -= Time.deltaTime;
        }
    }
}