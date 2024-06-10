using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusScript : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float speed;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.down * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
