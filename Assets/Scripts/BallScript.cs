using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float speed;
    bool isLauchned;
    public Rigidbody2D rigidbody2D;


    void Start()
    {
        isLauchned = false;
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isLauchned)
        {
            rigidbody2D.velocity = Vector2.one * speed;
            isLauchned = true;

            transform.parent = null;

        }
    }
}
