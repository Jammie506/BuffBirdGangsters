using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private Vector2 direction;
    public float dir;

    public GameObject poopUp, poopDown, poopRight, poopLeft;
    Vector2 bulletPos;
    

    void Start()
    {
        
    }
    
    void Update()
    {
        GetInput();
        Move();
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }

    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void GetInput()
    {
        direction = Vector2.zero;   

        if(Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;
            dir = 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
            dir = 2;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
            dir = 3;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
            dir = 4;
        }
    }

    void Fire()
    {
        bulletPos = transform.position;
        
        if (dir == 1)
        {
            Instantiate(poopUp, bulletPos, Quaternion.identity);
        }
        else if (dir == 2)
        {
            Instantiate(poopLeft, bulletPos, Quaternion.identity);
        }
        else if (dir == 3)
        {
            Instantiate(poopDown, bulletPos, Quaternion.identity);
        }
        else if (dir == 4)
        {
            Instantiate(poopRight, bulletPos, Quaternion.identity);
        }
    }
}
