using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public float speed;
    public float wallShift;
    public Transform wallLeft;
    public Transform wallRight;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > wallLeft.position.x + wallShift)
        {
            transform.position += Vector3.left * speed;
        }

        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < wallRight.position.x - wallShift)
        {
            transform.position += Vector3.right * speed;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
