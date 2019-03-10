using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float MoveSpeed;
    public float LifeTime;
    public float Distance;
    public LayerMask whatIsSolid;

    void Start()
    {
        Invoke("DestroyBullet", LifeTime);
    }

    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, Distance, whatIsSolid);

        if (hitInfo.collider != null)
        {
            if (hitInfo.collider.tag == "Enemy")
            {
                Debug.Log("Enemy");
            }

            DestroyBullet();
        }

        transform.Translate(transform.up * MoveSpeed * Time.deltaTime);
    }

    public void DestroyBullet()
    {
        Destroy(gameObject);
    }
}