using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour
{
    public GameObject powerUp;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Transform parent = transform.parent;

        BrickManager brickManager = parent.GetComponent<BrickManager>();
        brickManager.CheckVictory();

        Instantiate(powerUp, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}
